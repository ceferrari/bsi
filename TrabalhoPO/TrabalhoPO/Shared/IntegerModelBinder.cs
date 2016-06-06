using System;
using System.Web.Mvc;

namespace TrabalhoPO.Shared
{
    public class IntegerModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            ValueProviderResult valueProviderResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            ModelState modelState = new ModelState { Value = valueProviderResult };

            object actualValue = null;

            if (!String.IsNullOrWhiteSpace(valueProviderResult.AttemptedValue))
            {
                try
                {
                    actualValue = Convert.ToInt32(valueProviderResult.AttemptedValue.Replace(".", String.Empty));
                }
                catch (FormatException e)
                {
                    modelState.Errors.Add(e);
                }
            }

            bindingContext.ModelState.Add(bindingContext.ModelName, modelState);

            return actualValue;
        }
    }
}
using System;
using System.Web.Mvc;

namespace TrabalhoPO.Shared
{
    public class DateTimeModelBinder : IModelBinder
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
                    var miliseconds = valueProviderResult.AttemptedValue.Replace("/Date(", "").Replace(")/", "");
                    actualValue = (new DateTime(1970, 1, 1)).AddMilliseconds(double.Parse(miliseconds));
                }
                catch (FormatException ex)
                {
                    modelState.Errors.Add(ex);
                }
            }

            bindingContext.ModelState.Add(bindingContext.ModelName, modelState);

            return actualValue;
        }
    }
}
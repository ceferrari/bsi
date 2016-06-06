using System;
using System.Globalization;
using System.Web.Mvc;

namespace TrabalhoPO.Shared
{
    public class DecimalModelBinder : IModelBinder
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
                    actualValue = Convert.ToDecimal(valueProviderResult.AttemptedValue, CultureInfo.CurrentCulture);
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
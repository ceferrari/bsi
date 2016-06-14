using System;
using System.Globalization;
using System.Web.Mvc;

namespace TrabalhoPO.Shared
{
    public class DecimalModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            object result = null;

            var modelName = bindingContext.ModelName;
            var attemptedValue = bindingContext.ValueProvider.GetValue(modelName).AttemptedValue;

            var wantedSeperator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            var alternateSeperator = (wantedSeperator == "," ? "." : ",");

            if (attemptedValue.IndexOf(wantedSeperator) == -1 && attemptedValue.IndexOf(alternateSeperator) != -1)
            {
                attemptedValue = attemptedValue.Replace(alternateSeperator, wantedSeperator);
            }

            try
            {
                if (bindingContext.ModelMetadata.IsNullableValueType && string.IsNullOrWhiteSpace(attemptedValue))
                {
                    return null;
                }

                result = decimal.Parse(attemptedValue, NumberStyles.Any);
            }
            catch (FormatException ex)
            {
                bindingContext.ModelState.AddModelError(modelName, ex);
            }

            return result;
        }
    }
}
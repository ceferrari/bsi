using System;
using System.Globalization;
using System.Web.Mvc;

namespace TrabalhoPO.Shared
{
    public class IntegerModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            object result = null;

            var modelName = bindingContext.ModelName;
            var attemptedValue = bindingContext.ValueProvider.GetValue(modelName).AttemptedValue;

            try
            {
                if (bindingContext.ModelMetadata.IsNullableValueType && string.IsNullOrWhiteSpace(attemptedValue))
                {
                    return null;
                }

                result = int.Parse(attemptedValue, NumberStyles.AllowThousands, CultureInfo.CurrentCulture);
            }
            catch (FormatException ex)
            {
                bindingContext.ModelState.AddModelError(modelName, ex);
            }

            return result;
        }
    }
}
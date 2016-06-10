using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Net;
using System.Web.Mvc;

namespace Contatos.Controllers
{
    public class JsonController : Controller
	{
		public new ActionResult Json(object data, JsonRequestBehavior behavior)
		{
			try
			{
				var jsonSerializerSetting = new JsonSerializerSettings
				{
					ContractResolver = new CamelCasePropertyNamesContractResolver()
				};

				if (Request.RequestType == WebRequestMethods.Http.Get && behavior == JsonRequestBehavior.DenyGet)
				{
					throw new InvalidOperationException("Método GET não permitido para este request.");
				}

				var jsonResult = new ContentResult
				{
					Content = JsonConvert.SerializeObject(data, jsonSerializerSetting),
					ContentType = "application/json"
				};

				return jsonResult;
			}
			catch
			{
				return null;
			}
		}
	}
}
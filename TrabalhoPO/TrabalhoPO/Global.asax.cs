using System;
using System.Globalization;
using System.Security.Claims;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TrabalhoPO.Shared;

namespace TrabalhoPO
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.GetCultureInfo("pt-BR");

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ClientDataTypeModelValidatorProvider.ResourceClassKey = "ValidationMessages";
            DefaultModelBinder.ResourceClassKey = "ValidationMessages";

            ModelBinders.Binders.Add(typeof(int), new IntegerModelBinder());
            ModelBinders.Binders.Add(typeof(int?), new IntegerModelBinder());
            ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
            ModelBinders.Binders.Add(typeof(decimal?), new DecimalModelBinder());
            ModelBinders.Binders.Add(typeof(DateTime), new DateTimeModelBinder());
            ModelBinders.Binders.Add(typeof(DateTime?), new DateTimeModelBinder());

            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
        }

        protected void Application_Error()
        {
            HttpContext httpContext = HttpContext.Current;

            if (httpContext != null)
            {
                RequestContext requestContext = ((MvcHandler)httpContext.CurrentHandler).RequestContext;

                if (requestContext.HttpContext.Request.IsAjaxRequest())
                {
                    httpContext.Response.Clear();

                    string controllerName = requestContext.RouteData.GetRequiredString("controller");
                    IControllerFactory factory = ControllerBuilder.Current.GetControllerFactory();
                    IController controller = factory.CreateController(requestContext, controllerName);
                    ControllerContext controllerContext = new ControllerContext(requestContext, (ControllerBase)controller);

                    JsonResult jsonResult = new JsonResult();
                    jsonResult.Data = new { success = false, serverError = "500" };
                    jsonResult.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
                    jsonResult.ExecuteResult(controllerContext);

                    httpContext.Response.End();
                }
                else
                {
                    httpContext.Response.Redirect("~/Home/Erro");
                }
            }
        }

        protected void Application_BeginRequest()
        {
            HttpContext.Current.Response.Cache.SetAllowResponseInBrowserHistory(false);
            HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            HttpContext.Current.Response.Cache.SetNoStore();
            Response.Cache.SetExpires(DateTime.Now);
            Response.Cache.SetValidUntilExpires(true);
        }
    }
}
using System;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrabalhoPO.DAL;

namespace TrabalhoPO.Controllers
{
    public class BaseController : Controller
    {
        protected MyContext db = new MyContext();

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null || filterContext.ExceptionHandled)
            {
                return;
            }

            var message = filterContext.Exception.Message;

            filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.BadRequest, message);

            filterContext.ExceptionHandled = true;
        }
    }
}
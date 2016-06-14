using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
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

        protected override void OnException(ExceptionContext context)
        {
            if (context == null || context.ExceptionHandled)
            {
                return;
            }

            var message = context.Exception.Message;
            context.Result = new HttpStatusCodeResult(HttpStatusCode.BadRequest, message);
            context.ExceptionHandled = true;
        }
    }
}
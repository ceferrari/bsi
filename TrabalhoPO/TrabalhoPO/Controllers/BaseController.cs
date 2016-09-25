using System.Net;
using System.Web.Mvc;
using TrabalhoPO.DAL;
using TrabalhoPO.Shared;

namespace TrabalhoPO.Controllers
{
    public abstract class BaseController : Controller
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

            var exception = context.Exception;
            var message = exception.Message;
            while (exception.InnerException != null)
            {
                message = exception.InnerException.Message;
                exception = exception.InnerException;
            }

            message = message.Replace("\"", "'");

            context.Result = new HttpStatusCodeResult(HttpStatusCode.BadRequest, message);
            context.ExceptionHandled = true;

            new ErrorLogger().Log(exception);
        }
    }
}
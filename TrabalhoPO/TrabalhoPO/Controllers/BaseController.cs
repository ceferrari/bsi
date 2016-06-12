using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
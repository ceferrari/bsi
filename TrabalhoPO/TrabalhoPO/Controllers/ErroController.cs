using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabalhoPO.Controllers
{
    public class ErroController : Controller
    {
        public ActionResult ErroModal(string mensagem)
        {
            return PartialView("~/Views/Shared/_ModalErro.cshtml", mensagem);
        }
    }
}
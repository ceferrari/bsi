using System.Web.Mvc;
using System.Web.Script.Serialization;
using TrabalhoPO.Models;
using TrabalhoPO.Models.Factories;

namespace TrabalhoPO.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Erro()
        {
            return View("~/Views/Shared/Erro.cshtml");
        }

        public ActionResult Modal(string jsonModal, string tipo)
        {
            Modal modal = new ModalFactory().criar(tipo, new JavaScriptSerializer().Deserialize<Modal>(jsonModal));

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }
    }
}
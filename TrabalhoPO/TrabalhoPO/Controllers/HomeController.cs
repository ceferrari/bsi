using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TrabalhoPO.Models;
using TrabalhoPO.Models.Factories;
using static TrabalhoPO.Models.Factories.ModalFactory;

namespace TrabalhoPO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Modal(string jsonModal, string tipo)
        {
            Modal modal = new ModalFactory().criar(tipo, new JavaScriptSerializer().Deserialize<Modal>(jsonModal));

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }
    }
}
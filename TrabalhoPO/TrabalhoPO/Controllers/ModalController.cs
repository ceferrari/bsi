using System.Web.Mvc;
using System.Web.Script.Serialization;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    public class ModalController : Controller
    {
        public ActionResult Sucesso(string jsonModel)
        {
            Modal modal = new JavaScriptSerializer().Deserialize<Modal>(jsonModel);

            modal.Id = modal.Id ?? "SucessoModal";
            modal.ClasseCabecalho = modal.ClasseCabecalho ?? "text-success";
            modal.IconeCabecalho = modal.IconeCabecalho ?? "fa fa-check-circle";
            modal.Titulo = modal.Titulo ?? "Sucesso";
            modal.Mensagem = modal.Mensagem ?? "Operação concluída com êxito.";
            modal.TextoBotao = modal.TextoBotao ?? "Fechar";

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }

        public ActionResult Alerta(string jsonModel)
        {
            Modal modal = new JavaScriptSerializer().Deserialize<Modal>(jsonModel);

            modal.Id = modal.Id ?? "AlertaModal";
            modal.ClasseCabecalho = modal.ClasseCabecalho ?? "text-warning";
            modal.IconeCabecalho = modal.IconeCabecalho ?? "fa fa-warning";
            modal.Titulo = modal.Titulo ?? "Alerta";
            modal.Mensagem = modal.Mensagem ?? "Mensagem padrão de alerta.";
            modal.TextoBotao = modal.TextoBotao ?? "Fechar";

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }

        public ActionResult Erro(string jsonModel)
        {
            Modal modal = new JavaScriptSerializer().Deserialize<Modal>(jsonModel);

            modal.Id = modal.Id ?? "ErroModal";
            modal.ClasseCabecalho = modal.ClasseCabecalho ?? "text-danger";
            modal.IconeCabecalho = modal.IconeCabecalho ?? "fa fa-times-cricle";
            modal.Titulo = modal.Titulo ?? "Erro";
            modal.Mensagem = modal.Mensagem ?? "Ocorreu um erro inesperado. Tente novamente.";
            modal.TextoBotao = modal.TextoBotao ?? "Fechar";

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }
    }
}
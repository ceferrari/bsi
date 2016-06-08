using System.Web.Mvc;
using System.Web.Script.Serialization;
using TrabalhoPO.Models;

namespace TrabalhoPO.Controllers
{
    public class ModalController : Controller
    {
        public ActionResult Sucesso(string json)
        {
            Modal modal = new JavaScriptSerializer().Deserialize<Modal>(json);

            modal.Id = modal.Id ?? "SucessoModal";
            modal.ClasseCabecalho = modal.ClasseCabecalho ?? "text-success";
            modal.IconeCabecalho = modal.IconeCabecalho ?? "fa fa-check-circle";
            modal.Titulo = modal.Titulo ?? "Sucesso";
            modal.Mensagem = modal.Mensagem ?? "Operação concluída com êxito.";
            modal.TextoBotaoPadrao = modal.TextoBotaoPadrao ?? "Fechar";

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }

        public ActionResult Alerta(string json)
        {
            Modal modal = new JavaScriptSerializer().Deserialize<Modal>(json);

            modal.Id = modal.Id ?? "AlertaModal";
            modal.ClasseCabecalho = modal.ClasseCabecalho ?? "text-warning";
            modal.IconeCabecalho = modal.IconeCabecalho ?? "fa fa-warning";
            modal.Titulo = modal.Titulo ?? "Alerta";
            modal.Mensagem = modal.Mensagem ?? "Ocorreu um erro inesperado. Tente novamente.";
            modal.TextoBotaoPadrao = modal.TextoBotaoPadrao ?? "Fechar";

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }

        public ActionResult Erro(string json)
        {
            Modal modal = new JavaScriptSerializer().Deserialize<Modal>(json);

            modal.Id = modal.Id ?? "ErroModal";
            modal.ClasseCabecalho = modal.ClasseCabecalho ?? "text-danger";
            modal.IconeCabecalho = modal.IconeCabecalho ?? "fa fa-times-circle";
            modal.Titulo = modal.Titulo ?? "Erro";
            modal.Mensagem = modal.Mensagem ?? "Erro desconhecido. Entre em contato com o administrador.";
            modal.TextoBotaoPadrao = modal.TextoBotaoPadrao ?? "Fechar";

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }

        public ActionResult Excluir(string modelo, string id, string descricao)
        {
            string mensagem = modelo.Equals("Produto") ? " o produto " : " a categoria ";

            Modal modal = new Modal();

            modal.Id = "ExcluirModal";
            modal.ClasseCabecalho = "text-danger";
            modal.IconeCabecalho = "fa fa-times-circle";
            modal.Titulo = "Excluir " + modelo;
            modal.Mensagem = "Tem certeza que deseja excluir" + mensagem + "<strong>" + id + " - " + descricao + "</strong> ?";
            modal.TextoBotaoPadrao = "Fechar";
            modal.TextoBotaoSecundario = "Confirmar";
            modal.ClasseBotaoSecundario = "btn btn-danger btn-custom";
            modal.AcaoBotaoSecundario = "exclui('" + modelo + "', " + id + ")";

            return PartialView("~/Views/Shared/_Modal.cshtml", modal);
        }
    }
}
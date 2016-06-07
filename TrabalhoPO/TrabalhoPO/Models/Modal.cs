namespace TrabalhoPO.Models
{
    public class Modal
    {
        public string Id { get; set; } = "ErroModal";
        public string ClasseCabecalho { get; set; } = "text-danger";
        public string IconeCabecalho { get; set; } = "fa fa-times-circle";
        public string Titulo { get; set; } = "Erro";
        public string Mensagem { get; set; } = "Erro desconhecido. Entre em contato com o administrador.";
        public string TextoBotao { get; set; } = "Fechar";
    }
}
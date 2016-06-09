namespace TrabalhoPO.Models.Factories
{
    public enum TipoModal
    {
        Sucesso,
        Alerta,
        Erro,
        Excluir
    }

    public class ModalFactory
    {
        public Modal criar(TipoModal tipo, Modal modal = null) 
        {
            return criar(tipo.ToString(), modal);
        }

        public Modal criar(string tipo, Modal modal = null)
        {
            if ("Sucesso".Equals(tipo))
            {
                return new Modal()
                {
                    Id = modal.Id ?? "SucessoModal",
                    ClasseCabecalho = modal.ClasseCabecalho ?? "text-success",
                    IconeCabecalho = modal.IconeCabecalho ?? "fa fa-check-circle",
                    Titulo = modal.Titulo ?? "Sucesso",
                    Mensagem = modal.Mensagem ?? "Operação concluída com êxito.",
                    TextoBotaoPadrao = modal.TextoBotaoPadrao ?? "Fechar",
                    ClasseBotaoPadrao = modal.ClasseBotaoPadrao ?? "btn btn-default btn-custom",
                    TextoBotaoSecundario = modal.TextoBotaoSecundario,
                    ClasseBotaoSecundario = modal.ClasseBotaoSecundario,
                    AcaoBotaoSecundario = modal.AcaoBotaoSecundario
                };
            }

            if ("Alerta".Equals(tipo))
            {
                return new Modal()
                {
                    Id = modal.Id ?? "AlertaModal",
                    ClasseCabecalho = modal.ClasseCabecalho ?? "text-warning",
                    IconeCabecalho = modal.IconeCabecalho ?? "fa fa-warning",
                    Titulo = modal.Titulo ?? "Alerta",
                    Mensagem = modal.Mensagem ?? "Ocorreu um erro inesperado. Tente novamente.",
                    TextoBotaoPadrao = modal.TextoBotaoPadrao ?? "Fechar",
                    ClasseBotaoPadrao = modal.ClasseBotaoPadrao ?? "btn btn-default btn-custom",
                    TextoBotaoSecundario = modal.TextoBotaoSecundario,
                    ClasseBotaoSecundario = modal.ClasseBotaoSecundario,
                    AcaoBotaoSecundario = modal.AcaoBotaoSecundario
                };
            }

            if ("Erro".Equals(tipo))
            {
                return new Modal()
                {
                    Id = modal.Id ?? "ErroModal",
                    ClasseCabecalho = modal.ClasseCabecalho ?? "text-danger",
                    IconeCabecalho = modal.IconeCabecalho ?? "fa fa-times-circle",
                    Titulo = modal.Titulo ?? "Erro",
                    Mensagem = modal.Mensagem ?? "Erro desconhecido. Entre em contato com o administrador.",
                    TextoBotaoPadrao = modal.TextoBotaoPadrao ?? "Fechar",
                    ClasseBotaoPadrao = modal.ClasseBotaoPadrao ?? "btn btn-default btn-custom",
                    TextoBotaoSecundario = modal.TextoBotaoSecundario,
                    ClasseBotaoSecundario = modal.ClasseBotaoSecundario,
                    AcaoBotaoSecundario = modal.AcaoBotaoSecundario
                };
            }

            if ("Excluir".Equals(tipo))
            {
                return new Modal()
                {
                    Id = modal.Id ?? "ExcluirModal",
                    ClasseCabecalho = modal.ClasseCabecalho ?? "text-danger",
                    IconeCabecalho = modal.IconeCabecalho ?? "fa fa-times-circle",
                    Titulo = modal.Titulo ?? "Excluir",
                    Mensagem = modal.Mensagem ?? "Tem certeza que deseja excluir o objeto ?",
                    TextoBotaoPadrao = modal.TextoBotaoPadrao ?? "Fechar",
                    ClasseBotaoPadrao = modal.ClasseBotaoPadrao ?? "btn btn-default btn-custom",
                    TextoBotaoSecundario = modal.TextoBotaoSecundario ?? "Confirmar",
                    ClasseBotaoSecundario = modal.ClasseBotaoSecundario ?? "btn btn-danger btn-custom",
                    AcaoBotaoSecundario = modal.AcaoBotaoSecundario
                };
            }

            return null;
        }
    }
}

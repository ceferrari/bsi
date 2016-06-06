using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrabalhoPO.Resources;

namespace TrabalhoPO.Models
{
    [Table("Produtos")]
    public class Produto : IIdentificavel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(128, ErrorMessage = "A Descrição deve ter no máximo {1} caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        [RegularExpression(@"^(?!0)(?:\d{1,3}|1(?:\.\d{3})+),\d{2}$", ErrorMessage = "O valor do Preço deve estar entre R$ 0,00 e R$ 500,00.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo Estoque Atual é obrigatório.")]
        [RegularExpression(@"^(?!0)(?:\d{1,3}|[1-4](?:\.\d{3})+)$", ErrorMessage = "O valor do Estoque Atual deve estar entre 0 e 5.000.")]
        public int EstoqueAtual { get; set; }

        [Required(ErrorMessage = "O campo Estoque Mínimo é obrigatório.")]
        [RegularExpression(@"^(?!0)(?:\d{1,3}|1(?:\.\d{3})+)$", ErrorMessage = "O valor do Estoque Mínimo deve estar entre 0 e 2.000.")]
        public int EstoqueMinimo { get; set; }

        public bool? PrecisaReposicao { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        public int Categoria { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public bool SetDescricao(string descricao)
        {
            if (descricao.Equals(""))
            {
                throw new Exception("O campo Descrição não pode ser vazio.");
            }

            Descricao = descricao;
            SetDataAlteracao();

            return true;
        }

        public bool SetPreco(decimal preco)
        {
            if (preco < 0)
            {
                throw new Exception("Nâo é possível definir um valor negativo para o Preço.");
            }

            Preco = preco;
            SetDataAlteracao();

            return true;
        }

        public bool SetEstoqueAtual(int qtd)
        {
            if (qtd < 0)
            {
                throw new Exception("O valor informado é inválido.");
            }

            EstoqueAtual = qtd;
            AtualizaCampos();

            return true;
        }

        public bool SetEstoqueMinimo(int qtd)
        {
            if (qtd < 0)
            {
                throw new Exception("O valor informado é inválido.");
            }

            EstoqueMinimo = qtd;
            AtualizaCampos();

            return true;
        }

        public bool Insere(int qtd)
        {
            SetEstoqueAtual(EstoqueAtual + qtd);

            return true;
        }

        public bool Retira(int qtd)
        {
            if (qtd > EstoqueAtual)
            {
                throw new Exception("Estoque insuficiente para a operação solicitada.");
            }

            SetEstoqueAtual(EstoqueAtual - qtd);

            return true;
        }

        public bool AumentaMinimo(int qtd)
        {
            SetEstoqueMinimo(EstoqueMinimo + qtd);

            return true;
        }

        public bool DiminuiMinimo(int qtd)
        {
            if (qtd > EstoqueMinimo)
            {
                throw new Exception("O Estoque Mínimo não pode ser negativo.");
            }

            SetEstoqueMinimo(EstoqueMinimo - qtd);

            return true;
        }

        public void AtualizaCampos()
        {
            SetPrecisaReposicao();
            SetDataAlteracao();
        }

        private void SetPrecisaReposicao()
        {
            PrecisaReposicao = EstoqueMinimo > EstoqueAtual;
        }

        private void SetDataAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}
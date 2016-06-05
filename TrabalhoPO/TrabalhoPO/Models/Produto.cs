using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPO.Models
{
    [Table("Produtos")]
    public class Produto : IIdentificavel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Descricao { get; set; }
        [Required]
        [Range(0, 500, ErrorMessage = "O preço deve estar entre R$ 0,00 e R$ 500,0.")]
        public decimal Preco { get; set; }
        [Required]
        [Range(0, 500)]
        public int EstoqueAtual { get; set; }
        [Required]
        [Range(0, 500)]
        public int EstoqueMinimo { get; set; }
        public bool? PrecisaReposicao { get; set; }
        [Required]
        public int Categoria { get; set; }
        public DateTime? DataAlteracao { get; set; }

        public Produto()
        {

        }

        public Produto(int id, string descricao, decimal preco, int atual, int minimo) : 
            this(id, descricao, preco, atual, minimo, null, null)
        {

        }

        public Produto(int id, string descricao, decimal preco, int atual, int minimo, bool? reposicao, DateTime? alteracao)
        {
            Id = id;
            SetDescricao(descricao);
            SetPreco(preco);
            SetEstoqueAtual(atual);
            SetEstoqueMinimo(minimo);
            if (reposicao != null)
            {
                PrecisaReposicao = reposicao;
            }
            if (alteracao != null)
            {
                DataAlteracao = alteracao;
            }
        }

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
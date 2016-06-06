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
        [Range(0, 500)]
        public decimal Preco { get; set; }

        [Required]
        [Range(0, 5000)]
        public int EstoqueAtual { get; set; }

        [Required]
        [Range(0, 2000)]
        public int EstoqueMinimo { get; set; }

        public bool? PrecisaReposicao { get; set; }

        [Required]
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
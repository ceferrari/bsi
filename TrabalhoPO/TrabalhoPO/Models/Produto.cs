using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrabalhoPO.Models.Interfaces;

namespace TrabalhoPO.Models
{
    [Table("Produtos")]
    public class Produto : IIdentificavel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(128, ErrorMessage = "A Descrição deve ter no máximo {1} caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório.")]
        [Range(typeof(decimal), "0,01", "500,00", ErrorMessage = "O valor do Preço deve estar entre R$ {1} e R$ {2}.")]
        [Display(Name = "Preço")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N4}")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo Estoque Atual é obrigatório.")]
        [Range(0, 5000, ErrorMessage = "O valor do Estoque Atual deve estar entre 0 e 5.000.")]
        [Display(Name = "Estoque Atual")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N0}")]
        public int EstoqueAtual { get; set; }

        [Required(ErrorMessage = "O campo Estoque Mínimo é obrigatório.")]
        [Range(0, 2000, ErrorMessage = "O valor do Estoque Mínimo deve estar entre 0 e 2.000.")]
        [Display(Name = "Estoque Mínimo")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N0}")]
        public int EstoqueMinimo { get; set; }

        [Display(Name = "Precisa Reposição")]
        public bool? PrecisaReposicao { get; set; }

        [Required(ErrorMessage = "O campo Categoria é obrigatório.")]
        public int Categoria { get; set; }

        [Display(Name = "Data Alteração")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime? DataAlteracao { get; set; }

        public bool SetDescricao(string descricao)
        {
            if (String.IsNullOrWhiteSpace(descricao))
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
                throw new Exception("O Preço não pode ser negativo.");
            }

            Preco = preco;
            SetDataAlteracao();

            return true;
        }

        public bool SetEstoqueAtual(int qtd)
        {
            if (qtd < 0)
            {
                //throw new Exception("O Estoque Atual não pode ser negativo.");
            }

            EstoqueAtual = qtd;
            AtualizaCampos();

            return true;
        }

        public bool SetEstoqueMinimo(int qtd)
        {
            if (qtd < 0)
            {
                throw new Exception("O Estoque Mínimo não pode ser negativo.");
            }

            EstoqueMinimo = qtd;
            AtualizaCampos();

            return true;
        }

        public bool AumentaAtual(int qtd)
        {
            SetEstoqueAtual(EstoqueAtual + qtd);

            return true;
        }

        public bool DiminuiAtual(int qtd)
        {
            if (qtd > EstoqueAtual)
            {
                //throw new Exception("Estoque insuficiente para a operação solicitada.");
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
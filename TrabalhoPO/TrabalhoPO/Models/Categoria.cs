using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrabalhoPO.Models.Interfaces;

namespace TrabalhoPO.Models
{
    [Table("Categorias")]
    public class Categoria : IIdentificavel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(128, ErrorMessage = "A Descrição deve ter no máximo {1} caracteres.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Data Alteração")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime? DataAlteracao { get; set; }

        public void SetDescricao(string descricao)
        {
            if (String.IsNullOrWhiteSpace(descricao))
            {
                throw new Exception("O campo Descrição não pode ser vazio.");
            }

            Descricao = descricao;
            SetDataAlteracao();
        }

        public void SetDataAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}
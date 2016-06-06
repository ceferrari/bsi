using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPO.Models
{
    [Table("Categorias")]
    public class Categoria : IIdentificavel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Descricao { get; set; }

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

        public void SetDataAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}
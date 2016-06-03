using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPO.Models
{
    [Table("Categorias")]
    public class Categoria : IIdentificavel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public Categoria()
        {

        }

        public Categoria(int id, string descricao)
        {
            Id = id;
            SetDescricao(descricao);
        }

        public bool SetDescricao(string descricao)
        {
            if (descricao.Equals(""))
            {
                throw new Exception("O campo Descrição não pode ser vazio.");
            }

            Descricao = descricao;

            return true;
        }
    }
}

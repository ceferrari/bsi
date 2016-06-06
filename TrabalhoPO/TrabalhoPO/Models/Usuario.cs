using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPO.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Nome { get; set; }

        [Required]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(64)]
        [DataType(DataType.Password)]
        [Compare("ConfirmarSenha")]
        public string Senha { get; set; }

        [Required]
        [StringLength(64)]
        [DataType(DataType.Password)]
        [NotMapped]
        public string ConfirmarSenha { get; set; }
    }
}
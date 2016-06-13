using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrabalhoPO.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(128, ErrorMessage = "O Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [StringLength(128, ErrorMessage = "O E-mail deve ter no máximo {1} caracteres.")]
        [EmailAddress(ErrorMessage = "O valor informado não é um endereço de e-mail válido.")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [StringLength(64, ErrorMessage = "A Senha deve ter no máximo {1} caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo Confirmar Senha é obrigatório.")]
        [Compare("Senha", ErrorMessage = "As senhas não conferem.")]
        [Display(Name = "Confirmar Senha")]
        [DataType(DataType.Password)]
        //[NotMapped]
        public string ConfirmarSenha { get; set; }
    }
}
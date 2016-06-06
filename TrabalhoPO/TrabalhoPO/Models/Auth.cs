using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TrabalhoPO.Models
{
    public class Auth
    {
        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [StringLength(128, ErrorMessage = "O E-mail deve ter no máximo {1} caracteres.")]
        [EmailAddress(ErrorMessage = "O valor informado não é um endereço de e-mail válido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [StringLength(64, ErrorMessage = "A Senha deve ter no máximo {1} caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [HiddenInput]
        public string ReturnUrl { get; set; }
    }
}
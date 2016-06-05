using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace TrabalhoPO.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [NotMapped]
        private string _senha;

        [NotMapped]
        private string _confirmarSenha;

        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string Nome { get; set; }

        [Required]
        [StringLength(128)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(64)]
        [DataType(DataType.Password)]
        [Compare("ConfirmarSenha")]
        public string Senha
        {
            get { return _senha; }
            set { _senha = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", ""); }
        }

        [NotMapped]
        [StringLength(64)]
        [DataType(DataType.Password)]
        public string ConfirmarSenha
        {
            get { return _confirmarSenha; }
            set { _confirmarSenha = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", ""); }
        }
    }
}
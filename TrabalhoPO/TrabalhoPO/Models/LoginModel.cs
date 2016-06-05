using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;

namespace TrabalhoPO.Models
{
    public class LoginModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        private string _senha;
        public string Senha
        {
            get { return _senha; }
            set { _senha = BitConverter.ToString(SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(value))).Replace("-", ""); }
        }

        [HiddenInput]
        public string ReturnUrl { get; set; }
    }
}
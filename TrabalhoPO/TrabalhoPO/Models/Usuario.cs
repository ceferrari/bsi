using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace TrabalhoPO.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {

        }

        public Usuario(int id, string nome, string email, string senha = null)
        {
            Id = id;
            Nome = nome;
            SetEmail(email);
            Senha = senha;
        }

        private bool SetEmail(string email)
        {
            if (!IsValidEmail(email))
            {
                throw new Exception("E-mail inválido!");
            }

            Email = email;
            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static string sha256(string password)
        {
            SHA256Managed crypt = new SHA256Managed();
            StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte b in crypto)
            {
                hash.Append(b.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}

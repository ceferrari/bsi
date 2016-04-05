using System;
using System.Net.Mail;

namespace Domain
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }

        public Usuario(int codigo, string nome, string email, string senha = null)
        {
            Codigo = codigo;
            Nome = nome;
            SetEmail(email);
            Senha = senha;
        }

        private bool SetEmail(string email)
        {
            if (!IsValidEmail(email))
            {
                throw new Exception("E-mail imválido!");
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
    }
}

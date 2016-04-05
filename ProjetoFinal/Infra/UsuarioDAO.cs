using Domain;
using System;
using System.Data.SqlClient;

namespace Infra
{
    public class UsuarioDAO
    {
        public Usuario Recupera(string email, string senha)
        {
            var sql = "SELECT * FROM Usuarios WHERE Email = @email AND Senha = @senha";

            using (var dal = new ProjetoFinalDAL())
            using (var command = new SqlCommand(sql, dal.sqlConnection))
            {
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@senha", senha);

                using (var reader = command.ExecuteReader())
                {
                    reader.Read();
                    return Cria(reader);
                }
            }
        }

        public void Insere(Usuario usuario)
        {
            var sql = "INSERT INTO Usuarios (Nome, Email, Senha) VALUES (@nome, @email, @senha)";

            using (var dal = new ProjetoFinalDAL())
            using (var command = new SqlCommand(sql, dal.sqlConnection))
            {
                Parametriza(command, usuario);
                command.ExecuteNonQuery();
            }
        }

        private Usuario Cria(SqlDataReader reader)
        {
            var codigo = Convert.ToInt32(reader["Codigo"]);
            var nome = reader["Nome"].ToString();
            var email = reader["Email"].ToString();
            var senha = reader["Senha"].ToString();

            return new Usuario(codigo, nome, email, senha);
        }

        private void Parametriza(SqlCommand command, Usuario usuario)
        {
            command.Parameters.AddWithValue("@codigo", usuario.Codigo);
            command.Parameters.AddWithValue("@nome", usuario.Nome);
            command.Parameters.AddWithValue("@email", usuario.Email);
            command.Parameters.AddWithValue("@senha", usuario.Senha);
        }
    }
}

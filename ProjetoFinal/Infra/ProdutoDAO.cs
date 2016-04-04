using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Infra
{
    public class ProdutoDAO
    {
        public IList<Produto> Lista()
        {
            var sql = "SELECT * FROM Produtos";

            using (var dal = new ProjetoFinalDAL())
            using (var command = new SqlCommand(sql, dal.sqlConnection))
            using (var reader = command.ExecuteReader())
            {
                var Produtos = new BindingList<Produto>();

                while (reader.Read())
                {
                    Produtos.Add(Cria(reader));
                }

                return Produtos;
            }
        }

        public Produto Recupera(int id)
        {
            var sql = "SELECT * FROM Produtos WHERE codigo = " + id;

            using (var dal = new ProjetoFinalDAL())
            using (var command = new SqlCommand(sql, dal.sqlConnection))
            using (var reader = command.ExecuteReader())
            { 
                reader.Read();
                return Cria(reader);
            }
        }

        public void Insere(Produto produto)
        {
            var sql = "INSERT INTO Produtos (Descricao, Preco, EstoqueAtual, EstoqueMinimo, PrecisaReposicao, DataAlteracao) VALUES (@descricao, @preco, @atual, @minimo, @reposicao, @alteracao)";

            using (var dal = new ProjetoFinalDAL())
            using (var command = new SqlCommand(sql, dal.sqlConnection))
            {
                Parametriza(command, produto);
                command.ExecuteNonQuery();
            }
        }

        public void Atualiza(Produto produto)
        {
            var sql = "UPDATE Produtos SET Descricao = @descricao, Preco = @preco, EstoqueAtual = @atual, EstoqueMinimo = @minimo, PrecisaReposicao = @reposicao, DataAlteracao = @alteracao WHERE Codigo = @codigo";

            using (var dal = new ProjetoFinalDAL())
            using (var command = new SqlCommand(sql, dal.sqlConnection))
            {
                Parametriza(command, produto);
                command.ExecuteNonQuery();
            }
        }

        public void Remove(Produto produto)
        {
            var sql = "DELETE FROM Produtos WHERE Codigo = @codigo";

            using (var dal = new ProjetoFinalDAL())
            using (var command = new SqlCommand(sql, dal.sqlConnection))
            {
                Parametriza(command, produto);
                command.ExecuteNonQuery();
            }
        }

        private Produto Cria(SqlDataReader reader)
        {
            var codigo = Convert.ToInt32(reader["Codigo"]);
            var descricao = reader["Descricao"].ToString();
            var preco = Convert.ToDouble(reader["Preco"]);
            var atual = Convert.ToInt32(reader["EstoqueAtual"]);
            var minimo = Convert.ToInt32(reader["EstoqueMinimo"]);
            var reposicao = reader["PrecisaReposicao"].ToString() == "S";
            var alteracao = Convert.ToDateTime(reader["DataAlteracao"]);

            return new Produto(codigo, descricao, preco, atual, minimo, reposicao, alteracao);
        }

        private void Parametriza(SqlCommand command, Produto produto)
        {
            command.Parameters.AddWithValue("@codigo", produto.Codigo);
            command.Parameters.AddWithValue("@descricao", produto.Descricao);
            command.Parameters.AddWithValue("@preco", produto.Preco);
            command.Parameters.AddWithValue("@atual", produto.EstoqueAtual);
            command.Parameters.AddWithValue("@minimo", produto.EstoqueMinimo);
            command.Parameters.AddWithValue("@reposicao", (bool)produto.PrecisaReposicao ? "S" : "N");
            command.Parameters.AddWithValue("@alteracao", produto.DataAlteracao);
        }
    }
}

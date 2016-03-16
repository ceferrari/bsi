namespace Banco
{
    public class Pessoa
    {
        protected int Pessoa_Id { get; set; }
        protected string Nome { get; set; }

        public Pessoa(int id, string nome)
        {
            this.Pessoa_Id = id;
            this.Nome = nome;
        }
    }
}

namespace Banco
{
    public class Cliente : Pessoa
    {
        private int Cliente_Id { get; set; }

        public Cliente(int id, string nome) : base(id, nome)
        {
            this.Cliente_Id = base.Pessoa_Id;
        }

        public override string ToString()
        {
            return base.Nome;
        }
    }
}

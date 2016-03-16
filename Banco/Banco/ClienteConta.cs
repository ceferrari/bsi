namespace Banco
{
    public class ClienteConta
    {
        private Cliente Cliente { get; set; }
        private ContaCorrente ContaCorrente { get; set; }
        private ContaPoupanca ContaPoupanca { get; set; }

        public ClienteConta(Cliente cliente, ContaCorrente cc, ContaPoupanca cp)
        {
            this.Cliente = cliente;
            this.ContaCorrente = cc;
            this.ContaPoupanca = cp;
        }

        public Cliente GetCliente()
        {
            return this.Cliente;
        }

        public ContaCorrente GetContaCorrente()
        {
            return this.ContaCorrente;
        }

        public ContaPoupanca GetContaPoupanca()
        {
            return this.ContaPoupanca;
        }

        public override string ToString()
        {
            return this.Cliente.ToString();
        }
    }
}

using System;

namespace Banco
{
    public class ContaPoupanca : Conta
    {
        private double TaxaSaque { get; set; }
        private double LimiteSaque { get; set; }

        public ContaPoupanca(int numero, double saldo, Cliente titular) : base(numero, saldo, titular)
        {
            this.TaxaSaque = 0.10;
            this.LimiteSaque = 1000.0;
        }

        public override bool Sacar(double valor)
        {
            if (valor > 0.0)
            {
                if ((valor + TaxaSaque) > Saldo)
                {
                    throw new Exception("Saldo insuficiente para esta operação!");
                }

                if (valor > LimiteSaque)
                {
                    throw new Exception("Não é possível sacar um valor superior a " + String.Format("{0:C}", LimiteSaque));
                }

                Saldo -= (valor + TaxaSaque);
                return true;
            }

            return false;
        }

        public override bool Depositar(double valor)
        {
            if (valor > 0.0)
            {
                Saldo += valor;
                return true;
            }

            return false;
        }

        public override bool Transferir(double valor, Conta conta)
        {
            if (valor > 0.0)
            {
                if (valor > Saldo)
                {
                    throw new Exception("Saldo insuficiente para esta operação!");
                }

                Saldo -= valor;
                conta.Depositar(valor);
                return true;
            }

            return false;
        }
    }
}

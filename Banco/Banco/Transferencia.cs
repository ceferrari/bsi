using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Banco
{
    public partial class Transferencia : Form
    {
        private Principal Principal { get; set; }
        private ClienteConta ClienteConta { get; set; }

        public Transferencia(Principal principal, List<ClienteConta> clicontas, string valor)
        {
            InitializeComponent();
            this.Principal = principal;
            cboxTitular.DataSource = clicontas;
            cboxTitular.SelectedIndex = 1;
            mskValor.Text = valor;
        }

        private void Transferencia_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.Transferencia = null;
        }

        private void cboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteConta = (ClienteConta)cboxTitular.SelectedItem;
            AtualizaSaldo();
        }

        private void rbContaCorrente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContaCorrente.Checked)
            {
                lblSaldoContaCorrente.Font = new Font(lblSaldoContaCorrente.Font, FontStyle.Bold);
                lblValorSaldoContaCorrente.Font = new Font(lblValorSaldoContaCorrente.Font, FontStyle.Bold);
                lblSaldoContaPoupanca.Font = new Font(lblSaldoContaPoupanca.Font, FontStyle.Regular);
                lblValorSaldoContaPoupanca.Font = new Font(lblValorSaldoContaPoupanca.Font, FontStyle.Regular);
            }
        }

        private void rbContaPoupanca_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContaPoupanca.Checked)
            {
                lblSaldoContaCorrente.Font = new Font(lblSaldoContaCorrente.Font, FontStyle.Regular);
                lblValorSaldoContaCorrente.Font = new Font(lblValorSaldoContaCorrente.Font, FontStyle.Regular);
                lblSaldoContaPoupanca.Font = new Font(lblSaldoContaPoupanca.Font, FontStyle.Bold);
                lblValorSaldoContaPoupanca.Font = new Font(lblValorSaldoContaPoupanca.Font, FontStyle.Bold);
            }
        }

        private void btnEfetivarTransferencia_Click(object sender, EventArgs e)
        {
            try
            {
                double Valor = Convert.ToDouble(mskValor.Text.Substring(3));
                if (Principal.GetConta().Transferir(Valor, GetConta()))
                {
                    AtualizaSaldo();
                    Principal.ConcluiOperacao("Operação de transferência concluída com sucesso!", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Principal.ConcluiOperacao(ex.Message, MessageBoxIcon.Warning);
            }
        }

        private Conta GetConta()
        {
            if (rbContaCorrente.Checked)
            {
                return ClienteConta.GetContaCorrente();
            }
            else // rbContaPoupanca.Checked
            {
                return ClienteConta.GetContaPoupanca();
            }
        }

        private void AtualizaSaldo()
        {
            lblValorSaldoContaCorrente.Text = String.Format("{0:C}", ClienteConta.GetContaCorrente().GetSaldo());
            lblValorSaldoContaPoupanca.Text = String.Format("{0:C}", ClienteConta.GetContaPoupanca().GetSaldo());
        }
    }
}

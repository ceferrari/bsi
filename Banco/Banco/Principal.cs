using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Banco
{
    public partial class Principal : Form
    {
        public Transferencia Transferencia { get; set; }
        private List<ClienteConta> ClienteContas { get; set; }
        private ClienteConta ClienteConta { get; set; }
        private double Valor { get; set; }

        public Principal()
        {
            InitializeComponent();

            Cliente c1 = new Cliente(1, "Carlos Ferrari");
            Cliente c2 = new Cliente(2, "Diego Pereira");
            Cliente c3 = new Cliente(3, "José da Silva");
            Cliente c4 = new Cliente(4, "João de Souza");
            Cliente c5 = new Cliente(5, "Maria da Graça");

            ContaCorrente cc1 = new ContaCorrente(1, 1500.0, c1);
            ContaCorrente cc2 = new ContaCorrente(2, 1750.0, c2);
            ContaCorrente cc3 = new ContaCorrente(3, 2000.0, c3);
            ContaCorrente cc4 = new ContaCorrente(4, 2250.0, c4);
            ContaCorrente cc5 = new ContaCorrente(5, 2500.0, c5);

            ContaPoupanca cp1 = new ContaPoupanca(1, 2500.0, c1);
            ContaPoupanca cp2 = new ContaPoupanca(2, 2250.0, c2);
            ContaPoupanca cp3 = new ContaPoupanca(3, 2000.0, c3);
            ContaPoupanca cp4 = new ContaPoupanca(4, 1750.0, c4);
            ContaPoupanca cp5 = new ContaPoupanca(5, 1500.0, c5);

            ClienteConta cliconta1 = new ClienteConta(c1, cc1, cp1);
            ClienteConta cliconta2 = new ClienteConta(c2, cc2, cp2);
            ClienteConta cliconta3 = new ClienteConta(c3, cc3, cp3);
            ClienteConta cliconta4 = new ClienteConta(c4, cc4, cp4);
            ClienteConta cliconta5 = new ClienteConta(c5, cc5, cp5);

            ClienteContas = new List<ClienteConta>();
            ClienteContas.Add(cliconta1);
            ClienteContas.Add(cliconta2);
            ClienteContas.Add(cliconta3);
            ClienteContas.Add(cliconta4);
            ClienteContas.Add(cliconta5);

            cboxTitular.DataSource = ClienteContas;
            cboxTitular.SelectedIndex = 0;

            this.ActiveControl = mskValor;
        }

        private void cboxTitular_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteConta = (ClienteConta)cboxTitular.SelectedItem;
            AtualizaSaldo();
        }

        private void mskValor_Click(object sender, EventArgs e)
        {
            mskValor.SelectionStart = mskValor.Mask.Length + 1;
        }

        private void mskValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && char.IsDigit(e.KeyChar))
            {
                string str = mskValor.Text + e.KeyChar;
                mskValor.Text = str.Substring(1, str.Length - 1);
                mskValor.SelectionStart = mskValor.Mask.Length + 1;
            }
        }

        private void mskValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                mskValor.Text = "0" + mskValor.Text;
                mskValor.SelectionStart = mskValor.Mask.Length + 1;
            }

            mskValor.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            Valor = Convert.ToDouble(mskValor.Text.Substring(3));
            mskValor.TextMaskFormat = MaskFormat.IncludePrompt;
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

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try {
                if (GetConta().Depositar(Valor))
                {
                    ConcluiOperacao("Operação de depósito concluída com sucesso!", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ConcluiOperacao(ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            try {
                if (GetConta().Sacar(Valor))
                {
                    ConcluiOperacao("Operação de saque concluída com sucesso!", MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ConcluiOperacao(ex.Message, MessageBoxIcon.Warning);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try {
                if (Valor > 0.0)
                {
                    if (Transferencia == null)
                    {
                        Transferencia = new Transferencia(this, ClienteContas, Valor.ToString("000000.00"));
                        Transferencia.Show();
                        this.Enabled = false;
                    }
                    else
                    {
                        Transferencia.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                ConcluiOperacao(ex.Message, MessageBoxIcon.Warning);
            }
        }

        public Conta GetConta()
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

        public void ConcluiOperacao(string mensagem, MessageBoxIcon mbi)
        {
            AtualizaSaldo();
            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, mbi);
            if (Transferencia != null)
            {
                Transferencia.Dispose();
                Transferencia = null;
                this.Enabled = true;
            }
            Valor = 0;
            mskValor.Text = "00000000";
            mskValor.Focus();
        }
    }
}

using Domain;
using Infra;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class NovoUsuario : Form
    {
        private Login Login { get; set; }

        public NovoUsuario(Login login)
        {
            InitializeComponent();
            Login = login;
        }

        private void NovoUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login.NovoUsuario = null;
            Login.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrWhiteSpace(txtNome.Text))
                {
                    throw new Exception("O campo 'Nome' não pode ser vazio!");
                }

                if (String.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    throw new Exception("O campo 'E-mail' não pode ser vazio!");
                }

                if (String.IsNullOrWhiteSpace(txtSenha.Text))
                {
                    throw new Exception("O campo 'Senha' não pode ser vazio!");
                }

                new UsuarioDAO().Insere(new Usuario(0, txtNome.Text, txtEmail.Text, Util.sha256(txtSenha.Text)));
                MessageBox.Show("Usuário " + txtNome.Text + " cadastrado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login.Show();
                Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

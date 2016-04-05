using Domain;
using Infra;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class Login : Form
    {
        public NovoUsuario NovoUsuario { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (NovoUsuario == null)
            {
                NovoUsuario = new NovoUsuario(this);
                NovoUsuario.Show();
                Hide();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new UsuarioDAO().Recupera(txtEmail.Text, Util.sha256(txtSenha.Text));
                new Principal(usuario).Show();
                Dispose();
            }
            catch
            {
                var message = "Usuário não encontrado ou combinação email/senha incorreta.";
                MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

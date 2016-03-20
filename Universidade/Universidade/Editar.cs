using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universidade
{
    public partial class Editar : Form
    {
        Nomeavel Objeto;

        public Editar(Nomeavel objeto)
        {
            InitializeComponent();

            Objeto = objeto;
            lblTitulo.Text = objeto.GetType().Name + ":";
            txtNome.Text = objeto.Nome;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.Enabled = true;
            }
            else
            {
                txtNome.Enabled = !txtNome.Enabled;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrWhiteSpace(txtNome.Text))
                {
                    throw new Exception("O nome não pode ser em branco.");
                }

                Objeto.Nome = txtNome.Text;
                txtNome.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Estoque
{
    public partial class InputBox : Form
    {
        public int Valor { get; private set; }

        public InputBox()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Valor = txtValor.Text.Equals("") ? 0 : Convert.ToInt32(txtValor.Text);
        }
    }
}

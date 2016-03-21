using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Universidade
{
    public partial class Editar : Form
    {
        private Principal Principal { get; set; }
        private INomeavel Objeto { get; set; }

        public Editar(INomeavel objeto, Principal principal)
        {
            InitializeComponent();

            Principal = principal;
            Objeto = objeto;

            PopulaDataGrids();
            AtualizaLabels();
        }

        private void Editar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.Editar = null;
        }

        private void PopulaDataGrids()
        {
            if (Objeto.GetType().Name.Equals("Universidade"))
            {
                dgvVinculados.DataSource = Listas.Departamentos.Where(x => x.Codigo != 0 && Listas.UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == Objeto.Codigo)).ToList();
                dgvNaoVinculados.DataSource = Listas.Departamentos.Where(x => x.Codigo != 0 && !Listas.UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == Objeto.Codigo)).ToList();
            }
            else if (Objeto.GetType().Name.Equals("Departamento"))
            {
                dgvVinculados.DataSource = Listas.Universidades.Where(x => x.Codigo != 0 && Listas.UniDepList.Any(y => y.Chaves.Item1 == x.Codigo && y.Chaves.Item2 == Objeto.Codigo)).ToList();
                dgvNaoVinculados.DataSource = Listas.Universidades.Where(x => x.Codigo != 0 && !Listas.UniDepList.Any(y => y.Chaves.Item1 == x.Codigo && y.Chaves.Item2 == Objeto.Codigo)).ToList();
            }
            else // if (Objeto.GetType().Name.Equals("Professor"))
            {

            }

            try {
                dgvVinculados.Columns["Codigo"].Visible = false;
                dgvNaoVinculados.Columns["Codigo"].Visible = false;
            } catch (Exception ex) { Console.WriteLine(ex.Message); }

            AtualizaNumeros();
        }

        private void AtualizaLabels()
        {
            lblTitulo.Text = Objeto.GetType().Name + ":";
            txtNome.Text = Objeto.Nome;

            if (Objeto.GetType().Name.Equals("Universidade"))
            {
                lblVinculados.Text = "Departamentos vinculados:";
                lblNaoVinculados.Text = "Departamentos não vinculados:";
            }
            else if (Objeto.GetType().Name.Equals("Departamento"))
            {
                lblVinculados.Text = "Universidades vinculadas:";
                lblNaoVinculados.Text = "Universidades não vinculadas:";
            }
            else // if (Objeto.GetType().Name.Equals("Professor"))
            {
                lblVinculados.Text = "Universidades > Departamentos vinculados:";
                lblNaoVinculados.Text = "Universidades > Departamentos não vinculados:";
            }
        }

        private void AtualizaNumeros()
        {
            string total = Convert.ToString(dgvVinculados.RowCount + dgvNaoVinculados.RowCount);
            lblQtdVinculadosValor.Text = dgvVinculados.RowCount.ToString() + " / " + total;
            lblQtdNaoVinculadosValor.Text = dgvNaoVinculados.RowCount.ToString() + " / " + total;
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

            txtNome.Focus();
            txtNome.SelectionStart = txtNome.Text.Length + 1;
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
                MessageBox.Show("Nome alterado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            if (dgvNaoVinculados.RowCount > 0)
            {
                Listas.UniDepList.Add(new UniDep(GetChaves(sender)));
                PopulaDataGrids();
            }
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (dgvVinculados.RowCount > 0)
            {
                Listas.UniDepList.RemoveWhere(x => x.Chaves.Equals(GetChaves(sender)));
                PopulaDataGrids();
            }
        }

        private Tuple<int, int> GetChaves(object sender)
        {
            DataGridView dgv = (sender as Button).Text.Equals("<<") ? dgvNaoVinculados : dgvVinculados;
            int item1 = Objeto.Codigo;
            int item2 = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);

            if (Objeto.GetType().Name.Equals("Universidade"))
            {
                return new Tuple<int, int>(item1, item2);
            }
            else if (Objeto.GetType().Name.Equals("Departamento"))
            {
                return new Tuple<int, int>(item2, item1);
            }
            else // if (Objeto.GetType().Name.Equals("Professor"))
            {
                return new Tuple<int, int>(item1, item2);
            }
        }
    }
}

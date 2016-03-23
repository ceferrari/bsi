using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Universidade
{
    public partial class Editar : Form
    {
        private Principal Principal { get; set; }
        private INomeavel Nomeavel { get; set; }

        public Editar(INomeavel nomeavel, Principal principal)
        {
            InitializeComponent();
            Principal = principal;
            Nomeavel = nomeavel;
            if (Nomeavel is Professor)
            {
                CriaColuna("Universidade", 35);
                CriaColuna("Departamento", 65);
                dgvVinculados.DefaultCellStyle.Font = new Font("Consolas", 10F);
                dgvNaoVinculados.DefaultCellStyle.Font = new Font("Consolas", 10F);
            }
            PopulaDataGrids();
            AtualizaLabels();
        }

        private void Editar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.Editar = null;
            AtualizaTelaPrincipal(Principal.dgvUniversidades);
            AtualizaTelaPrincipal(Principal.dgvDepartamentos);
            AtualizaTelaPrincipal(Principal.dgvProfessores);
        }

        private void AtualizaTelaPrincipal(DataGridView dgv)
        {
            int index = dgv.CurrentRow.Index;
            dgv.Rows[0].Selected = true;
            dgv.Rows[index].Selected = true;
        }

        private void CriaColuna(string nome, int fillWeight)
        {
            dgvVinculados.Columns.Add(new DataGridViewTextBoxColumn() { Name = nome, FillWeight = fillWeight });
            dgvNaoVinculados.Columns.Add(new DataGridViewTextBoxColumn() { Name = nome, FillWeight = fillWeight });
        }

        private void EscondeColuna(string nome)
        {
            dgvVinculados.Columns[nome].Visible = false;
            dgvNaoVinculados.Columns[nome].Visible = false;
        }

        private void PopulaDataGrids()
        {
            if (Nomeavel is Universidade)
            {
                dgvVinculados.DataSource = Listas.Departamentos.Where(x => x.Codigo > 0 && Listas.UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == Nomeavel.Codigo)).ToList();
                dgvNaoVinculados.DataSource = Listas.Departamentos.Where(x => x.Codigo > 0 && !Listas.UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == Nomeavel.Codigo)).ToList();
                EscondeColuna("Codigo");
            }
            else if (Nomeavel is Departamento)
            {
                dgvVinculados.DataSource = Listas.Universidades.Where(x => x.Codigo > 0 && Listas.UniDepList.Any(y => y.Chaves.Item1 == x.Codigo && y.Chaves.Item2 == Nomeavel.Codigo)).ToList();
                dgvNaoVinculados.DataSource = Listas.Universidades.Where(x => x.Codigo > 0 && !Listas.UniDepList.Any(y => y.Chaves.Item1 == x.Codigo && y.Chaves.Item2 == Nomeavel.Codigo)).ToList();
                EscondeColuna("Codigo");
            }
            else // (Nomeavel is Professor)
            {
                dgvVinculados.DataSource = Listas.UniDepProList.Where(x => x.Chaves.Item2 == Nomeavel.Codigo).Select(x => x.Chaves.Item1).ToList();
                dgvNaoVinculados.DataSource = Listas.UniDepList.Where(x => x.Chaves.Item1 > 0 && Listas.UniDepProList.Any(y => y.Chaves.Item2 != Nomeavel.Codigo)).ToList();
                EscondeColuna("Chaves");
            }

            AtualizaNumeros();
        }

        private void AtualizaLabels()
        {
            lblTitulo.Text = Nomeavel.GetType().Name + ":";
            txtNome.Text = Nomeavel.Nome;

            if (Nomeavel is Universidade)
            {
                lblVinculados.Text = "Departamentos vinculados:";
                lblNaoVinculados.Text = "Departamentos não vinculados:";
            }
            else if (Nomeavel is Departamento)
            {
                lblVinculados.Text = "Universidades vinculadas:";
                lblNaoVinculados.Text = "Universidades não vinculadas:";
            }
            else // (Nomeavel is Professor)
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
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
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

                if (txtNome.Enabled)
                {
                    Nomeavel.Nome = txtNome.Text;
                    txtNome.Enabled = false;
                    MessageBox.Show("Nome alterado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                if (Nomeavel is Professor)
                {
                    Listas.UniDepProList.Add(new UniDepPro(GetChaves(sender) as Tuple<UniDep, int>));
                }
                else
                {
                    Listas.UniDepList.Add(new UniDep(GetChaves(sender) as Tuple<int, int>));
                }

                PopulaDataGrids();
            }
        }

        private void btnDesvincular_Click(object sender, EventArgs e)
        {
            if (dgvVinculados.RowCount > 0)
            {
                if (Nomeavel is Professor)
                {
                    Tuple<UniDep, int> chaves = GetChaves(sender) as Tuple<UniDep, int>;
                    Listas.UniDepProList.RemoveWhere(x => x.Chaves.Item2 == Nomeavel.Codigo && Listas.UniDepList.Any(y => y.Chaves.Item1.Equals(chaves)));
                }
                else
                {
                    Tuple<int, int> chaves = GetChaves(sender) as Tuple<int, int>;
                    /* Remove todos os professores de todos os departamentos da respectiva universidade e depois remove os departamentos */
                    Listas.UniDepProList.RemoveWhere(x => Listas.UniDepList.Any(y => y.Chaves.Item1.Equals(chaves)));
                    Listas.UniDepList.RemoveWhere(x => x.Chaves.Equals(chaves));
                }
                
                PopulaDataGrids();
            }
        }

        private IComparable GetChaves(object sender)
        {
            DataGridView dgv = (sender as Button).Text.Equals(">>") ? dgvVinculados : dgvNaoVinculados;

            if (Nomeavel is Professor)
            {
                return new Tuple<UniDep, int>(dgv.CurrentRow.DataBoundItem as UniDep, Nomeavel.Codigo);
            }
            
            int aux = Convert.ToInt32(dgv.CurrentRow.Cells["Codigo"].Value);
            return (Nomeavel is Universidade) ? new Tuple<int, int>(Nomeavel.Codigo, aux) : new Tuple<int, int>(aux, Nomeavel.Codigo);
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Nomeavel is Professor)
            {
                foreach (var row in (sender as DataGridView).Rows.Cast<DataGridViewRow>())
                {
                    var item = row.DataBoundItem as UniDep;
                    row.Cells["Universidade"].Value = Listas.Universidades.FirstOrDefault(x => x.Codigo == item.Chaves.Item1).Nome;
                    row.Cells["Departamento"].Value = Listas.Departamentos.FirstOrDefault(x => x.Codigo == item.Chaves.Item2).Nome;
                }
            }
        }
    }
}

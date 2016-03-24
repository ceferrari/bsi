using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Universidade.Listas;

namespace Universidade
{
    public partial class Principal : Form
    {
        public Editar Editar { get; set; }
        private Universidade SelUniversidade { get; set; }
        private Departamento SelDepartamento { get; set; }
        private Professor SelProfessor { get; set; }

        public Principal()
        {
            InitializeComponent();
            PopulaDataGrids();
        }

        private void PopulaDataGrids()
        {
            AjustaColunas(dgvUniversidades, Universidades, "CodUni", "Universidade");
            AjustaColunas(dgvDepartamentos, Departamentos, "CodDep", "Departamento");
            AjustaColunas(dgvProfessores, Professores, "CodPro", "Professor");
        }

        private void AjustaColunas(DataGridView dgv, BindingList<INomeavel> source, string codigo, string nome)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = source;
            dgv.Columns[codigo].DataPropertyName = "Codigo";
            dgv.Columns[nome].DataPropertyName = "Nome";
        }

        private void EstilizaPrimeiraLinha(DataGridView dgv)
        {
            dgv.Rows[0].Cells[1].Style.Font = new Font("Consolas", 12F, FontStyle.Bold);
            dgv.Rows[0].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void AtualizaNumeros()
        {
            lblQtdUniversidadesValor.Text = (dgvUniversidades.RowCount - 1) + " / " + (Universidades.Count - 1);
            lblQtdDepartamentosValor.Text = (dgvDepartamentos.RowCount - 1) + " / " + (Departamentos.Count - 1);
            lblQtdProfessoresValor.Text = (dgvProfessores.RowCount - 1) + " / " + (Professores.Count - 1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
            {
                string nome = txtNome.Text;

                if (rbUniversidade.Checked)
                {
                    Universidades.Add(new Universidade(nome));
                }
                else if (rbDepartamento.Checked)
                {
                    Departamentos.Add(new Departamento(nome));
                }
                else // (rbProfessor.Checked)
                {
                    Professores.Add(new Professor(nome));
                }

                var tipo = tlpNovo.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked).Text;
                MessageBox.Show(tipo + " \"" + nome + "\" cadastrado(a) com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Editar == null)
            {
                Editar = new Editar((sender as DataGridView).CurrentRow.DataBoundItem as INomeavel, this);
                Editar.Show();
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            EstilizaPrimeiraLinha(sender as DataGridView);
            AtualizaNumeros();
        }

        private void dgvUniversidades_SelectionChanged(object sender, EventArgs e)
        {
            SelUniversidade = dgvUniversidades.CurrentRow.DataBoundItem as Universidade;
            dgvDepartamentos.DataSource = GetDataSource(dgvUniversidades, dgvDepartamentos, Departamentos);
        }

        private void dgvDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            SelDepartamento = dgvDepartamentos.CurrentRow.DataBoundItem as Departamento;
            dgvProfessores.DataSource = GetDataSource(dgvDepartamentos, dgvProfessores, Professores);
        }

        private void dgvProfessores_SelectionChanged(object sender, EventArgs e)
        {
            SelProfessor = dgvProfessores.CurrentRow.DataBoundItem as Professor;
            dgvUniversidades.DataSource = GetDataSource(dgvProfessores, dgvUniversidades, Universidades);
        }

        private BindingList<INomeavel> GetDataSource(DataGridView sender, DataGridView filtered, BindingList<INomeavel> source)
        {
            IEnumerable<INomeavel> filter = null;

            if (sender == dgvUniversidades && sender.CurrentRow.Index > 0)
            {
                filter = source.Where(x => x.Codigo == 0 || UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == SelUniversidade.Codigo));
            }

            if (sender == dgvDepartamentos)
            {
                if (sender.CurrentRow.Index == 0 && dgvUniversidades.CurrentRow.Index > 0)
                {
                    filter = source.Where(x => x.Codigo == 0 || UniDepProList.Any(z => z.Chaves.Item2 == x.Codigo && z.Chaves.Item1.Chaves.Item1 == SelUniversidade.Codigo));
                }
                if (sender.CurrentRow.Index > 0 && dgvUniversidades.CurrentRow.Index == 0)
                {
                    filter = source.Where(x => x.Codigo == 0 || UniDepProList.Any(z => z.Chaves.Item2 == x.Codigo && z.Chaves.Item1.Chaves.Item2 == SelDepartamento.Codigo));
                }
                if (sender.CurrentRow.Index > 0 && dgvUniversidades.CurrentRow.Index > 0)
                {
                    var unidep = UniDepList.LastOrDefault(x => x.Chaves.Item1 == SelUniversidade.Codigo && x.Chaves.Item2 == SelDepartamento.Codigo);
                    filter = source.Where(x => x.Codigo == 0 || UniDepProList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1.Equals(unidep)));
                }
            }

            if (sender == dgvProfessores && SelProfessor != null)
            {
                var rows = filtered.Rows.Cast<DataGridViewRow>();
                foreach (var row in rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;

                    var item = row.DataBoundItem as INomeavel;
                    if (item.Codigo > 0 && rows.Any(x => UniDepProList.Any(y => y.Chaves.Item2 == SelProfessor.Codigo && y.Chaves.Item1.Chaves.Item1 == item.Codigo)))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;
                    }
                }

                var qtdAtual = (sender.CurrentRow.Index == 0) ? Universidades.Count - 1 : rows.Count(x => x.DefaultCellStyle.BackColor == Color.Pink);
                lblQtdUniversidadesValor.Text =  qtdAtual + " / " + (Universidades.Count - 1);
            }

            return (filter == null) ? source : new BindingList<INomeavel>(filter.ToList<INomeavel>());
        }
    }
}

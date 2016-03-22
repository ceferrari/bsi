using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Universidade
{
    public partial class Principal : Form
    {
        public Editar Editar { get; set; }
        private Universidade SelUniversidade { get; set; }
        private Departamento SelDepartamento { get; set; }
        private Professor SelProfessor { get; set; }
        private int UniCount { get; set; }

        public Principal()
        {
            InitializeComponent();
            PopulaDataGrids();
        }

        private void PopulaDataGrids()
        {
            AjustaColunas(dgvUniversidades, "CodUni", "Universidade");
            AjustaColunas(dgvDepartamentos, "CodDep", "Departamento");
            AjustaColunas(dgvProfessores, "CodPro", "Professor");
        }

        private void AjustaColunas(DataGridView dgv, string codigo, string nome)
        {
            dgv.AutoGenerateColumns = false;
            dgv.DataSource = Listas.Universidades;
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
            lblQtdUniversidadesValor.Text = Convert.ToString(dgvUniversidades.RowCount - 1 - UniCount) + " / " + Convert.ToString(Listas.Universidades.Count - 1);
            lblQtdDepartamentosValor.Text = Convert.ToString(dgvDepartamentos.RowCount - 1) + " / " + Convert.ToString(Listas.Departamentos.Count - 1);
            lblQtdProfessoresValor.Text = Convert.ToString(dgvProfessores.RowCount - 1) + " / " + Convert.ToString(Listas.Professores.Count - 1);
        }

        public UniDep GetUniDep()
        {
            return Listas.UniDepList.LastOrDefault(x => x.Chaves.Item1 == SelUniversidade.Codigo && x.Chaves.Item2 == SelDepartamento.Codigo);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNome.Text))
            {
                string nome = txtNome.Text;

                if (rbUniversidade.Checked)
                {
                    Listas.Universidades.Add(new Universidade(nome));
                }
                else if (rbDepartamento.Checked)
                {
                    Listas.Departamentos.Add(new Departamento(nome));
                }
                else if (rbProfessor.Checked)
                {
                    Listas.Professores.Add(new Professor(nome));
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
            try
            {
                SelUniversidade = dgvUniversidades.CurrentRow.DataBoundItem as Universidade;
                List<Departamento> filtro = null;

                if (dgvUniversidades.CurrentRow.Index > 0)
                {
                    filtro = Listas.Departamentos.Where(x => x.Codigo == 0 ||
                        Listas.UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == SelUniversidade.Codigo)).ToList();
                }

                dgvDepartamentos.DataSource = (filtro == null) ? Listas.Departamentos : new BindingList<Departamento>(filtro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SelDepartamento = dgvDepartamentos.CurrentRow.DataBoundItem as Departamento;
                List<Professor> filtro = null;

                if (dgvUniversidades.CurrentRow.Index == 0 && dgvDepartamentos.CurrentRow.Index > 0)
                {
                    filtro = Listas.Professores.Where(x => x.Codigo == 0 ||
                        Listas.UniDepList.Any(y => y.Chaves.Item2 == SelDepartamento.Codigo &&
                            Listas.UniDepProList.Any(z => z.Chaves.Item2 == x.Codigo && z.Chaves.Item1.Equals(y)))).ToList();
                }

                if (dgvUniversidades.CurrentRow.Index > 0 && dgvDepartamentos.CurrentRow.Index == 0)
                {
                    filtro = Listas.Professores.Where(x => x.Codigo == 0 ||
                        Listas.UniDepList.Any(y => y.Chaves.Item1 == SelUniversidade.Codigo && 
                            Listas.UniDepProList.Any(z => z.Chaves.Item2 == x.Codigo && z.Chaves.Item1.Equals(y)))).ToList();
                }

                if (dgvUniversidades.CurrentRow.Index > 0 && dgvDepartamentos.CurrentRow.Index > 0)
                {
                    filtro = Listas.Professores.Where(x => x.Codigo == 0 ||
                        Listas.UniDepProList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1.Equals(GetUniDep()))).ToList();
                }

                dgvProfessores.DataSource = (filtro == null) ? Listas.Professores : new BindingList<Professor>(filtro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dgvProfessores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SelProfessor = dgvProfessores.CurrentRow.DataBoundItem as Professor;
                UniCount = 0;

                foreach (var row in dgvUniversidades.Rows.Cast<DataGridViewRow>())
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }

                if (dgvProfessores.CurrentRow.Index > 0)
                {
                    foreach (var row in dgvUniversidades.Rows.Cast<DataGridViewRow>()
                        .Where(x => (x.DataBoundItem as Universidade).Codigo > 0 &&
                            Listas.UniDepProList.Any(y => y.Chaves.Item2 == SelProfessor.Codigo && 
                                y.Chaves.Item1.Chaves.Item1 == (x.DataBoundItem as Universidade).Codigo)))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;
                        UniCount++;
                    }

                    UniCount = dgvUniversidades.RowCount - 1 - UniCount;
                }

                AtualizaNumeros();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

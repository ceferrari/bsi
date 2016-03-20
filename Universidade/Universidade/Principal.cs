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
        private BindingList<Universidade> Universidades { get; set; }
        private BindingList<Departamento> Departamentos { get; set; }
        private BindingList<Professor> Professores { get; set; }
        private List<UniDep> UniDep { get; set; }
        private List<UniDepPro> UniDepPro { get; set; }
        private Universidade SelUniversidade { get; set; }
        private Departamento SelDepartamento { get; set; }
        private Professor SelProfessor { get; set; }
        private Random Rnd = new Random();
        private int UniCount { get; set;  }

        public Principal()
        {
            InitializeComponent();

            InicializaListas();
            PopulaDataGrids();
        }

        private void InicializaListas()
        {
            Universidades = new BindingList<Universidade>();
            Universidades.Add(new Universidade("** TODOS **"));
            Universidades.Add(new Universidade("UNIVEM"));
            Universidades.Add(new Universidade("UNIMAR"));
            Universidades.Add(new Universidade("UNESP"));
            Universidades.Add(new Universidade("UNICAMP"));
            Universidades.Add(new Universidade("USP"));
            Universidades.Add(new Universidade("PUC"));
            Universidades.Add(new Universidade("MACKENZIE"));
            Universidades.Add(new Universidade("ITA"));
            Universidades.Add(new Universidade("UFMG"));
            Universidades.Add(new Universidade("UFRJ"));
            Universidades.Add(new Universidade("UFSCAR"));
            Universidades.Add(new Universidade("UNIFEI"));

            Departamentos = new BindingList<Departamento>();
            Departamentos.Add(new Departamento("** TODOS **"));
            Departamentos.Add(new Departamento("Administração"));
            Departamentos.Add(new Departamento("Ciência da Computação"));
            Departamentos.Add(new Departamento("Ciências Contábeis"));
            Departamentos.Add(new Departamento("Design de Interiores"));
            Departamentos.Add(new Departamento("Design Gráfico"));
            Departamentos.Add(new Departamento("Direito"));
            Departamentos.Add(new Departamento("Engenharia de Produção"));
            Departamentos.Add(new Departamento("Gestão de Recursos Humanos"));
            Departamentos.Add(new Departamento("Processos Gerenciais"));
            Departamentos.Add(new Departamento("Sistemas de Informação"));

            Professores = new BindingList<Professor>();
            Professores.Add(new Professor("** TODOS **"));
            Professores.Add(new Professor("Carlos"));
            Professores.Add(new Professor("Diego"));
            Professores.Add(new Professor("Laura"));
            Professores.Add(new Professor("Pedro"));
            Professores.Add(new Professor("Bernardo"));
            Professores.Add(new Professor("Manuela"));
            Professores.Add(new Professor("Gabriel"));
            Professores.Add(new Professor("Lucas"));
            Professores.Add(new Professor("Helena"));
            Professores.Add(new Professor("Matheus"));
            Professores.Add(new Professor("Rafael"));
            //Professores.Add(new Professor("Beatriz"));
            //Professores.Add(new Professor("Guilherme"));
            //Professores.Add(new Professor("Mariana"));
            //Professores.Add(new Professor("Felipe"));
            //Professores.Add(new Professor("Gustavo"));
            //Professores.Add(new Professor("Henrique"));
            //Professores.Add(new Professor("Rafaela"));
            //Professores.Add(new Professor("Daniel"));
            //Professores.Add(new Professor("Murilo"));
            //Professores.Add(new Professor("Vitor"));

            UniDep = new List<UniDep>();
            UniDep.Add(new UniDep(0, 0));

            UniDepPro = new List<UniDepPro>();
            UniDepPro.Add(new UniDepPro(0, 0));

            Aleatorios();
        }

        /* Atribui Departamentos e Professores aleatoriamente */
        private void Aleatorios()
        {
            for (int i = 1; i < Universidades.Count; i++)
            {
                for (int j = 0; j < Rnd.Next(1, Departamentos.Count); j++)
                {
                    UniDep.Add(new UniDep(Universidades[i].Codigo, Rnd.Next(1, Departamentos.Count)));
                }
            }

            for (int i = 1; i < UniDep.Count; i++)
            {
                for (int j = 0; j < Rnd.Next(1, Professores.Count); j++)
                {
                    UniDepPro.Add(new UniDepPro(UniDep[i].Codigo, Rnd.Next(1, Professores.Count)));
                }
            }

            /* Debug */
            //for (int i = 0; i < UniDep.Count; i++)
            //{
            //    Console.WriteLine(UniDep[i].Codigo + " " + UniDep[i].CodigoUniversidade + " " + UniDep[i].CodigoDepartamento);
            //}

            //for (int i = 0; i < UniDepPro.Count; i++)
            //{
            //    Console.WriteLine(UniDepPro[i].Codigo + " " + UniDepPro[i].CodigoUniDep + " " + UniDepPro[i].CodigoProfessor);
            //}
        }

        private void PopulaDataGrids()
        {
            dgvUniversidades.AutoGenerateColumns = false;
            dgvUniversidades.DataSource = Universidades;
            dgvUniversidades.Columns["CodUni"].DataPropertyName = "Codigo";
            dgvUniversidades.Columns["Universidade"].DataPropertyName = "Nome";

            dgvDepartamentos.AutoGenerateColumns = false;
            dgvDepartamentos.DataSource = Departamentos;
            dgvDepartamentos.Columns["CodDep"].DataPropertyName = "Codigo";
            dgvDepartamentos.Columns["Departamento"].DataPropertyName = "Nome";

            dgvProfessores.AutoGenerateColumns = false;
            dgvProfessores.DataSource = Professores;
            dgvProfessores.Columns["CodPro"].DataPropertyName = "Codigo";
            dgvProfessores.Columns["Professor"].DataPropertyName = "Nome";
        }

        private void AtualizaNumeros()
        {
            lblQtdUniversidadesValor.Text = Convert.ToString(UniCount) + " / " + Convert.ToString(Universidades.Count - 1);
            lblQtdDepartamentosValor.Text = Convert.ToString(dgvDepartamentos.RowCount - 1) + " / " + Convert.ToString(Departamentos.Count - 1);
            lblQtdProfessoresValor.Text = Convert.ToString(dgvProfessores.RowCount - 1) + " / " + Convert.ToString(Professores.Count - 1);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals(""))
            {
                if (rbUniversidade.Checked)
                {
                    Universidades.Add(new Universidade(txtNome.Text));
                }
                else if (rbDepartamento.Checked)
                {
                    Departamentos.Add(new Departamento(txtNome.Text));
                }
                else // if (rbProfessor.Checked)
                {
                    Professores.Add(new Professor(txtNome.Text));
                }

                txtNome.Clear();
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
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
                    filtro = Departamentos.Where(x => x.Codigo == 0 ||
                        UniDep.Any(y => y.CodigoDepartamento == x.Codigo && y.CodigoUniversidade == SelUniversidade.Codigo)).ToList();
                }

                dgvDepartamentos.DataSource = (filtro == null) ? Departamentos : new BindingList<Departamento>(filtro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                AtualizaNumeros();
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
                    filtro = Professores.Where(x => x.Codigo == 0 ||
                        UniDepPro.Any(y => y.CodigoProfessor == x.Codigo &&
                            UniDep.Any(z => z.Codigo == y.CodigoUniDep && z.CodigoDepartamento == SelDepartamento.Codigo))).ToList();
                }

                if (dgvUniversidades.CurrentRow.Index > 0 && dgvDepartamentos.CurrentRow.Index == 0)
                {
                    filtro = Professores.Where(x => x.Codigo == 0 ||
                        UniDepPro.Any(y => y.CodigoProfessor == x.Codigo &&
                            UniDep.Any(z => z.Codigo == y.CodigoUniDep && z.CodigoUniversidade == SelUniversidade.Codigo))).ToList();
                }

                if (dgvUniversidades.CurrentRow.Index > 0 && dgvDepartamentos.CurrentRow.Index > 0)
                {
                    var codigoUniDep = UniDep.LastOrDefault(x => (x.Codigo == 0 || 
                        x.CodigoUniversidade == SelUniversidade.Codigo && x.CodigoDepartamento == SelDepartamento.Codigo)).Codigo;

                    filtro = Professores.Where(x => x.Codigo == 0 ||
                        UniDepPro.Any(y => y.CodigoProfessor == x.Codigo && y.CodigoUniDep == codigoUniDep)).ToList();
                }

                dgvProfessores.DataSource = (filtro == null) ? Professores : new BindingList<Professor>(filtro);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                AtualizaNumeros();
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

                if (dgvProfessores.CurrentRow.Index == 0)
                {
                    UniCount = Universidades.Count - 1;
                }
                else
                {
                    foreach (var row in dgvUniversidades.Rows.Cast<DataGridViewRow>()
                        .Where(x => (x.DataBoundItem as Universidade).Codigo > 0 &&
                            UniDepPro.Any(y => y.CodigoProfessor == SelProfessor.Codigo &&
                                UniDep.Any(z => z.Codigo == y.CodigoUniDep && z.CodigoUniversidade == (x.DataBoundItem as Universidade).Codigo))))
                    {
                        row.DefaultCellStyle.BackColor = Color.Pink;
                        UniCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                AtualizaNumeros();
            }
        }
    }
}

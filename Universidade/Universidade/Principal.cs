using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Universidade
{
    public partial class Principal : Form
    {
        private BindingList<Universidade> Universidades { get; set; }
        private BindingList<Departamento> Departamentos { get; set; }
        private BindingList<Professor> Professores { get; set; }
        private List<UniversidadeDepartamento> UniDep { get; set; }
        private List<DepartamentoProfessor> DepPro { get; set; }
        private Universidade SelUniversidade { get; set; }
        private Departamento SelDepartamento { get; set; }
        private Professor SelProfessor { get; set; }
        private Random Rnd = new Random();

        public Principal()
        {
            InitializeComponent();

            InicializaListas();
            PopulaDataGrids();
            AtualizaNumeros();
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
            Professores.Add(new Professor("Beatriz"));
            Professores.Add(new Professor("Guilherme"));
            Professores.Add(new Professor("Mariana"));
            Professores.Add(new Professor("Felipe"));
            Professores.Add(new Professor("Gustavo"));
            Professores.Add(new Professor("Henrique"));
            Professores.Add(new Professor("Rafaela"));
            Professores.Add(new Professor("Daniel"));
            Professores.Add(new Professor("Murilo"));
            Professores.Add(new Professor("Vitor"));

            UniDep = new List<UniversidadeDepartamento>();
            UniDep.Add(new UniversidadeDepartamento(0, 0));

            DepPro = new List<DepartamentoProfessor>();
            DepPro.Add(new DepartamentoProfessor(0, 0));

            Aleatorios();
        }

        /* Atribui Departamentos e Professores aleatoriamente */
        private void Aleatorios()
        {
            int nUni = Universidades.Count;
            int nDep = Departamentos.Count;
            int nPro = Professores.Count;
            int nUniDep = nUni * nDep;
            int nDepPro = nDep * nPro;

            for (int i = 0; i < nUniDep/2; i++)
            {
                UniDep.Add(new UniversidadeDepartamento(Rnd.Next(1, nUni), Rnd.Next(1, nDep)));
            }

            foreach (var x in UniDep)
            {
                for (int i = 0; i < nDepPro/2; i++)
                {
                    DepPro.Add(new DepartamentoProfessor(Rnd.Next(1, nUniDep), Rnd.Next(1, nPro)));
                }
            }
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
            lblQtdUniversidadesValor.Text = Convert.ToString(dgvUniversidades.RowCount - 1);
            lblQtdDepartamentosValor.Text = Convert.ToString(dgvDepartamentos.RowCount - 1);
            lblQtdProfessoresValor.Text = Convert.ToString(dgvProfessores.RowCount - 1);
        }

        private void LiberaBotoes()
        {
            if (dgvUniversidades.Rows[0].Selected && dgvDepartamentos.Rows[0].Selected && dgvProfessores.Rows[0].Selected)
            {
                btnCadDepartamento.Enabled = true;
                btnRemDepartamento.Enabled = true;
                btnCadProfessor.Enabled = true;
                btnRemProfessor.Enabled = true;
            }
            else
            {
                btnCadDepartamento.Enabled = false;
                btnRemDepartamento.Enabled = false;
                btnCadProfessor.Enabled = false;
                btnRemProfessor.Enabled = false;
            }
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

        private void dgvUniversidades_SelectionChanged(object sender, EventArgs e)
        {
            SelUniversidade = dgvUniversidades.CurrentRow.DataBoundItem as Universidade;

            if (dgvUniversidades.CurrentRow.Index == 0)
            {
                dgvDepartamentos.DataSource = Departamentos;
                dgvDepartamentos.Rows[0].Selected = true;
                dgvProfessores.Rows[0].Selected = true;
            }
            else
            {
                var filtered = Departamentos
                    .Where(x => x.Codigo == 0 ||
                        UniDep.Any(y => y.CodigoDepartamento == x.Codigo && 
                                        y.CodigoUniversidade == SelUniversidade.Codigo)
                    ).ToList();

                dgvDepartamentos.DataSource = new BindingList<Departamento>(filtered);
                dgvDepartamentos.Update();
            }

            //AtualizaNumeros();
            //LiberaBotoes();
        }

        private void dgvDepartamentos_SelectionChanged(object sender, EventArgs e)
        {
            SelDepartamento = dgvDepartamentos.CurrentRow.DataBoundItem as Departamento;

            if (dgvDepartamentos.CurrentRow.Index == 0)
            {
                dgvProfessores.DataSource = Professores;
                dgvProfessores.Rows[0].Selected = true;
            }
            else
            {
                //var filtered = Professores
                //        .Where(x => x.Codigo == 0 ||
                //            DepPro.Any(y => y.CodigoProfessor == x.Codigo &&
                //                            y.CodigoUniDep == SelDepartamento.Codigo)
                //        ).ToList();

                //dgvProfessores.DataSource = new BindingList<Professor>(filtered);
                //dgvProfessores.Update();
            }

            //AtualizaNumeros();
            //LiberaBotoes();
        }

        private void dgvProfessores_SelectionChanged(object sender, EventArgs e)
        {
            //SelProfessor = dgvProfessores.CurrentRow.DataBoundItem as Professor;

            //AtualizaNumeros();
            //LiberaBotoes();
        }
    }
}

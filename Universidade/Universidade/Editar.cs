﻿using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static Universidade.Listas;

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

            if (Nomeavel is Universidade)
            {
                AtualizaTelaPrincipal(Principal.dgvUniversidades);
            }
            else if (Nomeavel is Departamento)
            {
                AtualizaTelaPrincipal(Principal.dgvDepartamentos);
            }
            else // (Nomeavel is Professor)
            {
                AtualizaTelaPrincipal(Principal.dgvProfessores);
            }
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
                dgvVinculados.DataSource = Departamentos.Where(x => x.Codigo > 0 && UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == Nomeavel.Codigo)).ToList();
                dgvNaoVinculados.DataSource = Departamentos.Where(x => x.Codigo > 0 && !UniDepList.Any(y => y.Chaves.Item2 == x.Codigo && y.Chaves.Item1 == Nomeavel.Codigo)).ToList();
                EscondeColuna("Codigo");
            }
            else if (Nomeavel is Departamento)
            {
                dgvVinculados.DataSource = Universidades.Where(x => x.Codigo > 0 && UniDepList.Any(y => y.Chaves.Item1 == x.Codigo && y.Chaves.Item2 == Nomeavel.Codigo)).ToList();
                dgvNaoVinculados.DataSource = Universidades.Where(x => x.Codigo > 0 && !UniDepList.Any(y => y.Chaves.Item1 == x.Codigo && y.Chaves.Item2 == Nomeavel.Codigo)).ToList();
                EscondeColuna("Codigo");
            }
            else // (Nomeavel is Professor)
            {
                dgvVinculados.DataSource = UniDepProList.Where(x => x.Chaves.Item2 == Nomeavel.Codigo).Select(x => x.Chaves.Item1).ToList();
                dgvNaoVinculados.DataSource = UniDepList.Where(x => x.Chaves.Item1 > 0 && !UniDepProList.Any(y => y.Chaves.Item1.Equals(x) && y.Chaves.Item2 == Nomeavel.Codigo)).ToList();
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
                Text = "(Universidade) " + Nomeavel.Nome;
                lblVinculados.Text = "Departamentos vinculados:";
                lblNaoVinculados.Text = "Departamentos não vinculados:";
            }
            else if (Nomeavel is Departamento)
            {
                Text = "(Departamento) " + Nomeavel.Nome;
                lblVinculados.Text = "Universidades vinculadas:";
                lblNaoVinculados.Text = "Universidades não vinculadas:";
            }
            else // (Nomeavel is Professor)
            {
                Text = "(Professor) " + Nomeavel.Nome;
                lblVinculados.Text = "Universidades > Departamentos vinculados:";
                lblNaoVinculados.Text = "Universidades > Departamentos não vinculados:";
            }
        }

        private void AtualizaNumeros()
        {
            var total = Convert.ToString(dgvVinculados.RowCount + dgvNaoVinculados.RowCount);
            lblQtdVinculadosValor.Text = dgvVinculados.RowCount + " / " + total;
            lblQtdNaoVinculadosValor.Text = dgvNaoVinculados.RowCount + " / " + total;
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

                if (txtNome.Enabled && !txtNome.Text.Equals(Nomeavel.Nome))
                {
                    Nomeavel.Nome = txtNome.Text;
                    MessageBox.Show("Nome alterado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtNome.Enabled = false;
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
                    UniDepProList.Add(new UniDepPro(GetChaves(dgvNaoVinculados) as Tuple<UniDep, int>));
                }
                else
                {
                    UniDepList.Add(new UniDep(GetChaves(dgvNaoVinculados) as Tuple<int, int>));
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
                    var chaves = GetChaves(dgvVinculados) as Tuple<UniDep, int>;
                    UniDepProList.RemoveWhere(x => x.Chaves.Equals(chaves));
                }
                else
                {
                    var chaves = GetChaves(dgvVinculados) as Tuple<int, int>;
                    UniDepProList.RemoveWhere(x => x.Chaves.Item1.Chaves.Equals(chaves));
                    UniDepList.RemoveWhere(x => x.Chaves.Equals(chaves));
                }
                
                PopulaDataGrids();
            }
        }

        private IComparable GetChaves(DataGridView dgv)
        {
            if (Nomeavel is Universidade)
            {
                return new Tuple<int, int>(Nomeavel.Codigo, Convert.ToInt32(dgv.CurrentRow.Cells["Codigo"].Value));
            }
            else if (Nomeavel is Departamento)
            {
                return new Tuple<int, int>(Convert.ToInt32(dgv.CurrentRow.Cells["Codigo"].Value), Nomeavel.Codigo);
            }
            else // (Nomeavel is Professor)
            {
                return new Tuple<UniDep, int>(dgv.CurrentRow.DataBoundItem as UniDep, Nomeavel.Codigo);
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (Nomeavel is Professor)
            {
                foreach (var row in (sender as DataGridView).Rows.Cast<DataGridViewRow>())
                {
                    var item = row.DataBoundItem as UniDep;
                    row.Cells["Universidade"].Value = Universidades.FirstOrDefault(x => x.Codigo == item.Chaves.Item1).Nome;
                    row.Cells["Departamento"].Value = Departamentos.FirstOrDefault(x => x.Codigo == item.Chaves.Item2).Nome;
                }
            }
        }
    }
}

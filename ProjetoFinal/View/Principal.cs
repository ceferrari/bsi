using Domain;
using Infra;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace View
{
    public partial class Principal : Form
    {
        private Produto Selecionado { get; set; }

        public Principal(Usuario logado)
        {
            InitializeComponent();
            InicializaDataGridView();
            tabEstoque.SelectedTab = tpListagem;
            lblBemVindo.Text = "Bem-vindo, " + logado.Nome + "!";
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja sair do sistema?", "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                new Login().Show();
                Dispose();
            }
        }

        private void InicializaDataGridView()
        {
            dgvProdutos.AutoGenerateColumns = false;
            AtualizaDataGridView();

            dgvProdutos.Columns["Codigo"].DataPropertyName = "Codigo";
            dgvProdutos.Columns["Descricao"].DataPropertyName = "Descricao";
            dgvProdutos.Columns["Preco"].DataPropertyName = "Preco";
            dgvProdutos.Columns["EstoqueAtual"].DataPropertyName = "EstoqueAtual";
            dgvProdutos.Columns["EstoqueMinimo"].DataPropertyName = "EstoqueMinimo";
            dgvProdutos.Columns["EstoqueMinimo"].DataPropertyName = "EstoqueMinimo";
            dgvProdutos.Columns["PrecisaReposicao"].DataPropertyName = "PrecisaReposicao";
            dgvProdutos.Columns["DataAlteracao"].DataPropertyName = "DataAlteracao";
            
            dgvProdutos.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProdutos.Columns["Preco"].DefaultCellStyle.Format = "C";
            dgvProdutos.Columns["DataAlteracao"].DefaultCellStyle.Format = "G";
            dgvProdutos.Columns["DataAlteracao"].DefaultCellStyle.Font = new Font("Consolas", 10F);

            dgvProdutos.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 9F, FontStyle.Bold);
        }

        private void AtualizaDataGridView()
        {
            dgvProdutos.DataSource = new ProdutoDAO().Lista();
        }

        private void AtualizaSelecionado()
        {
            new ProdutoDAO().Atualiza(Selecionado);
            AtualizaDataGridView();
        }

        /* Eventos da aba Listagem */
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Selecionado.Inserir(ShowInputBox());
                AtualizaSelecionado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                Selecionado.Retirar(ShowInputBox());
                AtualizaSelecionado();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = Selecionado.Codigo.ToString();
            txtDescricao.Text = Selecionado.Descricao;
            mskPreco.Text = Selecionado.Preco.ToString("00.00");
            nudEstoqueAtual.Value = Selecionado.EstoqueAtual;
            nudEstoqueMinimo.Value = Selecionado.EstoqueMinimo;

            tabEstoque.SelectedTab = tpCadastro;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabEstoque.SelectedTab = tpCadastro;
            LimpaCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("Tem certeza que deseja excluir o produto: "
                    + Environment.NewLine + "- Código:  " + Selecionado.Codigo
                    + Environment.NewLine + "- Descrição:  " + Selecionado.Descricao, 
                    "Info", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (dr == DialogResult.Yes)
                {
                    new ProdutoDAO().Remove(Selecionado);
                    MessageBox.Show("Produto " + Selecionado.Descricao + " excluído com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaDataGridView();
                }

                tabEstoque.SelectedTab = tpListagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int ShowInputBox()
        {
            InputBox ib = new InputBox();
            return (ib.ShowDialog() == DialogResult.OK) ? ib.Valor : 0;
        }

        /* Eventos do DataGridView */
        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            Selecionado = dgvProdutos.CurrentRow.DataBoundItem as Produto;
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar_Click(sender, e);
        }

        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dgv = sender as DataGridView;

            if (dgv.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
            else
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Regular);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToBoolean(row.Cells["PrecisaReposicao"].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Pink;
                    row.DefaultCellStyle.SelectionBackColor = Color.Pink;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = Color.White;
                }
            }
        }

        /* Eventos da aba Cadastro */
        private void btnCadNovo_Click(object sender, EventArgs e)
        {
            btnNovo_Click(sender, e);
        }

        private void btnCadExcluir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                btnExcluir_Click(sender, e);
            }
        }

        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                var descricao = txtDescricao.Text;
                var preco = Convert.ToDouble(mskPreco.Text.Substring(3));
                var atual = Convert.ToInt32(nudEstoqueAtual.Value);
                var minimo = Convert.ToInt32(nudEstoqueMinimo.Value);

                if (String.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    new ProdutoDAO().Insere(new Produto(0, descricao, preco, atual, minimo));
                    MessageBox.Show("Produto " + descricao + " cadastrado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaDataGridView();
                }
                else
                {
                    Selecionado.SetDescricao(descricao);
                    Selecionado.SetPreco(preco);
                    Selecionado.SetEstoqueAtual(atual);
                    Selecionado.SetEstoqueMinimo(minimo);
                    MessageBox.Show("Produto " + Selecionado.Descricao + " atualizado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizaSelecionado();
                }

                LimpaCampos();
                tabEstoque.SelectedTab = tpListagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimpaCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            mskPreco.Clear();
            nudEstoqueAtual.Value = 0;
            nudEstoqueMinimo.Value = 0;
        }

        /* Eventos do MaskedTextBox mskPreco */
        private void mskPreco_Click(object sender, EventArgs e)
        {
            mskPreco.SelectionStart = mskPreco.Mask.Length + 1;
        }

        private void mskPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && char.IsDigit(e.KeyChar))
            {
                string str = mskPreco.Text.Substring(3).Replace(",","") + e.KeyChar;
                mskPreco.Text = str.Substring(1, str.Length - 1).Insert(2, ",");
                mskPreco.SelectionStart = mskPreco.Mask.Length + 1;
            }
        }

        private void mskPreco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                mskPreco.Text = "0" + mskPreco.Text.Substring(3).Replace(",", "");
                mskPreco.SelectionStart = mskPreco.Mask.Length + 1;
            }
        }
    }
}

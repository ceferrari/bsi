using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Estoque
{
    public partial class Principal : Form
    {
        private BindingList<Produto> Produtos { get; set; }
        private Produto Selecionado { get; set; }
        private Random Random = new Random();

        public Principal()
        {
            InitializeComponent();

            GeraProdutos();
            PopulaDataGridView();
            tabEstoque.SelectedTab = tpListagem;
        }

        private void GeraProdutos()
        {
            Produtos = new BindingList<Produto>();
            Produtos.Add(new Produto("Caneta"));
            Produtos.Add(new Produto("Lápis"));
            Produtos.Add(new Produto("Caderno"));
            Produtos.Add(new Produto("Bola"));
            Produtos.Add(new Produto("Ventilador"));
            Produtos.Add(new Produto("Régua"));
            Produtos.Add(new Produto("Apontador"));
            Produtos.Add(new Produto("Borracha"));
            Produtos.Add(new Produto("Compasso"));
            Produtos.Add(new Produto("Tesoura"));
            Produtos.Add(new Produto("Cadeira"));
            Produtos.Add(new Produto("Mesa"));
            Produtos.Add(new Produto("Papel"));
            Produtos.Add(new Produto("Carteira"));
            Produtos.Add(new Produto("Corda"));
            Produtos.Add(new Produto("Fichário"));

            /* Gera Preço, Estoque Atual, Estoque Mínimo Aleatórios */
            foreach (var p in Produtos)
            {
                int[] v = { 10, 20, 30, 40, 50 };
                p.SetEstoqueMinimo(v[Random.Next(v.Length)]);
                p.Inserir(Random.Next(5, 75));
                p.SetPreco(Random.NextDouble() * (25 - 5) + 5);
            }
        }

        private void PopulaDataGridView()
        {
            dgvProdutos.AutoGenerateColumns = false;
            dgvProdutos.DataSource = Produtos;

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

        /* Eventos da aba Listagem */
        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Selecionado.Inserir(ShowInputBox());
                dgvProdutos.Refresh();
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
                dgvProdutos.Refresh();
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
                    Produtos.Remove(Selecionado);
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
            if (!txtCodigo.Text.Equals(""))
            {
                btnExcluir_Click(sender, e);
            }
        }

        private void btnCadSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string descricao = txtDescricao.Text;
                double preco = Convert.ToDouble(mskPreco.Text.Substring(3));
                int atual = Convert.ToInt32(nudEstoqueAtual.Value);
                int minimo = Convert.ToInt32(nudEstoqueMinimo.Value);

                if (txtCodigo.Text.Equals(""))
                {
                    Produtos.Add(new Produto(descricao, preco, atual, minimo));
                }
                else
                {
                    Selecionado.SetDescricao(descricao);
                    Selecionado.SetPreco(preco);
                    Selecionado.SetEstoqueAtual(atual);
                    Selecionado.SetEstoqueMinimo(minimo);
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

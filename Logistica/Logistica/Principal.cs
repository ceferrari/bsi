using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logistica
{
    public partial class Principal : Form
    {
        public static Listagem Listagem { get; set; }
        private List<Produto> Produtos { get; set; }
        private HashSet<Produto> TiposProdutos { get; set; }
        private Random Random = new Random();

        public Principal()
        {
            InitializeComponent();
            
            Produtos = GetListaProdutos();
            TiposProdutos = new HashSet<Produto>(Produtos);
            ProdutosAleatorios();
            EstoquesMinimosAleatorios();
            PopulaDataGridView();
        }

        private List<Produto> GetListaProdutos()
        {
            return typeof(Produto)
                .Assembly.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Produto)) && !t.IsAbstract)
                .Select(t => (Produto)Activator.CreateInstance(t))
                .ToList();
        }

        private void ProdutosAleatorios()
        {
            foreach (var t in TiposProdutos)
            {
                for (int i = 0; i < Random.Next(5,25); i++)
                {
                    Produto p = (Produto)Activator.CreateInstance(t.GetType());
                    Produtos.Add(p);
                }
            }
        }

        private void EstoquesMinimosAleatorios()
        {
            foreach (var t in TiposProdutos)
            {
                object[] obj1 = { 5,10,15 };
                object[] obj2 = { obj1[Random.Next(obj1.Length)] };
                t.GetType().GetMethod("SetEstoqueMinimo").Invoke(t, obj2);
            }
        }

        private void PopulaDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Estoque Atual", typeof(int));
            dt.Columns.Add("Estoque Mínimo", typeof(int));
            dt.Columns.Add("Precisa Repor", typeof(bool));
            dt.Columns.Add("Data Alteração", typeof(DateTime));

            foreach (var p in TiposProdutos)
            {
                dt.Rows.Add(p, p.GetEstoqueAtual(), p.GetEstoqueMinimo(), p.GetPrecisaReposicao(), p.GetDataAlteracao());
            }

            dgvProdutos.DataSource = dt;
            dgvProdutos.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProdutos.Columns["Precisa Repor"].Visible = false;
            dgvProdutos.Columns["Data Alteração"].DefaultCellStyle.Font = new Font("Consolas", 12F);
            
            DataGridViewImageColumn ic;
            Bitmap img;

            ic = new DataGridViewImageColumn();
            ic.HeaderText = "Listar";
            img = new Bitmap(@"..\..\img\search.png");
            ic.Image = new Bitmap(img, new Size(20,20));
            dgvProdutos.Columns.Add(ic);

            ic = new DataGridViewImageColumn();
            ic.HeaderText = "Inserir";
            img = new Bitmap(@"..\..\img\add.png");
            ic.Image = new Bitmap(img, new Size(20, 20));
            dgvProdutos.Columns.Add(ic);
        }

        private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {            
                row.DefaultCellStyle.BackColor = Convert.ToBoolean(row.Cells["Precisa Repor"].Value) ? Color.Pink : Color.White;
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].HeaderText.Equals("Listar"))
                {
                    if (Listagem == null)
                    {
                        string p = senderGrid.CurrentRow.Cells["Produto"].FormattedValue.ToString();
                        Listagem = new Listagem(Produtos.Where(x => x.GetType().Name.Equals(p)).ToList());
                        Listagem.Show();
                    }
                }
            }
        }

        private void dgvProdutos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
            {
                return;
            }

            if (senderGrid.Columns[e.ColumnIndex].HeaderText.Equals("Listar") ||
                senderGrid.Columns[e.ColumnIndex].HeaderText.Equals("Inserir"))
            {
                dgvProdutos.Cursor = Cursors.Hand;
            }  
            else 
            {
                dgvProdutos.Cursor = Cursors.Default;
            }
        }
    }
}

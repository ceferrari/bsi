using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Logistica
{
    public partial class Listagem : Form
    {
        private List<Produto> Produtos { get; set; }

        public Listagem(List<Produto> produtos)
        {
            InitializeComponent();

            Produtos = produtos;
            PopulaDataGridView();
        }

        private void PopulaDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Data Inclusão", typeof(DateTime));
            
            foreach (var p in Produtos)
            {
                dt.Rows.Add(p.Codigo, p.Descricao, p.GetDataAlteracao());
            }

            dgvProdutos.DataSource = dt;
            dgvProdutos.Columns["Descrição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProdutos.Columns["Data Inclusão"].DefaultCellStyle.Font = new Font("Consolas", 12F);

            DataGridViewImageColumn ic = new DataGridViewImageColumn();
            Bitmap img = new Bitmap(@"..\..\img\delete.png");
            ic.Image = new Bitmap(img, new Size(20, 20));
            ic.HeaderText = "Retirar";
            dgvProdutos.Columns.Add(ic);
        }

        private void Listagem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Principal.Listagem = null;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn && e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].HeaderText.Equals("Retirar"))
                {
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

            if (senderGrid.Columns[e.ColumnIndex].HeaderText.Equals("Retirar"))
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

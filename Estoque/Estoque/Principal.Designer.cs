namespace Estoque
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabEstoque = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCadNovo = new System.Windows.Forms.Button();
            this.btnCadExcluir = new System.Windows.Forms.Button();
            this.btnCadSalvar = new System.Windows.Forms.Button();
            this.lblEstoqueMinimo = new System.Windows.Forms.Label();
            this.nudEstoqueMinimo = new System.Windows.Forms.NumericUpDown();
            this.nudEstoqueAtual = new System.Windows.Forms.NumericUpDown();
            this.lblEstoqueAtual = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.mskPreco = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tpListagem = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecisaReposicao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DataAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEstoque.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueAtual)).BeginInit();
            this.tpListagem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.tpCadastro);
            this.tabEstoque.Controls.Add(this.tpListagem);
            this.tabEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEstoque.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEstoque.Location = new System.Drawing.Point(0, 0);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.SelectedIndex = 0;
            this.tabEstoque.Size = new System.Drawing.Size(634, 401);
            this.tabEstoque.TabIndex = 1;
            // 
            // tpCadastro
            // 
            this.tpCadastro.Controls.Add(this.tableLayoutPanel2);
            this.tpCadastro.Location = new System.Drawing.Point(4, 28);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(626, 369);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel2.Controls.Add(this.btnCadNovo, 2, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnCadExcluir, 3, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnCadSalvar, 4, 6);
            this.tableLayoutPanel2.Controls.Add(this.lblEstoqueMinimo, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.nudEstoqueMinimo, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.nudEstoqueAtual, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblEstoqueAtual, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblPreco, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.mskPreco, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtDescricao, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDescricao, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCodigo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCodigo, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(610, 357);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCadNovo
            // 
            this.btnCadNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadNovo.Location = new System.Drawing.Point(185, 285);
            this.btnCadNovo.Name = "btnCadNovo";
            this.btnCadNovo.Size = new System.Drawing.Size(97, 47);
            this.btnCadNovo.TabIndex = 6;
            this.btnCadNovo.Text = "Novo";
            this.btnCadNovo.UseVisualStyleBackColor = true;
            this.btnCadNovo.Click += new System.EventHandler(this.btnCadNovo_Click);
            // 
            // btnCadExcluir
            // 
            this.btnCadExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadExcluir.Location = new System.Drawing.Point(288, 285);
            this.btnCadExcluir.Name = "btnCadExcluir";
            this.btnCadExcluir.Size = new System.Drawing.Size(97, 47);
            this.btnCadExcluir.TabIndex = 7;
            this.btnCadExcluir.Text = "Excluir";
            this.btnCadExcluir.UseVisualStyleBackColor = true;
            this.btnCadExcluir.Click += new System.EventHandler(this.btnCadExcluir_Click);
            // 
            // btnCadSalvar
            // 
            this.btnCadSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadSalvar.Location = new System.Drawing.Point(391, 285);
            this.btnCadSalvar.Name = "btnCadSalvar";
            this.btnCadSalvar.Size = new System.Drawing.Size(97, 47);
            this.btnCadSalvar.TabIndex = 8;
            this.btnCadSalvar.Text = "Salvar";
            this.btnCadSalvar.UseVisualStyleBackColor = true;
            this.btnCadSalvar.Click += new System.EventHandler(this.btnCadSalvar_Click);
            // 
            // lblEstoqueMinimo
            // 
            this.lblEstoqueMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstoqueMinimo.AutoSize = true;
            this.lblEstoqueMinimo.Location = new System.Drawing.Point(33, 212);
            this.lblEstoqueMinimo.Name = "lblEstoqueMinimo";
            this.lblEstoqueMinimo.Size = new System.Drawing.Size(146, 53);
            this.lblEstoqueMinimo.TabIndex = 3;
            this.lblEstoqueMinimo.Text = "Estoque Mínimo:";
            this.lblEstoqueMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudEstoqueMinimo
            // 
            this.nudEstoqueMinimo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.nudEstoqueMinimo, 3);
            this.nudEstoqueMinimo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEstoqueMinimo.Location = new System.Drawing.Point(185, 224);
            this.nudEstoqueMinimo.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.nudEstoqueMinimo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            this.nudEstoqueMinimo.Size = new System.Drawing.Size(303, 32);
            this.nudEstoqueMinimo.TabIndex = 5;
            // 
            // nudEstoqueAtual
            // 
            this.nudEstoqueAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.nudEstoqueAtual, 3);
            this.nudEstoqueAtual.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEstoqueAtual.Location = new System.Drawing.Point(185, 171);
            this.nudEstoqueAtual.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.nudEstoqueAtual.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudEstoqueAtual.Name = "nudEstoqueAtual";
            this.nudEstoqueAtual.Size = new System.Drawing.Size(303, 32);
            this.nudEstoqueAtual.TabIndex = 4;
            // 
            // lblEstoqueAtual
            // 
            this.lblEstoqueAtual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstoqueAtual.AutoSize = true;
            this.lblEstoqueAtual.Location = new System.Drawing.Point(33, 159);
            this.lblEstoqueAtual.Name = "lblEstoqueAtual";
            this.lblEstoqueAtual.Size = new System.Drawing.Size(146, 53);
            this.lblEstoqueAtual.TabIndex = 2;
            this.lblEstoqueAtual.Text = "Estoque Atual:";
            this.lblEstoqueAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(33, 106);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(146, 53);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mskPreco
            // 
            this.mskPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.mskPreco, 3);
            this.mskPreco.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPreco.Location = new System.Drawing.Point(185, 118);
            this.mskPreco.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.mskPreco.Mask = "$ 90.00";
            this.mskPreco.Name = "mskPreco";
            this.mskPreco.PromptChar = '0';
            this.mskPreco.Size = new System.Drawing.Size(303, 32);
            this.mskPreco.SkipLiterals = false;
            this.mskPreco.TabIndex = 3;
            this.mskPreco.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskPreco.Click += new System.EventHandler(this.mskPreco_Click);
            this.mskPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskPreco_KeyPress);
            this.mskPreco.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mskPreco_KeyUp);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtDescricao, 3);
            this.txtDescricao.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(185, 65);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(303, 32);
            this.txtDescricao.TabIndex = 2;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(33, 53);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(146, 53);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.txtCodigo, 3);
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(185, 12);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(303, 32);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(33, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(146, 53);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tpListagem
            // 
            this.tpListagem.Controls.Add(this.tableLayoutPanel1);
            this.tpListagem.Location = new System.Drawing.Point(4, 28);
            this.tpListagem.Name = "tpListagem";
            this.tpListagem.Padding = new System.Windows.Forms.Padding(3);
            this.tpListagem.Size = new System.Drawing.Size(626, 369);
            this.tpListagem.TabIndex = 1;
            this.tpListagem.Text = "Listagem";
            this.tpListagem.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.Controls.Add(this.btnInserir, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNovo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRetirar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvProdutos, -1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInserir
            // 
            this.btnInserir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Image = ((System.Drawing.Image)(resources.GetObject("btnInserir.Image")));
            this.btnInserir.Location = new System.Drawing.Point(542, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 66);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(542, 291);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 69);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(542, 219);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 66);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(542, 147);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 66);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetirar.Image = ((System.Drawing.Image)(resources.GetObject("btnRetirar.Image")));
            this.btnRetirar.Location = new System.Drawing.Point(542, 75);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 66);
            this.btnRetirar.TabIndex = 3;
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProdutos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Preco,
            this.EstoqueAtual,
            this.EstoqueMinimo,
            this.PrecisaReposicao,
            this.DataAlteracao});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 3);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 30;
            this.dgvProdutos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetRowSpan(this.dgvProdutos, 5);
            this.dgvProdutos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(533, 357);
            this.dgvProdutos.TabIndex = 0;
            this.dgvProdutos.TabStop = false;
            this.dgvProdutos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProdutos_CellFormatting);
            this.dgvProdutos.SelectionChanged += new System.EventHandler(this.dgvProdutos_SelectionChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 60;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 60;
            // 
            // Descricao
            // 
            this.Descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Descricao.HeaderText = "Produto";
            this.Descricao.MinimumWidth = 115;
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descricao.Width = 115;
            // 
            // Preco
            // 
            this.Preco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Preco.HeaderText = "Preço";
            this.Preco.MinimumWidth = 90;
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Preco.Width = 90;
            // 
            // EstoqueAtual
            // 
            this.EstoqueAtual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EstoqueAtual.HeaderText = "Estoque Atual";
            this.EstoqueAtual.MinimumWidth = 70;
            this.EstoqueAtual.Name = "EstoqueAtual";
            this.EstoqueAtual.ReadOnly = true;
            this.EstoqueAtual.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EstoqueAtual.Width = 70;
            // 
            // EstoqueMinimo
            // 
            this.EstoqueMinimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EstoqueMinimo.HeaderText = "Estoque Mínimo";
            this.EstoqueMinimo.MinimumWidth = 70;
            this.EstoqueMinimo.Name = "EstoqueMinimo";
            this.EstoqueMinimo.ReadOnly = true;
            this.EstoqueMinimo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EstoqueMinimo.Width = 70;
            // 
            // PrecisaReposicao
            // 
            this.PrecisaReposicao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecisaReposicao.HeaderText = "Precisa Reposição";
            this.PrecisaReposicao.MinimumWidth = 65;
            this.PrecisaReposicao.Name = "PrecisaReposicao";
            this.PrecisaReposicao.ReadOnly = true;
            this.PrecisaReposicao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecisaReposicao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrecisaReposicao.Visible = false;
            this.PrecisaReposicao.Width = 65;
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DataAlteracao.HeaderText = "Data Alteração";
            this.DataAlteracao.MinimumWidth = 108;
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.ReadOnly = true;
            this.DataAlteracao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataAlteracao.Width = 108;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 401);
            this.Controls.Add(this.tabEstoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            this.tabEstoque.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstoqueAtual)).EndInit();
            this.tpListagem.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEstoque;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TabPage tpListagem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblEstoqueAtual;
        private System.Windows.Forms.Label lblEstoqueMinimo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.MaskedTextBox mskPreco;
        private System.Windows.Forms.Button btnCadNovo;
        private System.Windows.Forms.Button btnCadSalvar;
        private System.Windows.Forms.Button btnCadExcluir;
        private System.Windows.Forms.NumericUpDown nudEstoqueAtual;
        private System.Windows.Forms.NumericUpDown nudEstoqueMinimo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstoqueMinimo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrecisaReposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAlteracao;
    }
}


namespace Universidade
{
    partial class Editar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpVinculos = new System.Windows.Forms.TableLayoutPanel();
            this.lblQtdNaoVinculados = new System.Windows.Forms.Label();
            this.lblVinculados = new System.Windows.Forms.Label();
            this.dgvVinculados = new System.Windows.Forms.DataGridView();
            this.dgvNaoVinculados = new System.Windows.Forms.DataGridView();
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnDesvincular = new System.Windows.Forms.Button();
            this.lblNaoVinculados = new System.Windows.Forms.Label();
            this.lblQtdVinculados = new System.Windows.Forms.Label();
            this.lblQtdVinculadosValor = new System.Windows.Forms.Label();
            this.lblQtdNaoVinculadosValor = new System.Windows.Forms.Label();
            this.gbEditar = new System.Windows.Forms.GroupBox();
            this.tlpEditar = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tlpVinculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoVinculados)).BeginInit();
            this.gbEditar.SuspendLayout();
            this.tlpEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpVinculos
            // 
            this.tlpVinculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpVinculos.ColumnCount = 6;
            this.tlpVinculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlpVinculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpVinculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpVinculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tlpVinculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpVinculos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tlpVinculos.Controls.Add(this.lblQtdNaoVinculados, 3, 4);
            this.tlpVinculos.Controls.Add(this.lblVinculados, 0, 1);
            this.tlpVinculos.Controls.Add(this.dgvVinculados, 0, 2);
            this.tlpVinculos.Controls.Add(this.dgvNaoVinculados, 3, 2);
            this.tlpVinculos.Controls.Add(this.btnVincular, 2, 2);
            this.tlpVinculos.Controls.Add(this.btnDesvincular, 2, 3);
            this.tlpVinculos.Controls.Add(this.lblNaoVinculados, 3, 1);
            this.tlpVinculos.Controls.Add(this.lblQtdVinculados, 0, 4);
            this.tlpVinculos.Controls.Add(this.lblQtdVinculadosValor, 1, 4);
            this.tlpVinculos.Controls.Add(this.lblQtdNaoVinculadosValor, 5, 4);
            this.tlpVinculos.Controls.Add(this.gbEditar, 0, 0);
            this.tlpVinculos.Location = new System.Drawing.Point(13, 13);
            this.tlpVinculos.Name = "tlpVinculos";
            this.tlpVinculos.RowCount = 5;
            this.tlpVinculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlpVinculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tlpVinculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.5F));
            this.tlpVinculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.5F));
            this.tlpVinculos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpVinculos.Size = new System.Drawing.Size(555, 432);
            this.tlpVinculos.TabIndex = 0;
            // 
            // lblQtdNaoVinculados
            // 
            this.lblQtdNaoVinculados.AutoSize = true;
            this.tlpVinculos.SetColumnSpan(this.lblQtdNaoVinculados, 2);
            this.lblQtdNaoVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdNaoVinculados.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdNaoVinculados.Location = new System.Drawing.Point(301, 403);
            this.lblQtdNaoVinculados.Name = "lblQtdNaoVinculados";
            this.lblQtdNaoVinculados.Size = new System.Drawing.Size(148, 29);
            this.lblQtdNaoVinculados.TabIndex = 0;
            this.lblQtdNaoVinculados.Text = "Quantidade:";
            this.lblQtdNaoVinculados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVinculados
            // 
            this.lblVinculados.AutoSize = true;
            this.tlpVinculos.SetColumnSpan(this.lblVinculados, 2);
            this.lblVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVinculados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVinculados.Location = new System.Drawing.Point(3, 103);
            this.lblVinculados.Name = "lblVinculados";
            this.lblVinculados.Size = new System.Drawing.Size(248, 38);
            this.lblVinculados.TabIndex = 0;
            this.lblVinculados.Text = "Departamentos vinculados:";
            this.lblVinculados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dgvVinculados
            // 
            this.dgvVinculados.AllowUserToAddRows = false;
            this.dgvVinculados.AllowUserToDeleteRows = false;
            this.dgvVinculados.AllowUserToResizeColumns = false;
            this.dgvVinculados.AllowUserToResizeRows = false;
            this.dgvVinculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVinculados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVinculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVinculados.ColumnHeadersHeight = 30;
            this.dgvVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVinculados.ColumnHeadersVisible = false;
            this.tlpVinculos.SetColumnSpan(this.dgvVinculados, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVinculados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVinculados.GridColor = System.Drawing.SystemColors.Control;
            this.dgvVinculados.Location = new System.Drawing.Point(3, 144);
            this.dgvVinculados.MultiSelect = false;
            this.dgvVinculados.Name = "dgvVinculados";
            this.dgvVinculados.ReadOnly = true;
            this.dgvVinculados.RowHeadersVisible = false;
            this.dgvVinculados.RowHeadersWidth = 30;
            this.dgvVinculados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tlpVinculos.SetRowSpan(this.dgvVinculados, 2);
            this.dgvVinculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVinculados.Size = new System.Drawing.Size(248, 256);
            this.dgvVinculados.TabIndex = 4;
            this.dgvVinculados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // dgvNaoVinculados
            // 
            this.dgvNaoVinculados.AllowUserToAddRows = false;
            this.dgvNaoVinculados.AllowUserToDeleteRows = false;
            this.dgvNaoVinculados.AllowUserToResizeColumns = false;
            this.dgvNaoVinculados.AllowUserToResizeRows = false;
            this.dgvNaoVinculados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNaoVinculados.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNaoVinculados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNaoVinculados.ColumnHeadersHeight = 30;
            this.dgvNaoVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNaoVinculados.ColumnHeadersVisible = false;
            this.tlpVinculos.SetColumnSpan(this.dgvNaoVinculados, 3);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNaoVinculados.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNaoVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNaoVinculados.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNaoVinculados.Location = new System.Drawing.Point(301, 144);
            this.dgvNaoVinculados.MultiSelect = false;
            this.dgvNaoVinculados.Name = "dgvNaoVinculados";
            this.dgvNaoVinculados.ReadOnly = true;
            this.dgvNaoVinculados.RowHeadersVisible = false;
            this.dgvNaoVinculados.RowHeadersWidth = 30;
            this.dgvNaoVinculados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tlpVinculos.SetRowSpan(this.dgvNaoVinculados, 2);
            this.dgvNaoVinculados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNaoVinculados.Size = new System.Drawing.Size(251, 256);
            this.dgvNaoVinculados.TabIndex = 7;
            this.dgvNaoVinculados.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            // 
            // btnVincular
            // 
            this.btnVincular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVincular.AutoSize = true;
            this.btnVincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincular.Location = new System.Drawing.Point(257, 238);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(38, 31);
            this.btnVincular.TabIndex = 5;
            this.btnVincular.Text = "<<";
            this.btnVincular.UseVisualStyleBackColor = false;
            this.btnVincular.Click += new System.EventHandler(this.btnVincular_Click);
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesvincular.AutoSize = true;
            this.btnDesvincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesvincular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesvincular.Location = new System.Drawing.Point(257, 275);
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.Size = new System.Drawing.Size(38, 31);
            this.btnDesvincular.TabIndex = 6;
            this.btnDesvincular.Text = ">>";
            this.btnDesvincular.UseVisualStyleBackColor = false;
            this.btnDesvincular.Click += new System.EventHandler(this.btnDesvincular_Click);
            // 
            // lblNaoVinculados
            // 
            this.lblNaoVinculados.AutoSize = true;
            this.tlpVinculos.SetColumnSpan(this.lblNaoVinculados, 3);
            this.lblNaoVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaoVinculados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoVinculados.Location = new System.Drawing.Point(301, 103);
            this.lblNaoVinculados.Name = "lblNaoVinculados";
            this.lblNaoVinculados.Size = new System.Drawing.Size(251, 38);
            this.lblNaoVinculados.TabIndex = 0;
            this.lblNaoVinculados.Text = "Departamentos não vinculados:";
            this.lblNaoVinculados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblQtdVinculados
            // 
            this.lblQtdVinculados.AutoSize = true;
            this.lblQtdVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdVinculados.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVinculados.Location = new System.Drawing.Point(3, 403);
            this.lblQtdVinculados.Name = "lblQtdVinculados";
            this.lblQtdVinculados.Size = new System.Drawing.Size(149, 29);
            this.lblQtdVinculados.TabIndex = 0;
            this.lblQtdVinculados.Text = "Quantidade:";
            this.lblQtdVinculados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtdVinculadosValor
            // 
            this.lblQtdVinculadosValor.AutoSize = true;
            this.lblQtdVinculadosValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdVinculadosValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVinculadosValor.Location = new System.Drawing.Point(158, 403);
            this.lblQtdVinculadosValor.Name = "lblQtdVinculadosValor";
            this.lblQtdVinculadosValor.Size = new System.Drawing.Size(93, 29);
            this.lblQtdVinculadosValor.TabIndex = 0;
            this.lblQtdVinculadosValor.Text = "8 / 10";
            this.lblQtdVinculadosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtdNaoVinculadosValor
            // 
            this.lblQtdNaoVinculadosValor.AutoSize = true;
            this.lblQtdNaoVinculadosValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdNaoVinculadosValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdNaoVinculadosValor.Location = new System.Drawing.Point(455, 403);
            this.lblQtdNaoVinculadosValor.Name = "lblQtdNaoVinculadosValor";
            this.lblQtdNaoVinculadosValor.Size = new System.Drawing.Size(97, 29);
            this.lblQtdNaoVinculadosValor.TabIndex = 0;
            this.lblQtdNaoVinculadosValor.Text = "8 / 10";
            this.lblQtdNaoVinculadosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbEditar
            // 
            this.tlpVinculos.SetColumnSpan(this.gbEditar, 6);
            this.gbEditar.Controls.Add(this.tlpEditar);
            this.gbEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEditar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEditar.Location = new System.Drawing.Point(0, 0);
            this.gbEditar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.gbEditar.Name = "gbEditar";
            this.gbEditar.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbEditar.Size = new System.Drawing.Size(555, 100);
            this.gbEditar.TabIndex = 8;
            this.gbEditar.TabStop = false;
            this.gbEditar.Text = "Editar";
            // 
            // tlpEditar
            // 
            this.tlpEditar.ColumnCount = 3;
            this.tlpEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tlpEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpEditar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tlpEditar.Controls.Add(this.btnEditar, 1, 1);
            this.tlpEditar.Controls.Add(this.lblTitulo, 0, 0);
            this.tlpEditar.Controls.Add(this.txtNome, 1, 0);
            this.tlpEditar.Controls.Add(this.btnSalvar, 2, 1);
            this.tlpEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEditar.Location = new System.Drawing.Point(3, 23);
            this.tlpEditar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tlpEditar.Name = "tlpEditar";
            this.tlpEditar.RowCount = 2;
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEditar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEditar.Size = new System.Drawing.Size(549, 74);
            this.tlpEditar.TabIndex = 4;
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(255, 37);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnEditar.MaximumSize = new System.Drawing.Size(0, 32);
            this.btnEditar.MinimumSize = new System.Drawing.Size(0, 32);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(142, 32);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(246, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Universidade:";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEditar.SetColumnSpan(this.txtNome, 2);
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(255, 1);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 32);
            this.txtNome.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(403, 37);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnSalvar.MaximumSize = new System.Drawing.Size(0, 32);
            this.btnSalvar.MinimumSize = new System.Drawing.Size(0, 32);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(143, 32);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 457);
            this.Controls.Add(this.tlpVinculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Editar";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(Universidade) UNIVEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Editar_FormClosing);
            this.tlpVinculos.ResumeLayout(false);
            this.tlpVinculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoVinculados)).EndInit();
            this.gbEditar.ResumeLayout(false);
            this.tlpEditar.ResumeLayout(false);
            this.tlpEditar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpVinculos;
        private System.Windows.Forms.DataGridView dgvVinculados;
        private System.Windows.Forms.DataGridView dgvNaoVinculados;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnDesvincular;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblVinculados;
        private System.Windows.Forms.Label lblNaoVinculados;
        private System.Windows.Forms.Label lblQtdVinculados;
        private System.Windows.Forms.Label lblQtdNaoVinculados;
        private System.Windows.Forms.Label lblQtdVinculadosValor;
        private System.Windows.Forms.Label lblQtdNaoVinculadosValor;
        private System.Windows.Forms.GroupBox gbEditar;
        private System.Windows.Forms.TableLayoutPanel tlpEditar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
    }
}
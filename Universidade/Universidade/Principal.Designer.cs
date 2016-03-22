namespace Universidade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpListagem = new System.Windows.Forms.TableLayoutPanel();
            this.lblQtdUniversidadesValor = new System.Windows.Forms.Label();
            this.lblQtdUniversidades = new System.Windows.Forms.Label();
            this.dgvUniversidades = new System.Windows.Forms.DataGridView();
            this.CodUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Universidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.CodDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProfessores = new System.Windows.Forms.DataGridView();
            this.CodPro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQtdDepartamentos = new System.Windows.Forms.Label();
            this.lblQtdProfessores = new System.Windows.Forms.Label();
            this.lblQtdDepartamentosValor = new System.Windows.Forms.Label();
            this.lblQtdProfessoresValor = new System.Windows.Forms.Label();
            this.gbNovo = new System.Windows.Forms.GroupBox();
            this.tlpNovo = new System.Windows.Forms.TableLayoutPanel();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.rbDepartamento = new System.Windows.Forms.RadioButton();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbUniversidade = new System.Windows.Forms.RadioButton();
            this.tlpListagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.gbNovo.SuspendLayout();
            this.tlpNovo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpListagem
            // 
            this.tlpListagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpListagem.ColumnCount = 11;
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpListagem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpListagem.Controls.Add(this.lblQtdUniversidadesValor, 1, 4);
            this.tlpListagem.Controls.Add(this.lblQtdUniversidades, 0, 4);
            this.tlpListagem.Controls.Add(this.dgvUniversidades, 0, 1);
            this.tlpListagem.Controls.Add(this.dgvDepartamentos, 4, 1);
            this.tlpListagem.Controls.Add(this.dgvProfessores, 8, 1);
            this.tlpListagem.Controls.Add(this.lblQtdDepartamentos, 4, 4);
            this.tlpListagem.Controls.Add(this.lblQtdProfessores, 8, 4);
            this.tlpListagem.Controls.Add(this.lblQtdDepartamentosValor, 5, 4);
            this.tlpListagem.Controls.Add(this.lblQtdProfessoresValor, 9, 4);
            this.tlpListagem.Controls.Add(this.gbNovo, 0, 0);
            this.tlpListagem.Location = new System.Drawing.Point(12, 12);
            this.tlpListagem.Name = "tlpListagem";
            this.tlpListagem.RowCount = 5;
            this.tlpListagem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tlpListagem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpListagem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpListagem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tlpListagem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpListagem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpListagem.Size = new System.Drawing.Size(756, 533);
            this.tlpListagem.TabIndex = 0;
            // 
            // lblQtdUniversidadesValor
            // 
            this.lblQtdUniversidadesValor.AutoSize = true;
            this.tlpListagem.SetColumnSpan(this.lblQtdUniversidadesValor, 2);
            this.lblQtdUniversidadesValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdUniversidadesValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdUniversidadesValor.Location = new System.Drawing.Point(123, 504);
            this.lblQtdUniversidadesValor.Name = "lblQtdUniversidadesValor";
            this.lblQtdUniversidadesValor.Size = new System.Drawing.Size(114, 29);
            this.lblQtdUniversidadesValor.TabIndex = 0;
            this.lblQtdUniversidadesValor.Text = "45 / 99";
            this.lblQtdUniversidadesValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtdUniversidades
            // 
            this.lblQtdUniversidades.AutoSize = true;
            this.lblQtdUniversidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdUniversidades.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdUniversidades.Location = new System.Drawing.Point(0, 504);
            this.lblQtdUniversidades.Margin = new System.Windows.Forms.Padding(0);
            this.lblQtdUniversidades.Name = "lblQtdUniversidades";
            this.lblQtdUniversidades.Size = new System.Drawing.Size(120, 29);
            this.lblQtdUniversidades.TabIndex = 0;
            this.lblQtdUniversidades.Text = "Quantidade:";
            this.lblQtdUniversidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvUniversidades
            // 
            this.dgvUniversidades.AllowUserToAddRows = false;
            this.dgvUniversidades.AllowUserToDeleteRows = false;
            this.dgvUniversidades.AllowUserToResizeColumns = false;
            this.dgvUniversidades.AllowUserToResizeRows = false;
            this.dgvUniversidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvUniversidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUniversidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUniversidades.ColumnHeadersHeight = 30;
            this.dgvUniversidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUniversidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodUni,
            this.Universidade});
            this.tlpListagem.SetColumnSpan(this.dgvUniversidades, 3);
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUniversidades.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUniversidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUniversidades.GridColor = System.Drawing.SystemColors.Control;
            this.dgvUniversidades.Location = new System.Drawing.Point(3, 93);
            this.dgvUniversidades.MultiSelect = false;
            this.dgvUniversidades.Name = "dgvUniversidades";
            this.dgvUniversidades.ReadOnly = true;
            this.dgvUniversidades.RowHeadersVisible = false;
            this.dgvUniversidades.RowHeadersWidth = 30;
            this.dgvUniversidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tlpListagem.SetRowSpan(this.dgvUniversidades, 3);
            this.dgvUniversidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUniversidades.Size = new System.Drawing.Size(234, 408);
            this.dgvUniversidades.TabIndex = 1;
            this.dgvUniversidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgvUniversidades.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            this.dgvUniversidades.SelectionChanged += new System.EventHandler(this.dgvUniversidades_SelectionChanged);
            // 
            // CodUni
            // 
            this.CodUni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodUni.Frozen = true;
            this.CodUni.HeaderText = "Codigo";
            this.CodUni.Name = "CodUni";
            this.CodUni.ReadOnly = true;
            this.CodUni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodUni.Visible = false;
            // 
            // Universidade
            // 
            this.Universidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Universidade.Frozen = true;
            this.Universidade.HeaderText = "Universidade";
            this.Universidade.Name = "Universidade";
            this.Universidade.ReadOnly = true;
            this.Universidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Universidade.Width = 233;
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.AllowUserToDeleteRows = false;
            this.dgvDepartamentos.AllowUserToResizeColumns = false;
            this.dgvDepartamentos.AllowUserToResizeRows = false;
            this.dgvDepartamentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDepartamentos.ColumnHeadersHeight = 30;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodDep,
            this.Departamento});
            this.tlpListagem.SetColumnSpan(this.dgvDepartamentos, 3);
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamentos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartamentos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDepartamentos.Location = new System.Drawing.Point(258, 93);
            this.dgvDepartamentos.MultiSelect = false;
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.ReadOnly = true;
            this.dgvDepartamentos.RowHeadersVisible = false;
            this.dgvDepartamentos.RowHeadersWidth = 30;
            this.dgvDepartamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tlpListagem.SetRowSpan(this.dgvDepartamentos, 3);
            this.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamentos.Size = new System.Drawing.Size(234, 408);
            this.dgvDepartamentos.TabIndex = 2;
            this.dgvDepartamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgvDepartamentos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            this.dgvDepartamentos.SelectionChanged += new System.EventHandler(this.dgvDepartamentos_SelectionChanged);
            // 
            // CodDep
            // 
            this.CodDep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodDep.Frozen = true;
            this.CodDep.HeaderText = "Codigo";
            this.CodDep.Name = "CodDep";
            this.CodDep.ReadOnly = true;
            this.CodDep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodDep.Visible = false;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Departamento.Frozen = true;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Departamento.Width = 233;
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.AllowUserToAddRows = false;
            this.dgvProfessores.AllowUserToDeleteRows = false;
            this.dgvProfessores.AllowUserToResizeColumns = false;
            this.dgvProfessores.AllowUserToResizeRows = false;
            this.dgvProfessores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProfessores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfessores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProfessores.ColumnHeadersHeight = 30;
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPro,
            this.Professor});
            this.tlpListagem.SetColumnSpan(this.dgvProfessores, 3);
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfessores.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProfessores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfessores.GridColor = System.Drawing.SystemColors.Control;
            this.dgvProfessores.Location = new System.Drawing.Point(513, 93);
            this.dgvProfessores.MultiSelect = false;
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.ReadOnly = true;
            this.dgvProfessores.RowHeadersVisible = false;
            this.dgvProfessores.RowHeadersWidth = 30;
            this.dgvProfessores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tlpListagem.SetRowSpan(this.dgvProfessores, 3);
            this.dgvProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessores.Size = new System.Drawing.Size(240, 408);
            this.dgvProfessores.TabIndex = 3;
            this.dgvProfessores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgvProfessores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            this.dgvProfessores.SelectionChanged += new System.EventHandler(this.dgvProfessores_SelectionChanged);
            // 
            // CodPro
            // 
            this.CodPro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CodPro.Frozen = true;
            this.CodPro.HeaderText = "Codigo";
            this.CodPro.Name = "CodPro";
            this.CodPro.ReadOnly = true;
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodPro.Visible = false;
            // 
            // Professor
            // 
            this.Professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Professor.Frozen = true;
            this.Professor.HeaderText = "Professor";
            this.Professor.Name = "Professor";
            this.Professor.ReadOnly = true;
            this.Professor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Professor.Width = 240;
            // 
            // lblQtdDepartamentos
            // 
            this.lblQtdDepartamentos.AutoSize = true;
            this.lblQtdDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdDepartamentos.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdDepartamentos.Location = new System.Drawing.Point(255, 504);
            this.lblQtdDepartamentos.Margin = new System.Windows.Forms.Padding(0);
            this.lblQtdDepartamentos.Name = "lblQtdDepartamentos";
            this.lblQtdDepartamentos.Size = new System.Drawing.Size(120, 29);
            this.lblQtdDepartamentos.TabIndex = 0;
            this.lblQtdDepartamentos.Text = "Quantidade:";
            this.lblQtdDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtdProfessores
            // 
            this.lblQtdProfessores.AutoSize = true;
            this.lblQtdProfessores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdProfessores.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdProfessores.Location = new System.Drawing.Point(510, 504);
            this.lblQtdProfessores.Margin = new System.Windows.Forms.Padding(0);
            this.lblQtdProfessores.Name = "lblQtdProfessores";
            this.lblQtdProfessores.Size = new System.Drawing.Size(120, 29);
            this.lblQtdProfessores.TabIndex = 0;
            this.lblQtdProfessores.Text = "Quantidade:";
            this.lblQtdProfessores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtdDepartamentosValor
            // 
            this.lblQtdDepartamentosValor.AutoSize = true;
            this.tlpListagem.SetColumnSpan(this.lblQtdDepartamentosValor, 2);
            this.lblQtdDepartamentosValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdDepartamentosValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdDepartamentosValor.Location = new System.Drawing.Point(378, 504);
            this.lblQtdDepartamentosValor.Name = "lblQtdDepartamentosValor";
            this.lblQtdDepartamentosValor.Size = new System.Drawing.Size(114, 29);
            this.lblQtdDepartamentosValor.TabIndex = 0;
            this.lblQtdDepartamentosValor.Text = "45 / 99";
            this.lblQtdDepartamentosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtdProfessoresValor
            // 
            this.lblQtdProfessoresValor.AutoSize = true;
            this.tlpListagem.SetColumnSpan(this.lblQtdProfessoresValor, 2);
            this.lblQtdProfessoresValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdProfessoresValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdProfessoresValor.Location = new System.Drawing.Point(633, 504);
            this.lblQtdProfessoresValor.Name = "lblQtdProfessoresValor";
            this.lblQtdProfessoresValor.Size = new System.Drawing.Size(120, 29);
            this.lblQtdProfessoresValor.TabIndex = 0;
            this.lblQtdProfessoresValor.Text = "45 / 99";
            this.lblQtdProfessoresValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbNovo
            // 
            this.tlpListagem.SetColumnSpan(this.gbNovo, 11);
            this.gbNovo.Controls.Add(this.tlpNovo);
            this.gbNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNovo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNovo.Location = new System.Drawing.Point(3, 0);
            this.gbNovo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbNovo.Name = "gbNovo";
            this.gbNovo.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbNovo.Size = new System.Drawing.Size(750, 87);
            this.gbNovo.TabIndex = 0;
            this.gbNovo.TabStop = false;
            this.gbNovo.Text = "Novo";
            // 
            // tlpNovo
            // 
            this.tlpNovo.ColumnCount = 5;
            this.tlpNovo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.00025F));
            this.tlpNovo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.49992F));
            this.tlpNovo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.49993F));
            this.tlpNovo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.99965F));
            this.tlpNovo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.00026F));
            this.tlpNovo.Controls.Add(this.rbProfessor, 3, 0);
            this.tlpNovo.Controls.Add(this.lblNome, 0, 1);
            this.tlpNovo.Controls.Add(this.btnSalvar, 4, 1);
            this.tlpNovo.Controls.Add(this.rbDepartamento, 2, 0);
            this.tlpNovo.Controls.Add(this.txtNome, 1, 1);
            this.tlpNovo.Controls.Add(this.rbUniversidade, 1, 0);
            this.tlpNovo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNovo.Location = new System.Drawing.Point(3, 23);
            this.tlpNovo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tlpNovo.Name = "tlpNovo";
            this.tlpNovo.RowCount = 2;
            this.tlpNovo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpNovo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpNovo.Size = new System.Drawing.Size(744, 61);
            this.tlpNovo.TabIndex = 0;
            // 
            // rbProfessor
            // 
            this.rbProfessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbProfessor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfessor.Location = new System.Drawing.Point(497, 0);
            this.rbProfessor.Margin = new System.Windows.Forms.Padding(0);
            this.rbProfessor.MinimumSize = new System.Drawing.Size(0, 25);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Size = new System.Drawing.Size(133, 25);
            this.rbProfessor.TabIndex = 3;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Professor";
            this.rbProfessor.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbProfessor.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(0, 21);
            this.lblNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(111, 40);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(633, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 32);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // rbDepartamento
            // 
            this.rbDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbDepartamento.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartamento.Location = new System.Drawing.Point(308, 0);
            this.rbDepartamento.Margin = new System.Windows.Forms.Padding(0);
            this.rbDepartamento.MinimumSize = new System.Drawing.Size(0, 25);
            this.rbDepartamento.Name = "rbDepartamento";
            this.rbDepartamento.Size = new System.Drawing.Size(189, 25);
            this.rbDepartamento.TabIndex = 2;
            this.rbDepartamento.TabStop = true;
            this.rbDepartamento.Text = "Departamento";
            this.rbDepartamento.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbDepartamento.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpNovo.SetColumnSpan(this.txtNome, 3);
            this.txtNome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(114, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(513, 32);
            this.txtNome.TabIndex = 4;
            // 
            // rbUniversidade
            // 
            this.rbUniversidade.Checked = true;
            this.rbUniversidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbUniversidade.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUniversidade.Location = new System.Drawing.Point(111, 0);
            this.rbUniversidade.Margin = new System.Windows.Forms.Padding(0);
            this.rbUniversidade.MinimumSize = new System.Drawing.Size(0, 25);
            this.rbUniversidade.Name = "rbUniversidade";
            this.rbUniversidade.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbUniversidade.Size = new System.Drawing.Size(197, 25);
            this.rbUniversidade.TabIndex = 1;
            this.rbUniversidade.TabStop = true;
            this.rbUniversidade.Text = "Universidade";
            this.rbUniversidade.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbUniversidade.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.tlpListagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.tlpListagem.ResumeLayout(false);
            this.tlpListagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.gbNovo.ResumeLayout(false);
            this.tlpNovo.ResumeLayout(false);
            this.tlpNovo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpListagem;
        private System.Windows.Forms.RadioButton rbDepartamento;
        private System.Windows.Forms.RadioButton rbUniversidade;
        private System.Windows.Forms.Label lblQtdDepartamentosValor;
        private System.Windows.Forms.Label lblQtdDepartamentos;
        private System.Windows.Forms.Label lblQtdProfessores;
        private System.Windows.Forms.Label lblQtdUniversidadesValor;
        private System.Windows.Forms.Label lblQtdUniversidades;
        private System.Windows.Forms.Label lblQtdProfessoresValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Universidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Professor;
        private System.Windows.Forms.GroupBox gbNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TableLayoutPanel tlpNovo;
        public System.Windows.Forms.DataGridView dgvUniversidades;
        public System.Windows.Forms.DataGridView dgvDepartamentos;
        public System.Windows.Forms.DataGridView dgvProfessores;
        private System.Windows.Forms.RadioButton rbProfessor;
    }
}


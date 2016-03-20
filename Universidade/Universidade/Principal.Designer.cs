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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.pnlRadioButtons = new System.Windows.Forms.Panel();
            this.rbProfessor = new System.Windows.Forms.RadioButton();
            this.rbDepartamento = new System.Windows.Forms.RadioButton();
            this.rbUniversidade = new System.Windows.Forms.RadioButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQtdDepartamentos = new System.Windows.Forms.Label();
            this.lblQtdProfessores = new System.Windows.Forms.Label();
            this.lblQtdDepartamentosValor = new System.Windows.Forms.Label();
            this.lblQtdProfessoresValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).BeginInit();
            this.pnlRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.lblQtdUniversidadesValor, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdUniversidades, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.dgvUniversidades, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDepartamentos, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvProfessores, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnlRadioButtons, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdDepartamentos, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdProfessores, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdDepartamentosValor, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdProfessoresValor, 9, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalvar, 9, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblQtdUniversidadesValor
            // 
            this.lblQtdUniversidadesValor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblQtdUniversidadesValor, 2);
            this.lblQtdUniversidadesValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdUniversidadesValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdUniversidadesValor.Location = new System.Drawing.Point(124, 508);
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
            this.lblQtdUniversidades.Location = new System.Drawing.Point(0, 508);
            this.lblQtdUniversidades.Margin = new System.Windows.Forms.Padding(0);
            this.lblQtdUniversidades.Name = "lblQtdUniversidades";
            this.lblQtdUniversidades.Size = new System.Drawing.Size(121, 29);
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
            this.dgvUniversidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUniversidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUniversidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUniversidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniversidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodUni,
            this.Universidade});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvUniversidades, 3);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUniversidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUniversidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUniversidades.Location = new System.Drawing.Point(3, 93);
            this.dgvUniversidades.MultiSelect = false;
            this.dgvUniversidades.Name = "dgvUniversidades";
            this.dgvUniversidades.ReadOnly = true;
            this.dgvUniversidades.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvUniversidades, 3);
            this.dgvUniversidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUniversidades.Size = new System.Drawing.Size(235, 412);
            this.dgvUniversidades.TabIndex = 7;
            this.dgvUniversidades.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            this.dgvUniversidades.SelectionChanged += new System.EventHandler(this.dgvUniversidades_SelectionChanged);
            // 
            // CodUni
            // 
            this.CodUni.HeaderText = "Codigo";
            this.CodUni.Name = "CodUni";
            this.CodUni.ReadOnly = true;
            this.CodUni.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodUni.Visible = false;
            // 
            // Universidade
            // 
            this.Universidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Universidade.HeaderText = "Universidade";
            this.Universidade.Name = "Universidade";
            this.Universidade.ReadOnly = true;
            this.Universidade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToAddRows = false;
            this.dgvDepartamentos.AllowUserToDeleteRows = false;
            this.dgvDepartamentos.AllowUserToResizeColumns = false;
            this.dgvDepartamentos.AllowUserToResizeRows = false;
            this.dgvDepartamentos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartamentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDepartamentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodDep,
            this.Departamento});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvDepartamentos, 3);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamentos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepartamentos.Location = new System.Drawing.Point(259, 93);
            this.dgvDepartamentos.MultiSelect = false;
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.ReadOnly = true;
            this.dgvDepartamentos.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvDepartamentos, 3);
            this.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamentos.Size = new System.Drawing.Size(235, 412);
            this.dgvDepartamentos.TabIndex = 8;
            this.dgvDepartamentos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            this.dgvDepartamentos.SelectionChanged += new System.EventHandler(this.dgvDepartamentos_SelectionChanged);
            // 
            // CodDep
            // 
            this.CodDep.HeaderText = "Codigo";
            this.CodDep.Name = "CodDep";
            this.CodDep.ReadOnly = true;
            this.CodDep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodDep.Visible = false;
            // 
            // Departamento
            // 
            this.Departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.ReadOnly = true;
            this.Departamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dgvProfessores
            // 
            this.dgvProfessores.AllowUserToAddRows = false;
            this.dgvProfessores.AllowUserToDeleteRows = false;
            this.dgvProfessores.AllowUserToResizeColumns = false;
            this.dgvProfessores.AllowUserToResizeRows = false;
            this.dgvProfessores.BackgroundColor = System.Drawing.Color.White;
            this.dgvProfessores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProfessores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfessores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProfessores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfessores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodPro,
            this.Professor});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvProfessores, 3);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProfessores.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProfessores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfessores.Location = new System.Drawing.Point(515, 93);
            this.dgvProfessores.MultiSelect = false;
            this.dgvProfessores.Name = "dgvProfessores";
            this.dgvProfessores.ReadOnly = true;
            this.dgvProfessores.RowHeadersVisible = false;
            this.tableLayoutPanel1.SetRowSpan(this.dgvProfessores, 3);
            this.dgvProfessores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProfessores.Size = new System.Drawing.Size(242, 412);
            this.dgvProfessores.TabIndex = 9;
            this.dgvProfessores.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
            this.dgvProfessores.SelectionChanged += new System.EventHandler(this.dgvProfessores_SelectionChanged);
            // 
            // CodPro
            // 
            this.CodPro.HeaderText = "Codigo";
            this.CodPro.Name = "CodPro";
            this.CodPro.ReadOnly = true;
            this.CodPro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodPro.Visible = false;
            // 
            // Professor
            // 
            this.Professor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Professor.HeaderText = "Professor";
            this.Professor.Name = "Professor";
            this.Professor.ReadOnly = true;
            this.Professor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pnlRadioButtons
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pnlRadioButtons, 8);
            this.pnlRadioButtons.Controls.Add(this.rbProfessor);
            this.pnlRadioButtons.Controls.Add(this.rbDepartamento);
            this.pnlRadioButtons.Controls.Add(this.rbUniversidade);
            this.pnlRadioButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRadioButtons.Location = new System.Drawing.Point(124, 3);
            this.pnlRadioButtons.Name = "pnlRadioButtons";
            this.pnlRadioButtons.Size = new System.Drawing.Size(506, 31);
            this.pnlRadioButtons.TabIndex = 1;
            this.pnlRadioButtons.TabStop = true;
            // 
            // rbProfessor
            // 
            this.rbProfessor.AutoSize = true;
            this.rbProfessor.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbProfessor.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfessor.Location = new System.Drawing.Point(372, 0);
            this.rbProfessor.Name = "rbProfessor";
            this.rbProfessor.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.rbProfessor.Size = new System.Drawing.Size(134, 31);
            this.rbProfessor.TabIndex = 4;
            this.rbProfessor.TabStop = true;
            this.rbProfessor.Text = "Professor";
            this.rbProfessor.UseVisualStyleBackColor = true;
            // 
            // rbDepartamento
            // 
            this.rbDepartamento.AutoSize = true;
            this.rbDepartamento.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDepartamento.Location = new System.Drawing.Point(186, 2);
            this.rbDepartamento.Name = "rbDepartamento";
            this.rbDepartamento.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.rbDepartamento.Size = new System.Drawing.Size(156, 26);
            this.rbDepartamento.TabIndex = 3;
            this.rbDepartamento.TabStop = true;
            this.rbDepartamento.Text = "Departamento";
            this.rbDepartamento.UseVisualStyleBackColor = true;
            // 
            // rbUniversidade
            // 
            this.rbUniversidade.AutoSize = true;
            this.rbUniversidade.Checked = true;
            this.rbUniversidade.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbUniversidade.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUniversidade.Location = new System.Drawing.Point(0, 0);
            this.rbUniversidade.Name = "rbUniversidade";
            this.rbUniversidade.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.rbUniversidade.Size = new System.Drawing.Size(156, 31);
            this.rbUniversidade.TabIndex = 2;
            this.rbUniversidade.TabStop = true;
            this.rbUniversidade.Text = "Universidade";
            this.rbUniversidade.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(3, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(115, 28);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQtdDepartamentos
            // 
            this.lblQtdDepartamentos.AutoSize = true;
            this.lblQtdDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdDepartamentos.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdDepartamentos.Location = new System.Drawing.Point(256, 508);
            this.lblQtdDepartamentos.Margin = new System.Windows.Forms.Padding(0);
            this.lblQtdDepartamentos.Name = "lblQtdDepartamentos";
            this.lblQtdDepartamentos.Size = new System.Drawing.Size(121, 29);
            this.lblQtdDepartamentos.TabIndex = 0;
            this.lblQtdDepartamentos.Text = "Quantidade:";
            this.lblQtdDepartamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtdProfessores
            // 
            this.lblQtdProfessores.AutoSize = true;
            this.lblQtdProfessores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdProfessores.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdProfessores.Location = new System.Drawing.Point(512, 508);
            this.lblQtdProfessores.Margin = new System.Windows.Forms.Padding(0);
            this.lblQtdProfessores.Name = "lblQtdProfessores";
            this.lblQtdProfessores.Size = new System.Drawing.Size(121, 29);
            this.lblQtdProfessores.TabIndex = 0;
            this.lblQtdProfessores.Text = "Quantidade:";
            this.lblQtdProfessores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtdDepartamentosValor
            // 
            this.lblQtdDepartamentosValor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblQtdDepartamentosValor, 2);
            this.lblQtdDepartamentosValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdDepartamentosValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdDepartamentosValor.Location = new System.Drawing.Point(380, 508);
            this.lblQtdDepartamentosValor.Name = "lblQtdDepartamentosValor";
            this.lblQtdDepartamentosValor.Size = new System.Drawing.Size(114, 29);
            this.lblQtdDepartamentosValor.TabIndex = 0;
            this.lblQtdDepartamentosValor.Text = "45 / 99";
            this.lblQtdDepartamentosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtdProfessoresValor
            // 
            this.lblQtdProfessoresValor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblQtdProfessoresValor, 2);
            this.lblQtdProfessoresValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdProfessoresValor.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdProfessoresValor.Location = new System.Drawing.Point(636, 508);
            this.lblQtdProfessoresValor.Name = "lblQtdProfessoresValor";
            this.lblQtdProfessoresValor.Size = new System.Drawing.Size(121, 29);
            this.lblQtdProfessoresValor.TabIndex = 0;
            this.lblQtdProfessoresValor.Text = "45 / 99";
            this.lblQtdProfessoresValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtNome, 8);
            this.txtNome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(124, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(506, 32);
            this.txtNome.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.btnSalvar, 2);
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(643, 46);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(107, 34);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniversidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfessores)).EndInit();
            this.pnlRadioButtons.ResumeLayout(false);
            this.pnlRadioButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvUniversidades;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.DataGridView dgvProfessores;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pnlRadioButtons;
        private System.Windows.Forms.RadioButton rbProfessor;
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
    }
}


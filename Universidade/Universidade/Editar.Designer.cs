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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblQtdNaoVinculados = new System.Windows.Forms.Label();
            this.lblVinculados = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvVinculados = new System.Windows.Forms.DataGridView();
            this.dgvNaoVinculados = new System.Windows.Forms.DataGridView();
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnDesvincular = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblNaoVinculados = new System.Windows.Forms.Label();
            this.lblQtdVinculados = new System.Windows.Forms.Label();
            this.lblQtdVinculadosValor = new System.Windows.Forms.Label();
            this.lblQtdNaoVinculadosValor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoVinculados)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Controls.Add(this.lblQtdNaoVinculados, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblVinculados, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSalvar, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvVinculados, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvNaoVinculados, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnVincular, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDesvincular, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTitulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNome, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditar, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblNaoVinculados, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdVinculados, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdVinculadosValor, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblQtdNaoVinculadosValor, 5, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 432);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblQtdNaoVinculados
            // 
            this.lblQtdNaoVinculados.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblQtdNaoVinculados, 2);
            this.lblQtdNaoVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdNaoVinculados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdNaoVinculados.Location = new System.Drawing.Point(301, 400);
            this.lblQtdNaoVinculados.Name = "lblQtdNaoVinculados";
            this.lblQtdNaoVinculados.Size = new System.Drawing.Size(148, 32);
            this.lblQtdNaoVinculados.TabIndex = 11;
            this.lblQtdNaoVinculados.Text = "Quantidade:";
            this.lblQtdNaoVinculados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVinculados
            // 
            this.lblVinculados.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblVinculados, 2);
            this.lblVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVinculados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVinculados.Location = new System.Drawing.Point(3, 85);
            this.lblVinculados.Name = "lblVinculados";
            this.lblVinculados.Size = new System.Drawing.Size(248, 43);
            this.lblVinculados.TabIndex = 9;
            this.lblVinculados.Text = "Departamentos vinculados:";
            this.lblVinculados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSalvar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnSalvar, 2);
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(406, 50);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 32);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // dgvVinculados
            // 
            this.dgvVinculados.AllowUserToAddRows = false;
            this.dgvVinculados.AllowUserToDeleteRows = false;
            this.dgvVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvVinculados, 2);
            this.dgvVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVinculados.Location = new System.Drawing.Point(3, 131);
            this.dgvVinculados.Name = "dgvVinculados";
            this.dgvVinculados.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvVinculados, 2);
            this.dgvVinculados.Size = new System.Drawing.Size(248, 266);
            this.dgvVinculados.TabIndex = 0;
            // 
            // dgvNaoVinculados
            // 
            this.dgvNaoVinculados.AllowUserToAddRows = false;
            this.dgvNaoVinculados.AllowUserToDeleteRows = false;
            this.dgvNaoVinculados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvNaoVinculados, 3);
            this.dgvNaoVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNaoVinculados.Location = new System.Drawing.Point(301, 131);
            this.dgvNaoVinculados.Name = "dgvNaoVinculados";
            this.dgvNaoVinculados.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvNaoVinculados, 2);
            this.dgvNaoVinculados.Size = new System.Drawing.Size(251, 266);
            this.dgvNaoVinculados.TabIndex = 1;
            // 
            // btnVincular
            // 
            this.btnVincular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVincular.AutoSize = true;
            this.btnVincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVincular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVincular.Location = new System.Drawing.Point(257, 230);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(38, 31);
            this.btnVincular.TabIndex = 2;
            this.btnVincular.Text = "<<";
            this.btnVincular.UseVisualStyleBackColor = false;
            // 
            // btnDesvincular
            // 
            this.btnDesvincular.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesvincular.AutoSize = true;
            this.btnDesvincular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesvincular.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesvincular.Location = new System.Drawing.Point(257, 267);
            this.btnDesvincular.Name = "btnDesvincular";
            this.btnDesvincular.Size = new System.Drawing.Size(38, 31);
            this.btnDesvincular.TabIndex = 3;
            this.btnDesvincular.Text = ">>";
            this.btnDesvincular.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitulo, 2);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(248, 47);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Universidade:";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtNome, 4);
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(257, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(295, 32);
            this.txtNome.TabIndex = 5;
            // 
            // btnEditar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnEditar, 2);
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(257, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(143, 32);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblNaoVinculados
            // 
            this.lblNaoVinculados.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblNaoVinculados, 3);
            this.lblNaoVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNaoVinculados.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaoVinculados.Location = new System.Drawing.Point(301, 85);
            this.lblNaoVinculados.Name = "lblNaoVinculados";
            this.lblNaoVinculados.Size = new System.Drawing.Size(251, 43);
            this.lblNaoVinculados.TabIndex = 8;
            this.lblNaoVinculados.Text = "Departamentos não vinculados:";
            this.lblNaoVinculados.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblQtdVinculados
            // 
            this.lblQtdVinculados.AutoSize = true;
            this.lblQtdVinculados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdVinculados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVinculados.Location = new System.Drawing.Point(3, 400);
            this.lblQtdVinculados.Name = "lblQtdVinculados";
            this.lblQtdVinculados.Size = new System.Drawing.Size(149, 32);
            this.lblQtdVinculados.TabIndex = 10;
            this.lblQtdVinculados.Text = "Quantidade:";
            this.lblQtdVinculados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQtdVinculadosValor
            // 
            this.lblQtdVinculadosValor.AutoSize = true;
            this.lblQtdVinculadosValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdVinculadosValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdVinculadosValor.Location = new System.Drawing.Point(158, 400);
            this.lblQtdVinculadosValor.Name = "lblQtdVinculadosValor";
            this.lblQtdVinculadosValor.Size = new System.Drawing.Size(93, 32);
            this.lblQtdVinculadosValor.TabIndex = 12;
            this.lblQtdVinculadosValor.Text = "8 / 10";
            this.lblQtdVinculadosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtdNaoVinculadosValor
            // 
            this.lblQtdNaoVinculadosValor.AutoSize = true;
            this.lblQtdNaoVinculadosValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtdNaoVinculadosValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdNaoVinculadosValor.Location = new System.Drawing.Point(455, 400);
            this.lblQtdNaoVinculadosValor.Name = "lblQtdNaoVinculadosValor";
            this.lblQtdNaoVinculadosValor.Size = new System.Drawing.Size(97, 32);
            this.lblQtdNaoVinculadosValor.TabIndex = 13;
            this.lblQtdNaoVinculadosValor.Text = "8 / 10";
            this.lblQtdNaoVinculadosValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Editar";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVinculados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoVinculados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvVinculados;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvNaoVinculados;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnDesvincular;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblVinculados;
        private System.Windows.Forms.Label lblNaoVinculados;
        private System.Windows.Forms.Label lblQtdVinculados;
        private System.Windows.Forms.Label lblQtdNaoVinculados;
        private System.Windows.Forms.Label lblQtdVinculadosValor;
        private System.Windows.Forms.Label lblQtdNaoVinculadosValor;
    }
}
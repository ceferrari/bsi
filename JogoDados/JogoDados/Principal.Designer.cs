namespace JogoDados
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblJogador1 = new System.Windows.Forms.Label();
            this.lblJogador2 = new System.Windows.Forms.Label();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.lblDado2 = new System.Windows.Forms.Label();
            this.btnJogarDado1 = new System.Windows.Forms.Button();
            this.btnJogarDado2 = new System.Windows.Forms.Button();
            this.lblPlacar = new System.Windows.Forms.Label();
            this.lblPlacarJogador1 = new System.Windows.Forms.Label();
            this.lblPlacarJogador2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblJogador1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblJogador2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDado1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDado2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnJogarDado1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnJogarDado2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPlacar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPlacarJogador1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPlacarJogador2, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 537);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblJogador1
            // 
            this.lblJogador1.AutoSize = true;
            this.lblJogador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador1.Location = new System.Drawing.Point(4, 1);
            this.lblJogador1.Name = "lblJogador1";
            this.lblJogador1.Size = new System.Drawing.Size(222, 55);
            this.lblJogador1.TabIndex = 0;
            this.lblJogador1.Text = "Jogador 1";
            this.lblJogador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblJogador2
            // 
            this.lblJogador2.AutoSize = true;
            this.lblJogador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogador2.Location = new System.Drawing.Point(233, 1);
            this.lblJogador2.Name = "lblJogador2";
            this.lblJogador2.Size = new System.Drawing.Size(223, 55);
            this.lblJogador2.TabIndex = 1;
            this.lblJogador2.Text = "Jogador 2";
            this.lblJogador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDado1
            // 
            this.lblDado1.AutoSize = true;
            this.lblDado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado1.Location = new System.Drawing.Point(4, 57);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(222, 175);
            this.lblDado1.TabIndex = 2;
            this.lblDado1.Text = "0";
            this.lblDado1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDado2
            // 
            this.lblDado2.AutoSize = true;
            this.lblDado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado2.Location = new System.Drawing.Point(233, 57);
            this.lblDado2.Name = "lblDado2";
            this.lblDado2.Size = new System.Drawing.Size(223, 175);
            this.lblDado2.TabIndex = 3;
            this.lblDado2.Text = "0";
            this.lblDado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogarDado1
            // 
            this.btnJogarDado1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJogarDado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarDado1.Location = new System.Drawing.Point(4, 236);
            this.btnJogarDado1.Name = "btnJogarDado1";
            this.btnJogarDado1.Size = new System.Drawing.Size(222, 49);
            this.btnJogarDado1.TabIndex = 4;
            this.btnJogarDado1.Text = "Jogar Dado";
            this.btnJogarDado1.UseVisualStyleBackColor = true;
            this.btnJogarDado1.Click += new System.EventHandler(this.btnJogarDado1_Click);
            // 
            // btnJogarDado2
            // 
            this.btnJogarDado2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJogarDado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogarDado2.Location = new System.Drawing.Point(233, 236);
            this.btnJogarDado2.Name = "btnJogarDado2";
            this.btnJogarDado2.Size = new System.Drawing.Size(223, 49);
            this.btnJogarDado2.TabIndex = 5;
            this.btnJogarDado2.Text = "Jogar Dado";
            this.btnJogarDado2.UseVisualStyleBackColor = true;
            this.btnJogarDado2.Click += new System.EventHandler(this.btnJogarDado2_Click);
            // 
            // lblPlacar
            // 
            this.lblPlacar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlacar.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPlacar, 2);
            this.lblPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlacar.Location = new System.Drawing.Point(4, 289);
            this.lblPlacar.Name = "lblPlacar";
            this.lblPlacar.Size = new System.Drawing.Size(452, 55);
            this.lblPlacar.TabIndex = 6;
            this.lblPlacar.Text = "Placar:";
            this.lblPlacar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacarJogador1
            // 
            this.lblPlacarJogador1.AutoSize = true;
            this.lblPlacarJogador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlacarJogador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarJogador1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlacarJogador1.Location = new System.Drawing.Point(4, 345);
            this.lblPlacarJogador1.Name = "lblPlacarJogador1";
            this.lblPlacarJogador1.Size = new System.Drawing.Size(222, 191);
            this.lblPlacarJogador1.TabIndex = 7;
            this.lblPlacarJogador1.Text = "0";
            this.lblPlacarJogador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlacarJogador2
            // 
            this.lblPlacarJogador2.AutoSize = true;
            this.lblPlacarJogador2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlacarJogador2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacarJogador2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblPlacarJogador2.Location = new System.Drawing.Point(233, 345);
            this.lblPlacarJogador2.Name = "lblPlacarJogador2";
            this.lblPlacarJogador2.Size = new System.Drawing.Size(223, 191);
            this.lblPlacarJogador2.TabIndex = 8;
            this.lblPlacarJogador2.Text = "0";
            this.lblPlacarJogador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Jogo de Dados";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblJogador1;
        private System.Windows.Forms.Label lblJogador2;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label lblDado2;
        private System.Windows.Forms.Button btnJogarDado1;
        private System.Windows.Forms.Button btnJogarDado2;
        private System.Windows.Forms.Label lblPlacar;
        private System.Windows.Forms.Label lblPlacarJogador1;
        private System.Windows.Forms.Label lblPlacarJogador2;
    }
}


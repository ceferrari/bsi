namespace Banco
{
    partial class Transferencia
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
            this.lblValor = new System.Windows.Forms.Label();
            this.cboxTitular = new System.Windows.Forms.ComboBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbContaCorrente = new System.Windows.Forms.RadioButton();
            this.rbContaPoupanca = new System.Windows.Forms.RadioButton();
            this.lblValorSaldoContaCorrente = new System.Windows.Forms.Label();
            this.lblValorSaldoContaPoupanca = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaldoContaCorrente = new System.Windows.Forms.Label();
            this.lblSaldoContaPoupanca = new System.Windows.Forms.Label();
            this.btnEfetivarTransferencia = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.lblValor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboxTitular, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTitular, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mskValor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblValorSaldoContaCorrente, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblValorSaldoContaPoupanca, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblSaldo, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSaldoContaCorrente, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSaldoContaPoupanca, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnEfetivarTransferencia, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(385, 283);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblValor
            // 
            this.lblValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValor.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblValor, 2);
            this.lblValor.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(3, 45);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(122, 45);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor:";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboxTitular
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboxTitular, 4);
            this.cboxTitular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTitular.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxTitular.FormattingEnabled = true;
            this.cboxTitular.Location = new System.Drawing.Point(131, 3);
            this.cboxTitular.Name = "cboxTitular";
            this.cboxTitular.Size = new System.Drawing.Size(251, 36);
            this.cboxTitular.TabIndex = 1;
            this.cboxTitular.SelectedIndexChanged += new System.EventHandler(this.cboxTitular_SelectedIndexChanged);
            // 
            // lblTitular
            // 
            this.lblTitular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitular.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTitular, 2);
            this.lblTitular.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitular.Location = new System.Drawing.Point(3, 0);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(122, 45);
            this.lblTitular.TabIndex = 0;
            this.lblTitular.Text = "Titular:";
            this.lblTitular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mskValor
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.mskValor, 4);
            this.mskValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskValor.Enabled = false;
            this.mskValor.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValor.Location = new System.Drawing.Point(131, 48);
            this.mskValor.Mask = "$ 999,990.00";
            this.mskValor.Name = "mskValor";
            this.mskValor.Size = new System.Drawing.Size(251, 36);
            this.mskValor.TabIndex = 2;
            this.mskValor.Text = "00000000";
            this.mskValor.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.rbContaCorrente);
            this.panel1.Controls.Add(this.rbContaPoupanca);
            this.panel1.Location = new System.Drawing.Point(3, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 39);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // rbContaCorrente
            // 
            this.rbContaCorrente.AutoSize = true;
            this.rbContaCorrente.Checked = true;
            this.rbContaCorrente.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbContaCorrente.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContaCorrente.Location = new System.Drawing.Point(0, 0);
            this.rbContaCorrente.Name = "rbContaCorrente";
            this.rbContaCorrente.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.rbContaCorrente.Size = new System.Drawing.Size(183, 39);
            this.rbContaCorrente.TabIndex = 0;
            this.rbContaCorrente.TabStop = true;
            this.rbContaCorrente.Text = "Conta Corrente";
            this.rbContaCorrente.UseVisualStyleBackColor = true;
            this.rbContaCorrente.CheckedChanged += new System.EventHandler(this.rbContaCorrente_CheckedChanged);
            // 
            // rbContaPoupanca
            // 
            this.rbContaPoupanca.AutoSize = true;
            this.rbContaPoupanca.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbContaPoupanca.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbContaPoupanca.Location = new System.Drawing.Point(196, 0);
            this.rbContaPoupanca.Name = "rbContaPoupanca";
            this.rbContaPoupanca.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.rbContaPoupanca.Size = new System.Drawing.Size(183, 39);
            this.rbContaPoupanca.TabIndex = 0;
            this.rbContaPoupanca.TabStop = true;
            this.rbContaPoupanca.Text = "Conta Poupança";
            this.rbContaPoupanca.UseVisualStyleBackColor = true;
            this.rbContaPoupanca.CheckedChanged += new System.EventHandler(this.rbContaPoupanca_CheckedChanged);
            // 
            // lblValorSaldoContaCorrente
            // 
            this.lblValorSaldoContaCorrente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorSaldoContaCorrente.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblValorSaldoContaCorrente, 2);
            this.lblValorSaldoContaCorrente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaldoContaCorrente.Location = new System.Drawing.Point(259, 225);
            this.lblValorSaldoContaCorrente.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblValorSaldoContaCorrente.Name = "lblValorSaldoContaCorrente";
            this.lblValorSaldoContaCorrente.Size = new System.Drawing.Size(126, 30);
            this.lblValorSaldoContaCorrente.TabIndex = 0;
            this.lblValorSaldoContaCorrente.Text = "R$ 12.345,99";
            this.lblValorSaldoContaCorrente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValorSaldoContaPoupanca
            // 
            this.lblValorSaldoContaPoupanca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorSaldoContaPoupanca.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblValorSaldoContaPoupanca, 2);
            this.lblValorSaldoContaPoupanca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorSaldoContaPoupanca.Location = new System.Drawing.Point(259, 255);
            this.lblValorSaldoContaPoupanca.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblValorSaldoContaPoupanca.Name = "lblValorSaldoContaPoupanca";
            this.lblValorSaldoContaPoupanca.Size = new System.Drawing.Size(126, 30);
            this.lblValorSaldoContaPoupanca.TabIndex = 0;
            this.lblValorSaldoContaPoupanca.Text = "R$ 12.345,99";
            this.lblValorSaldoContaPoupanca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaldo
            // 
            this.lblSaldo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSaldo, 2);
            this.lblSaldo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(195, 180);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(122, 45);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Saldo";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblSaldoContaCorrente
            // 
            this.lblSaldoContaCorrente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoContaCorrente.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSaldoContaCorrente, 3);
            this.lblSaldoContaCorrente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoContaCorrente.Location = new System.Drawing.Point(67, 225);
            this.lblSaldoContaCorrente.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblSaldoContaCorrente.Name = "lblSaldoContaCorrente";
            this.lblSaldoContaCorrente.Size = new System.Drawing.Size(189, 30);
            this.lblSaldoContaCorrente.TabIndex = 0;
            this.lblSaldoContaCorrente.Text = "Conta Corrente:";
            this.lblSaldoContaCorrente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSaldoContaPoupanca
            // 
            this.lblSaldoContaPoupanca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaldoContaPoupanca.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblSaldoContaPoupanca, 3);
            this.lblSaldoContaPoupanca.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoContaPoupanca.Location = new System.Drawing.Point(67, 255);
            this.lblSaldoContaPoupanca.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblSaldoContaPoupanca.Name = "lblSaldoContaPoupanca";
            this.lblSaldoContaPoupanca.Size = new System.Drawing.Size(189, 30);
            this.lblSaldoContaPoupanca.TabIndex = 0;
            this.lblSaldoContaPoupanca.Text = "Conta Poupança:";
            this.lblSaldoContaPoupanca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEfetivarTransferencia
            // 
            this.btnEfetivarTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnEfetivarTransferencia, 6);
            this.btnEfetivarTransferencia.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfetivarTransferencia.Location = new System.Drawing.Point(3, 138);
            this.btnEfetivarTransferencia.Name = "btnEfetivarTransferencia";
            this.btnEfetivarTransferencia.Size = new System.Drawing.Size(379, 39);
            this.btnEfetivarTransferencia.TabIndex = 5;
            this.btnEfetivarTransferencia.Text = "Efetivar Transferência";
            this.btnEfetivarTransferencia.UseVisualStyleBackColor = true;
            this.btnEfetivarTransferencia.Click += new System.EventHandler(this.btnEfetivarTransferencia_Click);
            // 
            // Transferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "Transferencia";
            this.ShowIcon = false;
            this.Text = "Transferência";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transferencia_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cboxTitular;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Button btnEfetivarTransferencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbContaCorrente;
        private System.Windows.Forms.RadioButton rbContaPoupanca;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaldoContaCorrente;
        private System.Windows.Forms.Label lblSaldoContaPoupanca;
        private System.Windows.Forms.Label lblValorSaldoContaCorrente;
        private System.Windows.Forms.Label lblValorSaldoContaPoupanca;
    }
}


namespace Database_Books.Forms
{
    partial class RelatorioFinanceiro
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
            this.GridViewRelatorioFinanceiro = new System.Windows.Forms.DataGridView();
            this.ValorLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCabecalho = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRelatorioFinanceiro)).BeginInit();
            this.panelCabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewRelatorioFinanceiro
            // 
            this.GridViewRelatorioFinanceiro.AllowUserToAddRows = false;
            this.GridViewRelatorioFinanceiro.AllowUserToDeleteRows = false;
            this.GridViewRelatorioFinanceiro.AllowUserToOrderColumns = true;
            this.GridViewRelatorioFinanceiro.AllowUserToResizeColumns = false;
            this.GridViewRelatorioFinanceiro.AllowUserToResizeRows = false;
            this.GridViewRelatorioFinanceiro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewRelatorioFinanceiro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewRelatorioFinanceiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRelatorioFinanceiro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ValorLivro,
            this.ValorEmprestimo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewRelatorioFinanceiro.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewRelatorioFinanceiro.Location = new System.Drawing.Point(12, 267);
            this.GridViewRelatorioFinanceiro.MultiSelect = false;
            this.GridViewRelatorioFinanceiro.Name = "GridViewRelatorioFinanceiro";
            this.GridViewRelatorioFinanceiro.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewRelatorioFinanceiro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewRelatorioFinanceiro.RowTemplate.Height = 30;
            this.GridViewRelatorioFinanceiro.Size = new System.Drawing.Size(1240, 402);
            this.GridViewRelatorioFinanceiro.TabIndex = 1;
            // 
            // ValorLivro
            // 
            this.ValorLivro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorLivro.HeaderText = "Valor do livro";
            this.ValorLivro.Name = "ValorLivro";
            this.ValorLivro.ReadOnly = true;
            this.ValorLivro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ValorEmprestimo
            // 
            this.ValorEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ValorEmprestimo.HeaderText = "Valor do Empréstimo";
            this.ValorEmprestimo.Name = "ValorEmprestimo";
            this.ValorEmprestimo.ReadOnly = true;
            // 
            // panelCabecalho
            // 
            this.panelCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCabecalho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCabecalho.Controls.Add(this.label1);
            this.panelCabecalho.Location = new System.Drawing.Point(13, 102);
            this.panelCabecalho.Name = "panelCabecalho";
            this.panelCabecalho.Size = new System.Drawing.Size(1239, 159);
            this.panelCabecalho.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(459, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações teste para relatório";
            // 
            // btnSalvarPDF
            // 
            this.btnSalvarPDF.Location = new System.Drawing.Point(13, 13);
            this.btnSalvarPDF.Name = "btnSalvarPDF";
            this.btnSalvarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPDF.TabIndex = 3;
            this.btnSalvarPDF.Text = "Salvar PDF";
            this.btnSalvarPDF.UseVisualStyleBackColor = true;
            this.btnSalvarPDF.Click += new System.EventHandler(this.btnSalvarPDF_Click);
            // 
            // RelatorioFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSalvarPDF);
            this.Controls.Add(this.panelCabecalho);
            this.Controls.Add(this.GridViewRelatorioFinanceiro);
            this.Name = "RelatorioFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioFinanceiro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioFinanceiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRelatorioFinanceiro)).EndInit();
            this.panelCabecalho.ResumeLayout(false);
            this.panelCabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewRelatorioFinanceiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorEmprestimo;
        private System.Windows.Forms.Panel panelCabecalho;
        private System.Windows.Forms.Button btnSalvarPDF;
        private System.Windows.Forms.Label label1;
    }
}
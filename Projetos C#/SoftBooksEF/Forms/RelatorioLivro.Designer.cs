namespace Database_Books.Forms
{
    partial class RelatorioLivro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridViewRelatorioLivro = new System.Windows.Forms.DataGridView();
            this.NomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PessoaEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicioLeitura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFimLeitura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvarPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRelatorioLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewRelatorioLivro
            // 
            this.GridViewRelatorioLivro.AllowUserToAddRows = false;
            this.GridViewRelatorioLivro.AllowUserToDeleteRows = false;
            this.GridViewRelatorioLivro.AllowUserToOrderColumns = true;
            this.GridViewRelatorioLivro.AllowUserToResizeColumns = false;
            this.GridViewRelatorioLivro.AllowUserToResizeRows = false;
            this.GridViewRelatorioLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewRelatorioLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewRelatorioLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewRelatorioLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeLivro,
            this.Genero,
            this.Formato,
            this.Autor,
            this.Status,
            this.UsuarioLeitor,
            this.PessoaEmprestimo,
            this.DataInicioLeitura,
            this.DataFimLeitura,
            this.DataEmprestimo,
            this.DataDevolucao});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewRelatorioLivro.DefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewRelatorioLivro.Location = new System.Drawing.Point(12, 215);
            this.GridViewRelatorioLivro.MultiSelect = false;
            this.GridViewRelatorioLivro.Name = "GridViewRelatorioLivro";
            this.GridViewRelatorioLivro.ReadOnly = true;
            this.GridViewRelatorioLivro.RowTemplate.Height = 30;
            this.GridViewRelatorioLivro.Size = new System.Drawing.Size(1240, 454);
            this.GridViewRelatorioLivro.TabIndex = 1;
            // 
            // NomeLivro
            // 
            this.NomeLivro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeLivro.HeaderText = "Nome do livro";
            this.NomeLivro.Name = "NomeLivro";
            this.NomeLivro.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Genero.HeaderText = "Gênero do livro";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Formato
            // 
            this.Formato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Formato.HeaderText = "Formato";
            this.Formato.Name = "Formato";
            this.Formato.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.HeaderText = "Autor do livro";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status da leitura";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // UsuarioLeitor
            // 
            this.UsuarioLeitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsuarioLeitor.HeaderText = "Leitor";
            this.UsuarioLeitor.Name = "UsuarioLeitor";
            this.UsuarioLeitor.ReadOnly = true;
            // 
            // PessoaEmprestimo
            // 
            this.PessoaEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PessoaEmprestimo.HeaderText = "Livro emprestado para";
            this.PessoaEmprestimo.Name = "PessoaEmprestimo";
            this.PessoaEmprestimo.ReadOnly = true;
            this.PessoaEmprestimo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PessoaEmprestimo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataInicioLeitura
            // 
            this.DataInicioLeitura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataInicioLeitura.HeaderText = "Data de início da leitura";
            this.DataInicioLeitura.Name = "DataInicioLeitura";
            this.DataInicioLeitura.ReadOnly = true;
            // 
            // DataFimLeitura
            // 
            this.DataFimLeitura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataFimLeitura.HeaderText = "Data final da leitura";
            this.DataFimLeitura.Name = "DataFimLeitura";
            this.DataFimLeitura.ReadOnly = true;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataEmprestimo.HeaderText = "Data de empréstimo";
            this.DataEmprestimo.Name = "DataEmprestimo";
            this.DataEmprestimo.ReadOnly = true;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataDevolucao.HeaderText = "Data de devolução";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.ReadOnly = true;
            // 
            // btnSalvarPDF
            // 
            this.btnSalvarPDF.Location = new System.Drawing.Point(12, 12);
            this.btnSalvarPDF.Name = "btnSalvarPDF";
            this.btnSalvarPDF.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPDF.TabIndex = 5;
            this.btnSalvarPDF.Text = "Salvar PDF";
            this.btnSalvarPDF.UseVisualStyleBackColor = true;
            this.btnSalvarPDF.Click += new System.EventHandler(this.btnSalvarPDF_Click);
            // 
            // RelatorioLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnSalvarPDF);
            this.Controls.Add(this.GridViewRelatorioLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RelatorioLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioLivro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewRelatorioLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewRelatorioLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicioLeitura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFimLeitura;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
        private System.Windows.Forms.Button btnSalvarPDF;
    }
}
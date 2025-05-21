namespace Database_Books
{
    partial class TelaInicial
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOlaUser = new System.Windows.Forms.Label();
            this.GridViewInfoLeitura = new System.Windows.Forms.DataGridView();
            this.livrogrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicioLeitura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLivrosLendo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridViewInfoEmprestimo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDevolucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInfoLeitura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInfoEmprestimo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblOlaUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 94);
            this.panel1.TabIndex = 2;
            // 
            // lblOlaUser
            // 
            this.lblOlaUser.AutoSize = true;
            this.lblOlaUser.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlaUser.Location = new System.Drawing.Point(20, 23);
            this.lblOlaUser.Margin = new System.Windows.Forms.Padding(20);
            this.lblOlaUser.Name = "lblOlaUser";
            this.lblOlaUser.Size = new System.Drawing.Size(335, 30);
            this.lblOlaUser.TabIndex = 0;
            this.lblOlaUser.Text = "Olá Usuário, o que vamos ler hoje?";
            // 
            // GridViewInfoLeitura
            // 
            this.GridViewInfoLeitura.AllowUserToAddRows = false;
            this.GridViewInfoLeitura.AllowUserToDeleteRows = false;
            this.GridViewInfoLeitura.AllowUserToResizeColumns = false;
            this.GridViewInfoLeitura.AllowUserToResizeRows = false;
            this.GridViewInfoLeitura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewInfoLeitura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewInfoLeitura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewInfoLeitura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewInfoLeitura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewInfoLeitura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewInfoLeitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewInfoLeitura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.livrogrid,
            this.DataInicioLeitura,
            this.Leitor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewInfoLeitura.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewInfoLeitura.Location = new System.Drawing.Point(26, 146);
            this.GridViewInfoLeitura.Margin = new System.Windows.Forms.Padding(60);
            this.GridViewInfoLeitura.MultiSelect = false;
            this.GridViewInfoLeitura.Name = "GridViewInfoLeitura";
            this.GridViewInfoLeitura.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewInfoLeitura.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridViewInfoLeitura.RowHeadersWidth = 51;
            this.GridViewInfoLeitura.RowTemplate.Height = 30;
            this.GridViewInfoLeitura.Size = new System.Drawing.Size(800, 200);
            this.GridViewInfoLeitura.TabIndex = 3;
            // 
            // livrogrid
            // 
            this.livrogrid.HeaderText = "Livro";
            this.livrogrid.MinimumWidth = 6;
            this.livrogrid.Name = "livrogrid";
            this.livrogrid.ReadOnly = true;
            // 
            // DataInicioLeitura
            // 
            this.DataInicioLeitura.HeaderText = "Início da leitura";
            this.DataInicioLeitura.MinimumWidth = 6;
            this.DataInicioLeitura.Name = "DataInicioLeitura";
            this.DataInicioLeitura.ReadOnly = true;
            // 
            // Leitor
            // 
            this.Leitor.HeaderText = "Leitor(a)";
            this.Leitor.Name = "Leitor";
            this.Leitor.ReadOnly = true;
            // 
            // lblLivrosLendo
            // 
            this.lblLivrosLendo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLivrosLendo.AutoSize = true;
            this.lblLivrosLendo.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivrosLendo.Location = new System.Drawing.Point(215, 102);
            this.lblLivrosLendo.Margin = new System.Windows.Forms.Padding(2);
            this.lblLivrosLendo.Name = "lblLivrosLendo";
            this.lblLivrosLendo.Size = new System.Drawing.Size(165, 30);
            this.lblLivrosLendo.TabIndex = 5;
            this.lblLivrosLendo.Text = "Livros em leitura";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Livros em empréstimo";
            // 
            // GridViewInfoEmprestimo
            // 
            this.GridViewInfoEmprestimo.AllowUserToAddRows = false;
            this.GridViewInfoEmprestimo.AllowUserToDeleteRows = false;
            this.GridViewInfoEmprestimo.AllowUserToResizeColumns = false;
            this.GridViewInfoEmprestimo.AllowUserToResizeRows = false;
            this.GridViewInfoEmprestimo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewInfoEmprestimo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridViewInfoEmprestimo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GridViewInfoEmprestimo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridViewInfoEmprestimo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewInfoEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewInfoEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewInfoEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DataEmprestimo,
            this.DataDevolucao,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewInfoEmprestimo.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridViewInfoEmprestimo.Location = new System.Drawing.Point(26, 414);
            this.GridViewInfoEmprestimo.Margin = new System.Windows.Forms.Padding(60);
            this.GridViewInfoEmprestimo.MultiSelect = false;
            this.GridViewInfoEmprestimo.Name = "GridViewInfoEmprestimo";
            this.GridViewInfoEmprestimo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewInfoEmprestimo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridViewInfoEmprestimo.RowHeadersWidth = 51;
            this.GridViewInfoEmprestimo.RowTemplate.Height = 30;
            this.GridViewInfoEmprestimo.Size = new System.Drawing.Size(800, 200);
            this.GridViewInfoEmprestimo.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Livro";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.HeaderText = "Data empréstimo";
            this.DataEmprestimo.MinimumWidth = 6;
            this.DataEmprestimo.Name = "DataEmprestimo";
            this.DataEmprestimo.ReadOnly = true;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.HeaderText = "Data de devolução";
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Leitor(a)";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // TelaInicial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridViewInfoEmprestimo);
            this.Controls.Add(this.lblLivrosLendo);
            this.Controls.Add(this.GridViewInfoLeitura);
            this.Controls.Add(this.panel1);
            this.Name = "TelaInicial";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInfoLeitura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewInfoEmprestimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOlaUser;
        private System.Windows.Forms.DataGridView GridViewInfoLeitura;
        private System.Windows.Forms.Label lblLivrosLendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn livrogrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicioLeitura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridViewInfoEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDevolucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

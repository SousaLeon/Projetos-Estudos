namespace Database_Books.ControlUser
{
    partial class TelaLivros
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
            this.GridViewLivros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gênero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIncluirLivroLendo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparBusca = new System.Windows.Forms.Button();
            this.lblBuscaPersonalizada = new System.Windows.Forms.Label();
            this.BoxBuscaPersonalizada = new System.Windows.Forms.ComboBox();
            this.btnBuscarLeitura = new System.Windows.Forms.Button();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBuscaLeitura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLivros)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewLivros
            // 
            this.GridViewLivros.AllowUserToAddRows = false;
            this.GridViewLivros.AllowUserToDeleteRows = false;
            this.GridViewLivros.AllowUserToResizeColumns = false;
            this.GridViewLivros.AllowUserToResizeRows = false;
            this.GridViewLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewLivros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome_Livro,
            this.Gênero,
            this.Autor,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewLivros.Location = new System.Drawing.Point(10, 152);
            this.GridViewLivros.Margin = new System.Windows.Forms.Padding(10);
            this.GridViewLivros.MultiSelect = false;
            this.GridViewLivros.Name = "GridViewLivros";
            this.GridViewLivros.ReadOnly = true;
            this.GridViewLivros.RowTemplate.Height = 30;
            this.GridViewLivros.Size = new System.Drawing.Size(1260, 499);
            this.GridViewLivros.TabIndex = 0;
            this.GridViewLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewLivros_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome_Livro
            // 
            this.Nome_Livro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome_Livro.HeaderText = "Livro";
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.ReadOnly = true;
            this.Nome_Livro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Gênero
            // 
            this.Gênero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gênero.HeaderText = "Gênero";
            this.Gênero.Name = "Gênero";
            this.Gênero.ReadOnly = true;
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnIncluirLivroLendo
            // 
            this.btnIncluirLivroLendo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncluirLivroLendo.Location = new System.Drawing.Point(40, 673);
            this.btnIncluirLivroLendo.Margin = new System.Windows.Forms.Padding(40, 12, 13, 18);
            this.btnIncluirLivroLendo.Name = "btnIncluirLivroLendo";
            this.btnIncluirLivroLendo.Size = new System.Drawing.Size(100, 28);
            this.btnIncluirLivroLendo.TabIndex = 1;
            this.btnIncluirLivroLendo.Text = "Incluir";
            this.btnIncluirLivroLendo.UseVisualStyleBackColor = true;
            this.btnIncluirLivroLendo.Click += new System.EventHandler(this.btnIncluirLivroLendo_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLimparBusca);
            this.panel1.Controls.Add(this.lblBuscaPersonalizada);
            this.panel1.Controls.Add(this.BoxBuscaPersonalizada);
            this.panel1.Controls.Add(this.btnBuscarLeitura);
            this.panel1.Controls.Add(this.lblBusca);
            this.panel1.Controls.Add(this.txtBuscaLeitura);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 122);
            this.panel1.TabIndex = 2;
            // 
            // btnLimparBusca
            // 
            this.btnLimparBusca.Location = new System.Drawing.Point(525, 82);
            this.btnLimparBusca.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparBusca.Name = "btnLimparBusca";
            this.btnLimparBusca.Size = new System.Drawing.Size(100, 28);
            this.btnLimparBusca.TabIndex = 13;
            this.btnLimparBusca.Text = "Limpar";
            this.btnLimparBusca.UseVisualStyleBackColor = true;
            this.btnLimparBusca.Click += new System.EventHandler(this.btnLimparBusca_Click);
            // 
            // lblBuscaPersonalizada
            // 
            this.lblBuscaPersonalizada.AutoSize = true;
            this.lblBuscaPersonalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscaPersonalizada.Location = new System.Drawing.Point(378, 13);
            this.lblBuscaPersonalizada.Margin = new System.Windows.Forms.Padding(27, 25, 13, 25);
            this.lblBuscaPersonalizada.Name = "lblBuscaPersonalizada";
            this.lblBuscaPersonalizada.Size = new System.Drawing.Size(215, 25);
            this.lblBuscaPersonalizada.TabIndex = 12;
            this.lblBuscaPersonalizada.Text = "Busca Personalizada";
            // 
            // BoxBuscaPersonalizada
            // 
            this.BoxBuscaPersonalizada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxBuscaPersonalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxBuscaPersonalizada.FormattingEnabled = true;
            this.BoxBuscaPersonalizada.Items.AddRange(new object[] {
            "Livro",
            "Status"});
            this.BoxBuscaPersonalizada.Location = new System.Drawing.Point(346, 42);
            this.BoxBuscaPersonalizada.Name = "BoxBuscaPersonalizada";
            this.BoxBuscaPersonalizada.Size = new System.Drawing.Size(279, 33);
            this.BoxBuscaPersonalizada.TabIndex = 11;
            // 
            // btnBuscarLeitura
            // 
            this.btnBuscarLeitura.Location = new System.Drawing.Point(110, 82);
            this.btnBuscarLeitura.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarLeitura.Name = "btnBuscarLeitura";
            this.btnBuscarLeitura.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarLeitura.TabIndex = 10;
            this.btnBuscarLeitura.Text = "Buscar";
            this.btnBuscarLeitura.UseVisualStyleBackColor = true;
            this.btnBuscarLeitura.Click += new System.EventHandler(this.btnBuscarLeitura_Click);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(74, 13);
            this.lblBusca.Margin = new System.Windows.Forms.Padding(27, 25, 13, 25);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(173, 25);
            this.lblBusca.TabIndex = 9;
            this.lblBusca.Text = "Buscando leitura";
            // 
            // txtBuscaLeitura
            // 
            this.txtBuscaLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaLeitura.Location = new System.Drawing.Point(5, 44);
            this.txtBuscaLeitura.Margin = new System.Windows.Forms.Padding(13, 25, 27, 25);
            this.txtBuscaLeitura.Name = "txtBuscaLeitura";
            this.txtBuscaLeitura.Size = new System.Drawing.Size(311, 31);
            this.txtBuscaLeitura.TabIndex = 8;
            // 
            // TelaLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnIncluirLivroLendo);
            this.Controls.Add(this.GridViewLivros);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaLivros";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewLivros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewLivros;
        private System.Windows.Forms.Button btnIncluirLivroLendo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gênero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimparBusca;
        private System.Windows.Forms.Label lblBuscaPersonalizada;
        private System.Windows.Forms.ComboBox BoxBuscaPersonalizada;
        private System.Windows.Forms.Button btnBuscarLeitura;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBuscaLeitura;
    }
}

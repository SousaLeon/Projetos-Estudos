namespace Database_Books
{
    partial class TelaCadastroLivro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxBuscaPersonalizada = new System.Windows.Forms.ComboBox();
            this.btnBuscarCadastroLivro = new System.Windows.Forms.Button();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBuscaCadastroLivro = new System.Windows.Forms.TextBox();
            this.btnIncluirCadastroLivro = new System.Windows.Forms.Button();
            this.GridViewCadastroLivro = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gênero_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formato_Livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimparBusca = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCadastroLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLimparBusca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BoxBuscaPersonalizada);
            this.panel1.Controls.Add(this.btnBuscarCadastroLivro);
            this.panel1.Controls.Add(this.lblBusca);
            this.panel1.Controls.Add(this.txtBuscaCadastroLivro);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 122);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(27, 25, 13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busca Personalizada";
            // 
            // BoxBuscaPersonalizada
            // 
            this.BoxBuscaPersonalizada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxBuscaPersonalizada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxBuscaPersonalizada.FormattingEnabled = true;
            this.BoxBuscaPersonalizada.Items.AddRange(new object[] {
            "Autor",
            "Livro",
            "Genero"});
            this.BoxBuscaPersonalizada.Location = new System.Drawing.Point(354, 38);
            this.BoxBuscaPersonalizada.Name = "BoxBuscaPersonalizada";
            this.BoxBuscaPersonalizada.Size = new System.Drawing.Size(279, 33);
            this.BoxBuscaPersonalizada.TabIndex = 5;
            // 
            // btnBuscarCadastroLivro
            // 
            this.btnBuscarCadastroLivro.Location = new System.Drawing.Point(118, 86);
            this.btnBuscarCadastroLivro.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCadastroLivro.Name = "btnBuscarCadastroLivro";
            this.btnBuscarCadastroLivro.Size = new System.Drawing.Size(100, 28);
            this.btnBuscarCadastroLivro.TabIndex = 4;
            this.btnBuscarCadastroLivro.Text = "Buscar";
            this.btnBuscarCadastroLivro.UseVisualStyleBackColor = true;
            this.btnBuscarCadastroLivro.Click += new System.EventHandler(this.btnBuscarCadastroLivro_Click);
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(85, 9);
            this.lblBusca.Margin = new System.Windows.Forms.Padding(27, 25, 13, 25);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(166, 25);
            this.lblBusca.TabIndex = 1;
            this.lblBusca.Text = "Busca de Livros";
            // 
            // txtBuscaCadastroLivro
            // 
            this.txtBuscaCadastroLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaCadastroLivro.Location = new System.Drawing.Point(13, 40);
            this.txtBuscaCadastroLivro.Margin = new System.Windows.Forms.Padding(13, 25, 27, 25);
            this.txtBuscaCadastroLivro.Name = "txtBuscaCadastroLivro";
            this.txtBuscaCadastroLivro.Size = new System.Drawing.Size(311, 31);
            this.txtBuscaCadastroLivro.TabIndex = 0;
            // 
            // btnIncluirCadastroLivro
            // 
            this.btnIncluirCadastroLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncluirCadastroLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirCadastroLivro.Location = new System.Drawing.Point(27, 667);
            this.btnIncluirCadastroLivro.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.btnIncluirCadastroLivro.Name = "btnIncluirCadastroLivro";
            this.btnIncluirCadastroLivro.Size = new System.Drawing.Size(206, 28);
            this.btnIncluirCadastroLivro.TabIndex = 2;
            this.btnIncluirCadastroLivro.Text = "Incluir novo livro";
            this.btnIncluirCadastroLivro.UseVisualStyleBackColor = true;
            this.btnIncluirCadastroLivro.Click += new System.EventHandler(this.btnIncluirCadastroLivro_Click);
            // 
            // GridViewCadastroLivro
            // 
            this.GridViewCadastroLivro.AllowUserToAddRows = false;
            this.GridViewCadastroLivro.AllowUserToDeleteRows = false;
            this.GridViewCadastroLivro.AllowUserToResizeColumns = false;
            this.GridViewCadastroLivro.AllowUserToResizeRows = false;
            this.GridViewCadastroLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewCadastroLivro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCadastroLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridViewCadastroLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewCadastroLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome_Livro,
            this.Gênero_Livro,
            this.Autor_Livro,
            this.Formato_Livro});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewCadastroLivro.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridViewCadastroLivro.Location = new System.Drawing.Point(13, 151);
            this.GridViewCadastroLivro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 60);
            this.GridViewCadastroLivro.MultiSelect = false;
            this.GridViewCadastroLivro.Name = "GridViewCadastroLivro";
            this.GridViewCadastroLivro.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewCadastroLivro.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridViewCadastroLivro.RowTemplate.Height = 30;
            this.GridViewCadastroLivro.Size = new System.Drawing.Size(1253, 509);
            this.GridViewCadastroLivro.TabIndex = 1;
            this.GridViewCadastroLivro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewCadastroLivro_CellDoubleClick);
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
            this.Nome_Livro.HeaderText = "Nome_Livro";
            this.Nome_Livro.Name = "Nome_Livro";
            this.Nome_Livro.ReadOnly = true;
            // 
            // Gênero_Livro
            // 
            this.Gênero_Livro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gênero_Livro.HeaderText = "Gênero_Livro";
            this.Gênero_Livro.Name = "Gênero_Livro";
            this.Gênero_Livro.ReadOnly = true;
            // 
            // Autor_Livro
            // 
            this.Autor_Livro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor_Livro.HeaderText = "Autor_Livro";
            this.Autor_Livro.Name = "Autor_Livro";
            this.Autor_Livro.ReadOnly = true;
            // 
            // Formato_Livro
            // 
            this.Formato_Livro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Formato_Livro.HeaderText = "Formato_Livro";
            this.Formato_Livro.Name = "Formato_Livro";
            this.Formato_Livro.ReadOnly = true;
            // 
            // btnLimparBusca
            // 
            this.btnLimparBusca.Location = new System.Drawing.Point(533, 78);
            this.btnLimparBusca.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimparBusca.Name = "btnLimparBusca";
            this.btnLimparBusca.Size = new System.Drawing.Size(100, 28);
            this.btnLimparBusca.TabIndex = 7;
            this.btnLimparBusca.Text = "Limpar";
            this.btnLimparBusca.UseVisualStyleBackColor = true;
            this.btnLimparBusca.Click += new System.EventHandler(this.btnLimparBusca_Click);
            // 
            // TelaCadastroLivro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnIncluirCadastroLivro);
            this.Controls.Add(this.GridViewCadastroLivro);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaCadastroLivro";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewCadastroLivro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBuscaCadastroLivro;
        private System.Windows.Forms.DataGridView GridViewCadastroLivro;
        private System.Windows.Forms.Button btnIncluirCadastroLivro;
        private System.Windows.Forms.Button btnBuscarCadastroLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gênero_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor_Livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formato_Livro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxBuscaPersonalizada;
        private System.Windows.Forms.Button btnLimparBusca;
    }
}

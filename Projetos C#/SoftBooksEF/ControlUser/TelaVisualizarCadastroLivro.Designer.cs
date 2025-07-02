namespace Database_Books.ControlUser
{
    partial class TelaVisualizarCadastroLivro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionarPDF = new System.Windows.Forms.Button();
            this.BoxFormatoVisuCadastro = new System.Windows.Forms.ComboBox();
            this.txtNPaginaVisuCadastro = new System.Windows.Forms.TextBox();
            this.txtAutorVisuCadastro = new System.Windows.Forms.TextBox();
            this.txtGeneroLivroVisuCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeLivroVisuCadastro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfoLivroVisualizaCadastro = new System.Windows.Forms.Label();
            this.btnSalvarVisualizarCadastroLivro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNSeqVisuCadastro = new System.Windows.Forms.TextBox();
            this.txtValorLivroVisuCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeSeqVisuCadastro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFecharVisualizaCadastroLivro = new System.Windows.Forms.Button();
            this.btnExcluirCadastroLivro = new System.Windows.Forms.Button();
            this.lblAdicionarPDF = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblAdicionarPDF);
            this.panel1.Controls.Add(this.btnAdicionarPDF);
            this.panel1.Controls.Add(this.BoxFormatoVisuCadastro);
            this.panel1.Controls.Add(this.txtNPaginaVisuCadastro);
            this.panel1.Controls.Add(this.txtAutorVisuCadastro);
            this.panel1.Controls.Add(this.txtGeneroLivroVisuCadastro);
            this.panel1.Controls.Add(this.txtNomeLivroVisuCadastro);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblInfoLivroVisualizaCadastro);
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 584);
            this.panel1.TabIndex = 0;
            // 
            // btnAdicionarPDF
            // 
            this.btnAdicionarPDF.Location = new System.Drawing.Point(11, 361);
            this.btnAdicionarPDF.Name = "btnAdicionarPDF";
            this.btnAdicionarPDF.Size = new System.Drawing.Size(133, 29);
            this.btnAdicionarPDF.TabIndex = 14;
            this.btnAdicionarPDF.Text = "Adicionar PDF";
            this.btnAdicionarPDF.UseVisualStyleBackColor = true;
            this.btnAdicionarPDF.Click += new System.EventHandler(this.btnAdicionarPDF_Click);
            // 
            // BoxFormatoVisuCadastro
            // 
            this.BoxFormatoVisuCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxFormatoVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFormatoVisuCadastro.FormattingEnabled = true;
            this.BoxFormatoVisuCadastro.Items.AddRange(new object[] {
            "Audiolivro",
            "Digital",
            "Físico"});
            this.BoxFormatoVisuCadastro.Location = new System.Drawing.Point(211, 254);
            this.BoxFormatoVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.BoxFormatoVisuCadastro.Name = "BoxFormatoVisuCadastro";
            this.BoxFormatoVisuCadastro.Size = new System.Drawing.Size(193, 28);
            this.BoxFormatoVisuCadastro.TabIndex = 11;
            // 
            // txtNPaginaVisuCadastro
            // 
            this.txtNPaginaVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPaginaVisuCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNPaginaVisuCadastro.Location = new System.Drawing.Point(191, 191);
            this.txtNPaginaVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNPaginaVisuCadastro.Name = "txtNPaginaVisuCadastro";
            this.txtNPaginaVisuCadastro.Size = new System.Drawing.Size(135, 26);
            this.txtNPaginaVisuCadastro.TabIndex = 10;
            // 
            // txtAutorVisuCadastro
            // 
            this.txtAutorVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorVisuCadastro.Location = new System.Drawing.Point(107, 314);
            this.txtAutorVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutorVisuCadastro.Name = "txtAutorVisuCadastro";
            this.txtAutorVisuCadastro.Size = new System.Drawing.Size(432, 26);
            this.txtAutorVisuCadastro.TabIndex = 13;
            // 
            // txtGeneroLivroVisuCadastro
            // 
            this.txtGeneroLivroVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneroLivroVisuCadastro.Location = new System.Drawing.Point(188, 130);
            this.txtGeneroLivroVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtGeneroLivroVisuCadastro.Name = "txtGeneroLivroVisuCadastro";
            this.txtGeneroLivroVisuCadastro.Size = new System.Drawing.Size(351, 26);
            this.txtGeneroLivroVisuCadastro.TabIndex = 9;
            // 
            // txtNomeLivroVisuCadastro
            // 
            this.txtNomeLivroVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivroVisuCadastro.Location = new System.Drawing.Point(188, 69);
            this.txtNomeLivroVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeLivroVisuCadastro.Name = "txtNomeLivroVisuCadastro";
            this.txtNomeLivroVisuCadastro.Size = new System.Drawing.Size(351, 26);
            this.txtNomeLivroVisuCadastro.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Formato do livro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "N° de páginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gênero do livro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome do livro";
            // 
            // lblInfoLivroVisualizaCadastro
            // 
            this.lblInfoLivroVisualizaCadastro.AutoSize = true;
            this.lblInfoLivroVisualizaCadastro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLivroVisualizaCadastro.Location = new System.Drawing.Point(13, 12);
            this.lblInfoLivroVisualizaCadastro.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblInfoLivroVisualizaCadastro.Name = "lblInfoLivroVisualizaCadastro";
            this.lblInfoLivroVisualizaCadastro.Size = new System.Drawing.Size(206, 28);
            this.lblInfoLivroVisualizaCadastro.TabIndex = 0;
            this.lblInfoLivroVisualizaCadastro.Text = "Informações do livro";
            // 
            // btnSalvarVisualizarCadastroLivro
            // 
            this.btnSalvarVisualizarCadastroLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarVisualizarCadastroLivro.Location = new System.Drawing.Point(40, 655);
            this.btnSalvarVisualizarCadastroLivro.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.btnSalvarVisualizarCadastroLivro.Name = "btnSalvarVisualizarCadastroLivro";
            this.btnSalvarVisualizarCadastroLivro.Size = new System.Drawing.Size(100, 28);
            this.btnSalvarVisualizarCadastroLivro.TabIndex = 1;
            this.btnSalvarVisualizarCadastroLivro.Text = "Salvar";
            this.btnSalvarVisualizarCadastroLivro.UseVisualStyleBackColor = true;
            this.btnSalvarVisualizarCadastroLivro.Click += new System.EventHandler(this.btnSalvarVisualizarCadastroLivro_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtNSeqVisuCadastro);
            this.panel2.Controls.Add(this.txtValorLivroVisuCadastro);
            this.panel2.Controls.Add(this.txtNomeSeqVisuCadastro);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(746, 25);
            this.panel2.Margin = new System.Windows.Forms.Padding(53, 49, 53, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 326);
            this.panel2.TabIndex = 2;
            // 
            // txtNSeqVisuCadastro
            // 
            this.txtNSeqVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNSeqVisuCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNSeqVisuCadastro.Location = new System.Drawing.Point(207, 132);
            this.txtNSeqVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNSeqVisuCadastro.Name = "txtNSeqVisuCadastro";
            this.txtNSeqVisuCadastro.Size = new System.Drawing.Size(109, 26);
            this.txtNSeqVisuCadastro.TabIndex = 16;
            // 
            // txtValorLivroVisuCadastro
            // 
            this.txtValorLivroVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorLivroVisuCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtValorLivroVisuCadastro.Location = new System.Drawing.Point(123, 189);
            this.txtValorLivroVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorLivroVisuCadastro.Name = "txtValorLivroVisuCadastro";
            this.txtValorLivroVisuCadastro.Size = new System.Drawing.Size(109, 26);
            this.txtValorLivroVisuCadastro.TabIndex = 15;
            // 
            // txtNomeSeqVisuCadastro
            // 
            this.txtNomeSeqVisuCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSeqVisuCadastro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNomeSeqVisuCadastro.Location = new System.Drawing.Point(188, 71);
            this.txtNomeSeqVisuCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeSeqVisuCadastro.Name = "txtNomeSeqVisuCadastro";
            this.txtNomeSeqVisuCadastro.Size = new System.Drawing.Size(283, 26);
            this.txtNomeSeqVisuCadastro.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "Valor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 131);
            this.label11.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "N° da sequência";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 70);
            this.label10.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nome da série";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informações da sequência";
            // 
            // btnFecharVisualizaCadastroLivro
            // 
            this.btnFecharVisualizaCadastroLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFecharVisualizaCadastroLivro.Location = new System.Drawing.Point(220, 655);
            this.btnFecharVisualizaCadastroLivro.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.btnFecharVisualizaCadastroLivro.Name = "btnFecharVisualizaCadastroLivro";
            this.btnFecharVisualizaCadastroLivro.Size = new System.Drawing.Size(100, 28);
            this.btnFecharVisualizaCadastroLivro.TabIndex = 4;
            this.btnFecharVisualizaCadastroLivro.Text = "Fechar";
            this.btnFecharVisualizaCadastroLivro.UseVisualStyleBackColor = true;
            this.btnFecharVisualizaCadastroLivro.Click += new System.EventHandler(this.btnFecharVisualizaCadastroLivro_Click);
            // 
            // btnExcluirCadastroLivro
            // 
            this.btnExcluirCadastroLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirCadastroLivro.Location = new System.Drawing.Point(400, 655);
            this.btnExcluirCadastroLivro.Margin = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.btnExcluirCadastroLivro.Name = "btnExcluirCadastroLivro";
            this.btnExcluirCadastroLivro.Size = new System.Drawing.Size(100, 28);
            this.btnExcluirCadastroLivro.TabIndex = 5;
            this.btnExcluirCadastroLivro.Text = "Excluir";
            this.btnExcluirCadastroLivro.UseVisualStyleBackColor = true;
            this.btnExcluirCadastroLivro.Click += new System.EventHandler(this.btnExcluirCadastroLivro_Click);
            // 
            // lblAdicionarPDF
            // 
            this.lblAdicionarPDF.AutoSize = true;
            this.lblAdicionarPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarPDF.Location = new System.Drawing.Point(150, 364);
            this.lblAdicionarPDF.Name = "lblAdicionarPDF";
            this.lblAdicionarPDF.Size = new System.Drawing.Size(221, 20);
            this.lblAdicionarPDF.TabIndex = 15;
            this.lblAdicionarPDF.Text = "Não possui PDF, adicione um!";
            // 
            // TelaVisualizarCadastroLivro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnExcluirCadastroLivro);
            this.Controls.Add(this.btnFecharVisualizaCadastroLivro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalvarVisualizarCadastroLivro);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaVisualizarCadastroLivro";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.TelaVisualizarCadastroLivro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfoLivroVisualizaCadastro;
        private System.Windows.Forms.Button btnSalvarVisualizarCadastroLivro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFecharVisualizaCadastroLivro;
        private System.Windows.Forms.Button btnExcluirCadastroLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox BoxFormatoVisuCadastro;
        private System.Windows.Forms.TextBox txtGeneroLivroVisuCadastro;
        private System.Windows.Forms.TextBox txtNomeLivroVisuCadastro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNPaginaVisuCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAutorVisuCadastro;
        private System.Windows.Forms.TextBox txtNSeqVisuCadastro;
        private System.Windows.Forms.TextBox txtValorLivroVisuCadastro;
        private System.Windows.Forms.TextBox txtNomeSeqVisuCadastro;
        private System.Windows.Forms.Button btnAdicionarPDF;
        private System.Windows.Forms.Label lblAdicionarPDF;
    }
}

namespace Database_Books.ControlUser
{
    partial class TelaVisualizarLeituraLivros
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
            this.BoxStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLeitor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutorLivro = new System.Windows.Forms.TextBox();
            this.txtGeneroLivro = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGeneroLivro = new System.Windows.Forms.Label();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.txtNumeroSeq = new System.Windows.Forms.TextBox();
            this.txtNomeSeq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxInfoDataEmprestimo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.DataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.groupBoxDataLivro = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataFimEstimativa = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DataFimLeitura = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DataInicioLeitura = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarLeituraLivro = new System.Windows.Forms.Button();
            this.btnCancelarLeituraLivro = new System.Windows.Forms.Button();
            this.btnExcluirLeituraLivro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxMaisInfoEmprestimo = new System.Windows.Forms.GroupBox();
            this.lblPessoaEmprestimo = new System.Windows.Forms.Label();
            this.txtPessoaEmprestimo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorEmprestimo = new System.Windows.Forms.TextBox();
            this.groupBoxMaisInfoLivro = new System.Windows.Forms.GroupBox();
            this.btnResumoNota = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxInfoDataEmprestimo.SuspendLayout();
            this.groupBoxDataLivro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxMaisInfoEmprestimo.SuspendLayout();
            this.groupBoxMaisInfoLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BoxStatus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLeitor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtAutorLivro);
            this.panel1.Controls.Add(this.txtGeneroLivro);
            this.panel1.Controls.Add(this.txtNomeLivro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblGeneroLivro);
            this.panel1.Controls.Add(this.lblNomeLivro);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1240, 200);
            this.panel1.TabIndex = 0;
            // 
            // BoxStatus
            // 
            this.BoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxStatus.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxStatus.FormattingEnabled = true;
            this.BoxStatus.Items.AddRange(new object[] {
            "Lendo",
            "Lido",
            "Emprestado",
            "Devolvido"});
            this.BoxStatus.Location = new System.Drawing.Point(740, 15);
            this.BoxStatus.Name = "BoxStatus";
            this.BoxStatus.Size = new System.Drawing.Size(254, 30);
            this.BoxStatus.TabIndex = 13;
            this.BoxStatus.SelectedIndexChanged += new System.EventHandler(this.BoxStatus_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "Status de leitura";
            // 
            // txtLeitor
            // 
            this.txtLeitor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeitor.Location = new System.Drawing.Point(642, 77);
            this.txtLeitor.Name = "txtLeitor";
            this.txtLeitor.ReadOnly = true;
            this.txtLeitor.Size = new System.Drawing.Size(353, 26);
            this.txtLeitor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(555, 75);
            this.label7.Margin = new System.Windows.Forms.Padding(15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "Leitor";
            // 
            // txtAutorLivro
            // 
            this.txtAutorLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorLivro.Location = new System.Drawing.Point(184, 133);
            this.txtAutorLivro.Name = "txtAutorLivro";
            this.txtAutorLivro.ReadOnly = true;
            this.txtAutorLivro.Size = new System.Drawing.Size(353, 26);
            this.txtAutorLivro.TabIndex = 5;
            // 
            // txtGeneroLivro
            // 
            this.txtGeneroLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneroLivro.Location = new System.Drawing.Point(184, 75);
            this.txtGeneroLivro.Name = "txtGeneroLivro";
            this.txtGeneroLivro.ReadOnly = true;
            this.txtGeneroLivro.Size = new System.Drawing.Size(353, 26);
            this.txtGeneroLivro.TabIndex = 4;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.Location = new System.Drawing.Point(184, 17);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.ReadOnly = true;
            this.txtNomeLivro.Size = new System.Drawing.Size(353, 26);
            this.txtNomeLivro.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Autor do livro";
            // 
            // lblGeneroLivro
            // 
            this.lblGeneroLivro.AutoSize = true;
            this.lblGeneroLivro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroLivro.Location = new System.Drawing.Point(15, 73);
            this.lblGeneroLivro.Margin = new System.Windows.Forms.Padding(15);
            this.lblGeneroLivro.Name = "lblGeneroLivro";
            this.lblGeneroLivro.Size = new System.Drawing.Size(163, 28);
            this.lblGeneroLivro.TabIndex = 1;
            this.lblGeneroLivro.Text = "Gênero do livro";
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLivro.Location = new System.Drawing.Point(15, 15);
            this.lblNomeLivro.Margin = new System.Windows.Forms.Padding(15);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(151, 28);
            this.lblNomeLivro.TabIndex = 0;
            this.lblNomeLivro.Text = "Nome do livro";
            // 
            // txtNumeroSeq
            // 
            this.txtNumeroSeq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSeq.Location = new System.Drawing.Point(118, 84);
            this.txtNumeroSeq.Name = "txtNumeroSeq";
            this.txtNumeroSeq.ReadOnly = true;
            this.txtNumeroSeq.Size = new System.Drawing.Size(125, 26);
            this.txtNumeroSeq.TabIndex = 9;
            // 
            // txtNomeSeq
            // 
            this.txtNomeSeq.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSeq.Location = new System.Drawing.Point(212, 26);
            this.txtNomeSeq.Name = "txtNomeSeq";
            this.txtNomeSeq.ReadOnly = true;
            this.txtNomeSeq.Size = new System.Drawing.Size(353, 26);
            this.txtNomeSeq.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome Sequência";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "N° Seq.";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBoxInfoDataEmprestimo);
            this.panel2.Controls.Add(this.groupBoxDataLivro);
            this.panel2.Location = new System.Drawing.Point(20, 234);
            this.panel2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 385);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxInfoDataEmprestimo
            // 
            this.groupBoxInfoDataEmprestimo.Controls.Add(this.label9);
            this.groupBoxInfoDataEmprestimo.Controls.Add(this.label10);
            this.groupBoxInfoDataEmprestimo.Controls.Add(this.DataEmprestimo);
            this.groupBoxInfoDataEmprestimo.Controls.Add(this.DataDevolucao);
            this.groupBoxInfoDataEmprestimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInfoDataEmprestimo.Location = new System.Drawing.Point(10, 219);
            this.groupBoxInfoDataEmprestimo.Name = "groupBoxInfoDataEmprestimo";
            this.groupBoxInfoDataEmprestimo.Size = new System.Drawing.Size(489, 164);
            this.groupBoxInfoDataEmprestimo.TabIndex = 9;
            this.groupBoxInfoDataEmprestimo.TabStop = false;
            this.groupBoxInfoDataEmprestimo.Text = "Informações de data Empréstimo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data Empréstimo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 95);
            this.label10.Margin = new System.Windows.Forms.Padding(15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 28);
            this.label10.TabIndex = 9;
            this.label10.Text = "Data Devolução";
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.Enabled = false;
            this.DataEmprestimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataEmprestimo.Location = new System.Drawing.Point(249, 38);
            this.DataEmprestimo.Name = "DataEmprestimo";
            this.DataEmprestimo.Size = new System.Drawing.Size(226, 26);
            this.DataEmprestimo.TabIndex = 10;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.Enabled = false;
            this.DataDevolucao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDevolucao.Location = new System.Drawing.Point(249, 97);
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.Size = new System.Drawing.Size(226, 26);
            this.DataDevolucao.TabIndex = 11;
            // 
            // groupBoxDataLivro
            // 
            this.groupBoxDataLivro.Controls.Add(this.label2);
            this.groupBoxDataLivro.Controls.Add(this.DataFimEstimativa);
            this.groupBoxDataLivro.Controls.Add(this.label3);
            this.groupBoxDataLivro.Controls.Add(this.DataFimLeitura);
            this.groupBoxDataLivro.Controls.Add(this.label4);
            this.groupBoxDataLivro.Controls.Add(this.DataInicioLeitura);
            this.groupBoxDataLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataLivro.Location = new System.Drawing.Point(10, 10);
            this.groupBoxDataLivro.Margin = new System.Windows.Forms.Padding(10);
            this.groupBoxDataLivro.Name = "groupBoxDataLivro";
            this.groupBoxDataLivro.Size = new System.Drawing.Size(489, 201);
            this.groupBoxDataLivro.TabIndex = 8;
            this.groupBoxDataLivro.TabStop = false;
            this.groupBoxDataLivro.Text = "Informações de data do livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Início da leitura";
            // 
            // DataFimEstimativa
            // 
            this.DataFimEstimativa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFimEstimativa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFimEstimativa.Location = new System.Drawing.Point(249, 149);
            this.DataFimEstimativa.Name = "DataFimEstimativa";
            this.DataFimEstimativa.Size = new System.Drawing.Size(226, 26);
            this.DataFimEstimativa.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Fim da leitura";
            // 
            // DataFimLeitura
            // 
            this.DataFimLeitura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFimLeitura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFimLeitura.Location = new System.Drawing.Point(249, 91);
            this.DataFimLeitura.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.DataFimLeitura.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DataFimLeitura.Name = "DataFimLeitura";
            this.DataFimLeitura.Size = new System.Drawing.Size(226, 26);
            this.DataFimLeitura.TabIndex = 6;
            this.DataFimLeitura.Value = new System.DateTime(2000, 4, 26, 21, 32, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Fim Estimativa";
            // 
            // DataInicioLeitura
            // 
            this.DataInicioLeitura.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicioLeitura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicioLeitura.Location = new System.Drawing.Point(249, 32);
            this.DataInicioLeitura.Name = "DataInicioLeitura";
            this.DataInicioLeitura.Size = new System.Drawing.Size(226, 26);
            this.DataInicioLeitura.TabIndex = 5;
            // 
            // btnSalvarLeituraLivro
            // 
            this.btnSalvarLeituraLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarLeituraLivro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvarLeituraLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarLeituraLivro.Location = new System.Drawing.Point(20, 670);
            this.btnSalvarLeituraLivro.Margin = new System.Windows.Forms.Padding(20);
            this.btnSalvarLeituraLivro.Name = "btnSalvarLeituraLivro";
            this.btnSalvarLeituraLivro.Size = new System.Drawing.Size(96, 30);
            this.btnSalvarLeituraLivro.TabIndex = 2;
            this.btnSalvarLeituraLivro.Text = "Salvar";
            this.btnSalvarLeituraLivro.UseVisualStyleBackColor = true;
            this.btnSalvarLeituraLivro.Click += new System.EventHandler(this.btnSalvarLeituraLivro_Click);
            // 
            // btnCancelarLeituraLivro
            // 
            this.btnCancelarLeituraLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarLeituraLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLeituraLivro.Location = new System.Drawing.Point(135, 668);
            this.btnCancelarLeituraLivro.Margin = new System.Windows.Forms.Padding(20);
            this.btnCancelarLeituraLivro.Name = "btnCancelarLeituraLivro";
            this.btnCancelarLeituraLivro.Size = new System.Drawing.Size(96, 30);
            this.btnCancelarLeituraLivro.TabIndex = 3;
            this.btnCancelarLeituraLivro.Text = "Cancelar";
            this.btnCancelarLeituraLivro.UseVisualStyleBackColor = true;
            this.btnCancelarLeituraLivro.Click += new System.EventHandler(this.btnCancelarLeituraLivro_Click);
            // 
            // btnExcluirLeituraLivro
            // 
            this.btnExcluirLeituraLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirLeituraLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirLeituraLivro.Location = new System.Drawing.Point(250, 668);
            this.btnExcluirLeituraLivro.Margin = new System.Windows.Forms.Padding(20);
            this.btnExcluirLeituraLivro.Name = "btnExcluirLeituraLivro";
            this.btnExcluirLeituraLivro.Size = new System.Drawing.Size(96, 30);
            this.btnExcluirLeituraLivro.TabIndex = 4;
            this.btnExcluirLeituraLivro.Text = "Excluir";
            this.btnExcluirLeituraLivro.UseVisualStyleBackColor = true;
            this.btnExcluirLeituraLivro.Click += new System.EventHandler(this.btnExcluirLeituraLivro_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBoxMaisInfoEmprestimo);
            this.panel3.Controls.Add(this.groupBoxMaisInfoLivro);
            this.panel3.Location = new System.Drawing.Point(583, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 385);
            this.panel3.TabIndex = 5;
            // 
            // groupBoxMaisInfoEmprestimo
            // 
            this.groupBoxMaisInfoEmprestimo.Controls.Add(this.lblPessoaEmprestimo);
            this.groupBoxMaisInfoEmprestimo.Controls.Add(this.txtPessoaEmprestimo);
            this.groupBoxMaisInfoEmprestimo.Controls.Add(this.label11);
            this.groupBoxMaisInfoEmprestimo.Controls.Add(this.txtValorEmprestimo);
            this.groupBoxMaisInfoEmprestimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMaisInfoEmprestimo.Location = new System.Drawing.Point(14, 233);
            this.groupBoxMaisInfoEmprestimo.Name = "groupBoxMaisInfoEmprestimo";
            this.groupBoxMaisInfoEmprestimo.Size = new System.Drawing.Size(612, 149);
            this.groupBoxMaisInfoEmprestimo.TabIndex = 13;
            this.groupBoxMaisInfoEmprestimo.TabStop = false;
            this.groupBoxMaisInfoEmprestimo.Text = "Mais informações de empréstimo";
            // 
            // lblPessoaEmprestimo
            // 
            this.lblPessoaEmprestimo.AutoSize = true;
            this.lblPessoaEmprestimo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPessoaEmprestimo.Location = new System.Drawing.Point(18, 45);
            this.lblPessoaEmprestimo.Margin = new System.Windows.Forms.Padding(15);
            this.lblPessoaEmprestimo.Name = "lblPessoaEmprestimo";
            this.lblPessoaEmprestimo.Size = new System.Drawing.Size(200, 28);
            this.lblPessoaEmprestimo.TabIndex = 10;
            this.lblPessoaEmprestimo.Text = "Pessoa Empréstimo";
            // 
            // txtPessoaEmprestimo
            // 
            this.txtPessoaEmprestimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPessoaEmprestimo.Location = new System.Drawing.Point(236, 47);
            this.txtPessoaEmprestimo.Name = "txtPessoaEmprestimo";
            this.txtPessoaEmprestimo.ReadOnly = true;
            this.txtPessoaEmprestimo.Size = new System.Drawing.Size(353, 26);
            this.txtPessoaEmprestimo.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 28);
            this.label11.TabIndex = 10;
            this.label11.Text = "Valor Empréstimo";
            // 
            // txtValorEmprestimo
            // 
            this.txtValorEmprestimo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEmprestimo.Location = new System.Drawing.Point(222, 105);
            this.txtValorEmprestimo.Name = "txtValorEmprestimo";
            this.txtValorEmprestimo.ReadOnly = true;
            this.txtValorEmprestimo.Size = new System.Drawing.Size(125, 26);
            this.txtValorEmprestimo.TabIndex = 11;
            // 
            // groupBoxMaisInfoLivro
            // 
            this.groupBoxMaisInfoLivro.Controls.Add(this.btnResumoNota);
            this.groupBoxMaisInfoLivro.Controls.Add(this.label6);
            this.groupBoxMaisInfoLivro.Controls.Add(this.txtNumeroSeq);
            this.groupBoxMaisInfoLivro.Controls.Add(this.label5);
            this.groupBoxMaisInfoLivro.Controls.Add(this.txtNomeSeq);
            this.groupBoxMaisInfoLivro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMaisInfoLivro.Location = new System.Drawing.Point(14, 12);
            this.groupBoxMaisInfoLivro.Name = "groupBoxMaisInfoLivro";
            this.groupBoxMaisInfoLivro.Size = new System.Drawing.Size(612, 201);
            this.groupBoxMaisInfoLivro.TabIndex = 12;
            this.groupBoxMaisInfoLivro.TabStop = false;
            this.groupBoxMaisInfoLivro.Text = "Mais informações do livro";
            // 
            // btnResumoNota
            // 
            this.btnResumoNota.Location = new System.Drawing.Point(6, 145);
            this.btnResumoNota.Name = "btnResumoNota";
            this.btnResumoNota.Size = new System.Drawing.Size(161, 30);
            this.btnResumoNota.TabIndex = 10;
            this.btnResumoNota.Text = "Resumo/Nota do livro";
            this.btnResumoNota.UseVisualStyleBackColor = true;
            this.btnResumoNota.Click += new System.EventHandler(this.btnResumoNota_Click);
            // 
            // TelaVisualizarLeituraLivros
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnExcluirLeituraLivro);
            this.Controls.Add(this.btnCancelarLeituraLivro);
            this.Controls.Add(this.btnSalvarLeituraLivro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaVisualizarLeituraLivros";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.TelaVisualizarLeituraLivros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxInfoDataEmprestimo.ResumeLayout(false);
            this.groupBoxInfoDataEmprestimo.PerformLayout();
            this.groupBoxDataLivro.ResumeLayout(false);
            this.groupBoxDataLivro.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxMaisInfoEmprestimo.ResumeLayout(false);
            this.groupBoxMaisInfoEmprestimo.PerformLayout();
            this.groupBoxMaisInfoLivro.ResumeLayout(false);
            this.groupBoxMaisInfoLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGeneroLivro;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.TextBox txtAutorLivro;
        private System.Windows.Forms.TextBox txtGeneroLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DataInicioLeitura;
        private System.Windows.Forms.TextBox txtNumeroSeq;
        private System.Windows.Forms.TextBox txtNomeSeq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DataFimEstimativa;
        private System.Windows.Forms.DateTimePicker DataFimLeitura;
        private System.Windows.Forms.ComboBox BoxStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLeitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxDataLivro;
        private System.Windows.Forms.GroupBox groupBoxInfoDataEmprestimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DataEmprestimo;
        private System.Windows.Forms.DateTimePicker DataDevolucao;
        private System.Windows.Forms.Button btnSalvarLeituraLivro;
        private System.Windows.Forms.Button btnCancelarLeituraLivro;
        private System.Windows.Forms.Button btnExcluirLeituraLivro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxMaisInfoLivro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorEmprestimo;
        private System.Windows.Forms.GroupBox groupBoxMaisInfoEmprestimo;
        private System.Windows.Forms.Label lblPessoaEmprestimo;
        private System.Windows.Forms.TextBox txtPessoaEmprestimo;
        private System.Windows.Forms.Button btnResumoNota;
    }
}

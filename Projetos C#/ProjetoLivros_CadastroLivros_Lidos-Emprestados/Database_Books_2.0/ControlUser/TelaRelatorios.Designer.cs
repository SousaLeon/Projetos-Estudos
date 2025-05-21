namespace Database_Books.ControlUser
{
    partial class TelaRelatorios
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
            this.groupBoxRelFinanceiro = new System.Windows.Forms.GroupBox();
            this.btnExibirInfoRelFinanceiro = new System.Windows.Forms.Button();
            this.checkBoxApresentaValorEmprestimo = new System.Windows.Forms.CheckBox();
            this.checkBoxApresentaValorLivro = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataFimLeitura_2 = new System.Windows.Forms.DateTimePicker();
            this.DataFimLeitura_1 = new System.Windows.Forms.DateTimePicker();
            this.DataInicioLeitura_2 = new System.Windows.Forms.DateTimePicker();
            this.DataDevolucao_2 = new System.Windows.Forms.DateTimePicker();
            this.DataDevolucao_1 = new System.Windows.Forms.DateTimePicker();
            this.DataInicioLeitura_1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DataEmprestimo_2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DataEmprestimo_1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxEmprestado = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxFormato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxStatus = new System.Windows.Forms.ComboBox();
            this.btnExibirInfoRelLivro = new System.Windows.Forms.Button();
            this.groupBoxRelFinanceiro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRelFinanceiro
            // 
            this.groupBoxRelFinanceiro.Controls.Add(this.btnExibirInfoRelFinanceiro);
            this.groupBoxRelFinanceiro.Controls.Add(this.checkBoxApresentaValorEmprestimo);
            this.groupBoxRelFinanceiro.Controls.Add(this.checkBoxApresentaValorLivro);
            this.groupBoxRelFinanceiro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxRelFinanceiro.Location = new System.Drawing.Point(10, 20);
            this.groupBoxRelFinanceiro.Margin = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.groupBoxRelFinanceiro.Name = "groupBoxRelFinanceiro";
            this.groupBoxRelFinanceiro.Size = new System.Drawing.Size(679, 160);
            this.groupBoxRelFinanceiro.TabIndex = 3;
            this.groupBoxRelFinanceiro.TabStop = false;
            this.groupBoxRelFinanceiro.Text = "Relatório Financeiro";
            // 
            // btnExibirInfoRelFinanceiro
            // 
            this.btnExibirInfoRelFinanceiro.Location = new System.Drawing.Point(13, 107);
            this.btnExibirInfoRelFinanceiro.Margin = new System.Windows.Forms.Padding(10);
            this.btnExibirInfoRelFinanceiro.Name = "btnExibirInfoRelFinanceiro";
            this.btnExibirInfoRelFinanceiro.Size = new System.Drawing.Size(170, 40);
            this.btnExibirInfoRelFinanceiro.TabIndex = 3;
            this.btnExibirInfoRelFinanceiro.Text = "Visualizar/Imprimir";
            this.btnExibirInfoRelFinanceiro.UseVisualStyleBackColor = true;
            this.btnExibirInfoRelFinanceiro.Click += new System.EventHandler(this.btnExibirInfoRelFinanceiro_Click);
            // 
            // checkBoxApresentaValorEmprestimo
            // 
            this.checkBoxApresentaValorEmprestimo.AutoSize = true;
            this.checkBoxApresentaValorEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApresentaValorEmprestimo.Location = new System.Drawing.Point(242, 37);
            this.checkBoxApresentaValorEmprestimo.Name = "checkBoxApresentaValorEmprestimo";
            this.checkBoxApresentaValorEmprestimo.Size = new System.Drawing.Size(279, 24);
            this.checkBoxApresentaValorEmprestimo.TabIndex = 2;
            this.checkBoxApresentaValorEmprestimo.Text = "Apresentar valores de empréstimo?";
            this.checkBoxApresentaValorEmprestimo.UseVisualStyleBackColor = true;
            // 
            // checkBoxApresentaValorLivro
            // 
            this.checkBoxApresentaValorLivro.AutoSize = true;
            this.checkBoxApresentaValorLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApresentaValorLivro.Location = new System.Drawing.Point(13, 37);
            this.checkBoxApresentaValorLivro.Name = "checkBoxApresentaValorLivro";
            this.checkBoxApresentaValorLivro.Size = new System.Drawing.Size(223, 24);
            this.checkBoxApresentaValorLivro.TabIndex = 1;
            this.checkBoxApresentaValorLivro.Text = "Apresentar valores de livro?";
            this.checkBoxApresentaValorLivro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.DataFimLeitura_2);
            this.groupBox1.Controls.Add(this.DataFimLeitura_1);
            this.groupBox1.Controls.Add(this.DataInicioLeitura_2);
            this.groupBox1.Controls.Add(this.DataDevolucao_2);
            this.groupBox1.Controls.Add(this.DataDevolucao_1);
            this.groupBox1.Controls.Add(this.DataInicioLeitura_1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.DataEmprestimo_2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DataEmprestimo_1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxEmprestado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BoxFormato);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BoxStatus);
            this.groupBox1.Controls.Add(this.btnExibirInfoRelLivro);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 276);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10, 10, 10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 429);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório de leitura/empréstimo";
            // 
            // DataFimLeitura_2
            // 
            this.DataFimLeitura_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataFimLeitura_2.CustomFormat = " ";
            this.DataFimLeitura_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataFimLeitura_2.Location = new System.Drawing.Point(392, 81);
            this.DataFimLeitura_2.Name = "DataFimLeitura_2";
            this.DataFimLeitura_2.Size = new System.Drawing.Size(141, 29);
            this.DataFimLeitura_2.TabIndex = 24;
            this.DataFimLeitura_2.ValueChanged += new System.EventHandler(this.DataFimLeitura_2_ValueChanged);
            // 
            // DataFimLeitura_1
            // 
            this.DataFimLeitura_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataFimLeitura_1.CustomFormat = " ";
            this.DataFimLeitura_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataFimLeitura_1.Location = new System.Drawing.Point(179, 81);
            this.DataFimLeitura_1.Name = "DataFimLeitura_1";
            this.DataFimLeitura_1.Size = new System.Drawing.Size(141, 29);
            this.DataFimLeitura_1.TabIndex = 23;
            this.DataFimLeitura_1.ValueChanged += new System.EventHandler(this.DataFimLeitura_1_ValueChanged);
            // 
            // DataInicioLeitura_2
            // 
            this.DataInicioLeitura_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataInicioLeitura_2.CustomFormat = " ";
            this.DataInicioLeitura_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataInicioLeitura_2.Location = new System.Drawing.Point(392, 41);
            this.DataInicioLeitura_2.Name = "DataInicioLeitura_2";
            this.DataInicioLeitura_2.Size = new System.Drawing.Size(141, 29);
            this.DataInicioLeitura_2.TabIndex = 22;
            this.DataInicioLeitura_2.ValueChanged += new System.EventHandler(this.DataInicioLeitura_2_ValueChanged);
            // 
            // DataDevolucao_2
            // 
            this.DataDevolucao_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataDevolucao_2.CustomFormat = " ";
            this.DataDevolucao_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataDevolucao_2.Location = new System.Drawing.Point(392, 303);
            this.DataDevolucao_2.Name = "DataDevolucao_2";
            this.DataDevolucao_2.Size = new System.Drawing.Size(157, 29);
            this.DataDevolucao_2.TabIndex = 21;
            this.DataDevolucao_2.Visible = false;
            this.DataDevolucao_2.ValueChanged += new System.EventHandler(this.DataDevolucao_2_ValueChanged);
            // 
            // DataDevolucao_1
            // 
            this.DataDevolucao_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataDevolucao_1.CustomFormat = " ";
            this.DataDevolucao_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataDevolucao_1.Location = new System.Drawing.Point(179, 303);
            this.DataDevolucao_1.Name = "DataDevolucao_1";
            this.DataDevolucao_1.Size = new System.Drawing.Size(141, 29);
            this.DataDevolucao_1.TabIndex = 20;
            this.DataDevolucao_1.Visible = false;
            this.DataDevolucao_1.ValueChanged += new System.EventHandler(this.DataDevolucao_1_ValueChanged);
            // 
            // DataInicioLeitura_1
            // 
            this.DataInicioLeitura_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataInicioLeitura_1.CustomFormat = " ";
            this.DataInicioLeitura_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataInicioLeitura_1.Location = new System.Drawing.Point(179, 41);
            this.DataInicioLeitura_1.Name = "DataInicioLeitura_1";
            this.DataInicioLeitura_1.Size = new System.Drawing.Size(141, 29);
            this.DataInicioLeitura_1.TabIndex = 17;
            this.DataInicioLeitura_1.ValueChanged += new System.EventHandler(this.DataInicioLeitura_1_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data Fim da leitura";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Data Início da leitura";
            // 
            // DataEmprestimo_2
            // 
            this.DataEmprestimo_2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataEmprestimo_2.CustomFormat = " ";
            this.DataEmprestimo_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataEmprestimo_2.Location = new System.Drawing.Point(392, 251);
            this.DataEmprestimo_2.Name = "DataEmprestimo_2";
            this.DataEmprestimo_2.Size = new System.Drawing.Size(157, 29);
            this.DataEmprestimo_2.TabIndex = 13;
            this.DataEmprestimo_2.Visible = false;
            this.DataEmprestimo_2.ValueChanged += new System.EventHandler(this.DataEmprestimo_2_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data Devolução";
            // 
            // DataEmprestimo_1
            // 
            this.DataEmprestimo_1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DataEmprestimo_1.CustomFormat = " ";
            this.DataEmprestimo_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataEmprestimo_1.Location = new System.Drawing.Point(179, 251);
            this.DataEmprestimo_1.Name = "DataEmprestimo_1";
            this.DataEmprestimo_1.Size = new System.Drawing.Size(141, 29);
            this.DataEmprestimo_1.TabIndex = 11;
            this.DataEmprestimo_1.Visible = false;
            this.DataEmprestimo_1.ValueChanged += new System.EventHandler(this.DataEmprestimo_1_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Empréstimo";
            // 
            // checkBoxEmprestado
            // 
            this.checkBoxEmprestado.AutoSize = true;
            this.checkBoxEmprestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEmprestado.Location = new System.Drawing.Point(242, 213);
            this.checkBoxEmprestado.Name = "checkBoxEmprestado";
            this.checkBoxEmprestado.Size = new System.Drawing.Size(124, 24);
            this.checkBoxEmprestado.TabIndex = 9;
            this.checkBoxEmprestado.Text = "Emprestado?";
            this.checkBoxEmprestado.UseVisualStyleBackColor = true;
            this.checkBoxEmprestado.CheckedChanged += new System.EventHandler(this.checkBoxEmprestado_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(310, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Formato";
            // 
            // BoxFormato
            // 
            this.BoxFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxFormato.FormattingEnabled = true;
            this.BoxFormato.Items.AddRange(new object[] {
            "Todos",
            "Digital",
            "Físico",
            "Audiolivro"});
            this.BoxFormato.Location = new System.Drawing.Point(385, 144);
            this.BoxFormato.Name = "BoxFormato";
            this.BoxFormato.Size = new System.Drawing.Size(157, 30);
            this.BoxFormato.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status da leitura";
            // 
            // BoxStatus
            // 
            this.BoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxStatus.FormattingEnabled = true;
            this.BoxStatus.Items.AddRange(new object[] {
            "Todos",
            "Lendo",
            "Lido",
            "Emprestado",
            "Devolvido"});
            this.BoxStatus.Location = new System.Drawing.Point(144, 144);
            this.BoxStatus.Name = "BoxStatus";
            this.BoxStatus.Size = new System.Drawing.Size(141, 30);
            this.BoxStatus.TabIndex = 5;
            // 
            // btnExibirInfoRelLivro
            // 
            this.btnExibirInfoRelLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExibirInfoRelLivro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirInfoRelLivro.Location = new System.Drawing.Point(13, 376);
            this.btnExibirInfoRelLivro.Margin = new System.Windows.Forms.Padding(10);
            this.btnExibirInfoRelLivro.Name = "btnExibirInfoRelLivro";
            this.btnExibirInfoRelLivro.Size = new System.Drawing.Size(170, 40);
            this.btnExibirInfoRelLivro.TabIndex = 4;
            this.btnExibirInfoRelLivro.Text = "Visualizar/Imprimir";
            this.btnExibirInfoRelLivro.UseVisualStyleBackColor = true;
            this.btnExibirInfoRelLivro.Click += new System.EventHandler(this.btnExibirInfoRelLivro_Click);
            // 
            // TelaRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxRelFinanceiro);
            this.Name = "TelaRelatorios";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.TelaRelatorios_Load);
            this.groupBoxRelFinanceiro.ResumeLayout(false);
            this.groupBoxRelFinanceiro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxRelFinanceiro;
        private System.Windows.Forms.CheckBox checkBoxApresentaValorLivro;
        private System.Windows.Forms.CheckBox checkBoxApresentaValorEmprestimo;
        private System.Windows.Forms.Button btnExibirInfoRelFinanceiro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExibirInfoRelLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxFormato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox BoxStatus;
        private System.Windows.Forms.DateTimePicker DataEmprestimo_2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DataEmprestimo_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxEmprestado;
        private System.Windows.Forms.DateTimePicker DataInicioLeitura_1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DataDevolucao_2;
        private System.Windows.Forms.DateTimePicker DataDevolucao_1;
        private System.Windows.Forms.DateTimePicker DataFimLeitura_2;
        private System.Windows.Forms.DateTimePicker DataFimLeitura_1;
        private System.Windows.Forms.DateTimePicker DataInicioLeitura_2;
    }
}

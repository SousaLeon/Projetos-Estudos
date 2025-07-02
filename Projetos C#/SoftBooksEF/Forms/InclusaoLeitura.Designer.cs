namespace Database_Books.Forms
{
    partial class InclusaoLeitura
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabIncluirLeitura = new System.Windows.Forms.TabControl();
            this.tabPageInfoLivro = new System.Windows.Forms.TabPage();
            this.checkBoxEmprestimo = new System.Windows.Forms.CheckBox();
            this.BoxLeitor = new System.Windows.Forms.ComboBox();
            this.DataFimLeituraEstimativa = new System.Windows.Forms.DateTimePicker();
            this.DataInicioLeitura = new System.Windows.Forms.DateTimePicker();
            this.BoxLivros = new System.Windows.Forms.ComboBox();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.lblDataEstimativa = new System.Windows.Forms.Label();
            this.lblDataInicio = new System.Windows.Forms.Label();
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.tabPageInfoEmprestimo = new System.Windows.Forms.TabPage();
            this.DataEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.DataDevolucao = new System.Windows.Forms.DateTimePicker();
            this.txtValorEmprestimo = new System.Windows.Forms.TextBox();
            this.txtLeitorEmprestimo = new System.Windows.Forms.TextBox();
            this.lblDataEmprestimo = new System.Windows.Forms.Label();
            this.lblDataDevolucao = new System.Windows.Forms.Label();
            this.lblValorEmprestimo = new System.Windows.Forms.Label();
            this.lblLeitorEmprestimo = new System.Windows.Forms.Label();
            this.btnIncluirLeituraLivro = new System.Windows.Forms.Button();
            this.tabIncluirLeitura.SuspendLayout();
            this.tabPageInfoLivro.SuspendLayout();
            this.tabPageInfoEmprestimo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(23, 508);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tabIncluirLeitura
            // 
            this.tabIncluirLeitura.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabIncluirLeitura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabIncluirLeitura.Controls.Add(this.tabPageInfoLivro);
            this.tabIncluirLeitura.Controls.Add(this.tabPageInfoEmprestimo);
            this.tabIncluirLeitura.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabIncluirLeitura.ItemSize = new System.Drawing.Size(128, 30);
            this.tabIncluirLeitura.Location = new System.Drawing.Point(19, 19);
            this.tabIncluirLeitura.Margin = new System.Windows.Forms.Padding(10, 10, 10, 30);
            this.tabIncluirLeitura.Name = "tabIncluirLeitura";
            this.tabIncluirLeitura.SelectedIndex = 0;
            this.tabIncluirLeitura.Size = new System.Drawing.Size(596, 456);
            this.tabIncluirLeitura.TabIndex = 3;
            this.tabIncluirLeitura.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabIncluirLeitura_Selecting);
            // 
            // tabPageInfoLivro
            // 
            this.tabPageInfoLivro.Controls.Add(this.checkBoxEmprestimo);
            this.tabPageInfoLivro.Controls.Add(this.BoxLeitor);
            this.tabPageInfoLivro.Controls.Add(this.DataFimLeituraEstimativa);
            this.tabPageInfoLivro.Controls.Add(this.DataInicioLeitura);
            this.tabPageInfoLivro.Controls.Add(this.BoxLivros);
            this.tabPageInfoLivro.Controls.Add(this.lblLeitor);
            this.tabPageInfoLivro.Controls.Add(this.lblDataEstimativa);
            this.tabPageInfoLivro.Controls.Add(this.lblDataInicio);
            this.tabPageInfoLivro.Controls.Add(this.lblNomeLivro);
            this.tabPageInfoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInfoLivro.Location = new System.Drawing.Point(4, 4);
            this.tabPageInfoLivro.Name = "tabPageInfoLivro";
            this.tabPageInfoLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfoLivro.Size = new System.Drawing.Size(588, 418);
            this.tabPageInfoLivro.TabIndex = 0;
            this.tabPageInfoLivro.Text = "Informações do livro";
            this.tabPageInfoLivro.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmprestimo
            // 
            this.checkBoxEmprestimo.AutoSize = true;
            this.checkBoxEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEmprestimo.Location = new System.Drawing.Point(394, 362);
            this.checkBoxEmprestimo.Margin = new System.Windows.Forms.Padding(20);
            this.checkBoxEmprestimo.Name = "checkBoxEmprestimo";
            this.checkBoxEmprestimo.Size = new System.Drawing.Size(174, 33);
            this.checkBoxEmprestimo.TabIndex = 12;
            this.checkBoxEmprestimo.Text = "Empréstimo?";
            this.checkBoxEmprestimo.UseVisualStyleBackColor = true;
            // 
            // BoxLeitor
            // 
            this.BoxLeitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxLeitor.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLeitor.FormattingEnabled = true;
            this.BoxLeitor.Location = new System.Drawing.Point(126, 165);
            this.BoxLeitor.Name = "BoxLeitor";
            this.BoxLeitor.Size = new System.Drawing.Size(297, 30);
            this.BoxLeitor.TabIndex = 9;
            // 
            // DataFimLeituraEstimativa
            // 
            this.DataFimLeituraEstimativa.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFimLeituraEstimativa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataFimLeituraEstimativa.Location = new System.Drawing.Point(20, 119);
            this.DataFimLeituraEstimativa.Name = "DataFimLeituraEstimativa";
            this.DataFimLeituraEstimativa.Size = new System.Drawing.Size(219, 29);
            this.DataFimLeituraEstimativa.TabIndex = 8;
            // 
            // DataInicioLeitura
            // 
            this.DataInicioLeitura.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataInicioLeitura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataInicioLeitura.Location = new System.Drawing.Point(270, 67);
            this.DataInicioLeitura.Name = "DataInicioLeitura";
            this.DataInicioLeitura.Size = new System.Drawing.Size(208, 29);
            this.DataInicioLeitura.TabIndex = 7;
            // 
            // BoxLivros
            // 
            this.BoxLivros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxLivros.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLivros.FormattingEnabled = true;
            this.BoxLivros.Location = new System.Drawing.Point(181, 13);
            this.BoxLivros.Name = "BoxLivros";
            this.BoxLivros.Size = new System.Drawing.Size(297, 30);
            this.BoxLivros.TabIndex = 5;
            // 
            // lblLeitor
            // 
            this.lblLeitor.AutoSize = true;
            this.lblLeitor.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeitor.Location = new System.Drawing.Point(12, 163);
            this.lblLeitor.Margin = new System.Windows.Forms.Padding(12);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(99, 28);
            this.lblLeitor.TabIndex = 4;
            this.lblLeitor.Text = "Leitor (a)";
            // 
            // lblDataEstimativa
            // 
            this.lblDataEstimativa.AutoSize = true;
            this.lblDataEstimativa.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEstimativa.Location = new System.Drawing.Point(254, 119);
            this.lblDataEstimativa.Margin = new System.Windows.Forms.Padding(12);
            this.lblDataEstimativa.Name = "lblDataEstimativa";
            this.lblDataEstimativa.Size = new System.Drawing.Size(319, 28);
            this.lblDataEstimativa.TabIndex = 3;
            this.lblDataEstimativa.Text = "Data final de leitura (estimativa)";
            // 
            // lblDataInicio
            // 
            this.lblDataInicio.AutoSize = true;
            this.lblDataInicio.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataInicio.Location = new System.Drawing.Point(15, 67);
            this.lblDataInicio.Margin = new System.Windows.Forms.Padding(12);
            this.lblDataInicio.Name = "lblDataInicio";
            this.lblDataInicio.Size = new System.Drawing.Size(240, 28);
            this.lblDataInicio.TabIndex = 2;
            this.lblDataInicio.Text = "Data de ínicio da leitura";
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLivro.Location = new System.Drawing.Point(15, 15);
            this.lblNomeLivro.Margin = new System.Windows.Forms.Padding(12);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(151, 28);
            this.lblNomeLivro.TabIndex = 0;
            this.lblNomeLivro.Text = "Nome do livro";
            // 
            // tabPageInfoEmprestimo
            // 
            this.tabPageInfoEmprestimo.Controls.Add(this.DataEmprestimo);
            this.tabPageInfoEmprestimo.Controls.Add(this.DataDevolucao);
            this.tabPageInfoEmprestimo.Controls.Add(this.txtValorEmprestimo);
            this.tabPageInfoEmprestimo.Controls.Add(this.txtLeitorEmprestimo);
            this.tabPageInfoEmprestimo.Controls.Add(this.lblDataEmprestimo);
            this.tabPageInfoEmprestimo.Controls.Add(this.lblDataDevolucao);
            this.tabPageInfoEmprestimo.Controls.Add(this.lblValorEmprestimo);
            this.tabPageInfoEmprestimo.Controls.Add(this.lblLeitorEmprestimo);
            this.tabPageInfoEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageInfoEmprestimo.Location = new System.Drawing.Point(4, 4);
            this.tabPageInfoEmprestimo.Name = "tabPageInfoEmprestimo";
            this.tabPageInfoEmprestimo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfoEmprestimo.Size = new System.Drawing.Size(588, 418);
            this.tabPageInfoEmprestimo.TabIndex = 1;
            this.tabPageInfoEmprestimo.Text = "Informações de empréstimo";
            this.tabPageInfoEmprestimo.UseVisualStyleBackColor = true;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataEmprestimo.Location = new System.Drawing.Point(239, 158);
            this.DataEmprestimo.Name = "DataEmprestimo";
            this.DataEmprestimo.Size = new System.Drawing.Size(219, 29);
            this.DataEmprestimo.TabIndex = 10;
            // 
            // DataDevolucao
            // 
            this.DataDevolucao.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataDevolucao.Location = new System.Drawing.Point(148, 110);
            this.DataDevolucao.Name = "DataDevolucao";
            this.DataDevolucao.Size = new System.Drawing.Size(219, 29);
            this.DataDevolucao.TabIndex = 9;
            // 
            // txtValorEmprestimo
            // 
            this.txtValorEmprestimo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorEmprestimo.Location = new System.Drawing.Point(244, 66);
            this.txtValorEmprestimo.Name = "txtValorEmprestimo";
            this.txtValorEmprestimo.Size = new System.Drawing.Size(127, 29);
            this.txtValorEmprestimo.TabIndex = 6;
            this.txtValorEmprestimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorEmprestimo_KeyPress);
            // 
            // txtLeitorEmprestimo
            // 
            this.txtLeitorEmprestimo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeitorEmprestimo.Location = new System.Drawing.Point(261, 14);
            this.txtLeitorEmprestimo.Name = "txtLeitorEmprestimo";
            this.txtLeitorEmprestimo.Size = new System.Drawing.Size(312, 29);
            this.txtLeitorEmprestimo.TabIndex = 5;
            // 
            // lblDataEmprestimo
            // 
            this.lblDataEmprestimo.AutoSize = true;
            this.lblDataEmprestimo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEmprestimo.Location = new System.Drawing.Point(15, 160);
            this.lblDataEmprestimo.Margin = new System.Windows.Forms.Padding(12);
            this.lblDataEmprestimo.Name = "lblDataEmprestimo";
            this.lblDataEmprestimo.Size = new System.Drawing.Size(209, 28);
            this.lblDataEmprestimo.TabIndex = 4;
            this.lblDataEmprestimo.Text = "Data do empréstimo";
            // 
            // lblDataDevolucao
            // 
            this.lblDataDevolucao.AutoSize = true;
            this.lblDataDevolucao.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDevolucao.Location = new System.Drawing.Point(382, 112);
            this.lblDataDevolucao.Margin = new System.Windows.Forms.Padding(12);
            this.lblDataDevolucao.Name = "lblDataDevolucao";
            this.lblDataDevolucao.Size = new System.Drawing.Size(191, 28);
            this.lblDataDevolucao.TabIndex = 3;
            this.lblDataDevolucao.Text = "Data da devolução";
            // 
            // lblValorEmprestimo
            // 
            this.lblValorEmprestimo.AutoSize = true;
            this.lblValorEmprestimo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorEmprestimo.Location = new System.Drawing.Point(15, 67);
            this.lblValorEmprestimo.Margin = new System.Windows.Forms.Padding(12);
            this.lblValorEmprestimo.Name = "lblValorEmprestimo";
            this.lblValorEmprestimo.Size = new System.Drawing.Size(214, 28);
            this.lblValorEmprestimo.TabIndex = 2;
            this.lblValorEmprestimo.Text = "Valor do empréstimo";
            // 
            // lblLeitorEmprestimo
            // 
            this.lblLeitorEmprestimo.AutoSize = true;
            this.lblLeitorEmprestimo.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeitorEmprestimo.Location = new System.Drawing.Point(15, 15);
            this.lblLeitorEmprestimo.Margin = new System.Windows.Forms.Padding(12);
            this.lblLeitorEmprestimo.Name = "lblLeitorEmprestimo";
            this.lblLeitorEmprestimo.Size = new System.Drawing.Size(231, 28);
            this.lblLeitorEmprestimo.TabIndex = 1;
            this.lblLeitorEmprestimo.Text = "Livro emprestado para";
            // 
            // btnIncluirLeituraLivro
            // 
            this.btnIncluirLeituraLivro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirLeituraLivro.Location = new System.Drawing.Point(481, 508);
            this.btnIncluirLeituraLivro.Margin = new System.Windows.Forms.Padding(12);
            this.btnIncluirLeituraLivro.Name = "btnIncluirLeituraLivro";
            this.btnIncluirLeituraLivro.Size = new System.Drawing.Size(130, 32);
            this.btnIncluirLeituraLivro.TabIndex = 4;
            this.btnIncluirLeituraLivro.Text = "Incluir";
            this.btnIncluirLeituraLivro.UseVisualStyleBackColor = true;
            this.btnIncluirLeituraLivro.Click += new System.EventHandler(this.btnIncluirLeituraLivro_Click);
            // 
            // InclusaoLeitura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnIncluirLeituraLivro);
            this.Controls.Add(this.tabIncluirLeitura);
            this.Controls.Add(this.btnCancelar);
            this.Name = "InclusaoLeitura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inclusão de livros para leitura/empréstimo";
            this.Load += new System.EventHandler(this.InclusaoLeitura_Load);
            this.tabIncluirLeitura.ResumeLayout(false);
            this.tabPageInfoLivro.ResumeLayout(false);
            this.tabPageInfoLivro.PerformLayout();
            this.tabPageInfoEmprestimo.ResumeLayout(false);
            this.tabPageInfoEmprestimo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tabIncluirLeitura;
        private System.Windows.Forms.TabPage tabPageInfoLivro;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.Label lblDataEstimativa;
        private System.Windows.Forms.Label lblDataInicio;
        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.TabPage tabPageInfoEmprestimo;
        private System.Windows.Forms.Label lblDataEmprestimo;
        private System.Windows.Forms.Label lblDataDevolucao;
        private System.Windows.Forms.Label lblValorEmprestimo;
        private System.Windows.Forms.Label lblLeitorEmprestimo;
        private System.Windows.Forms.ComboBox BoxLivros;
        private System.Windows.Forms.ComboBox BoxLeitor;
        private System.Windows.Forms.DateTimePicker DataFimLeituraEstimativa;
        private System.Windows.Forms.DateTimePicker DataInicioLeitura;
        private System.Windows.Forms.TextBox txtValorEmprestimo;
        private System.Windows.Forms.TextBox txtLeitorEmprestimo;
        private System.Windows.Forms.DateTimePicker DataEmprestimo;
        private System.Windows.Forms.DateTimePicker DataDevolucao;
        private System.Windows.Forms.Button btnIncluirLeituraLivro;
        private System.Windows.Forms.CheckBox checkBoxEmprestimo;
    }
}
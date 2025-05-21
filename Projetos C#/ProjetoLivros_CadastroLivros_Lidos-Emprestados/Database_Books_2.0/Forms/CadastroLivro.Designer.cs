namespace Database_Books
{
    partial class CadastroLivro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLivro));
            this.txtGeneroCadastro = new System.Windows.Forms.TextBox();
            this.txtAutorCadastro = new System.Windows.Forms.TextBox();
            this.txtNomeLivroCadastro = new System.Windows.Forms.TextBox();
            this.txtNSequenciaLivro = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFormatoCadastro = new System.Windows.Forms.ComboBox();
            this.lblFormatoCadastro = new System.Windows.Forms.Label();
            this.txtSeqCadastro = new System.Windows.Forms.TextBox();
            this.checkBoxSeqCadastro = new System.Windows.Forms.CheckBox();
            this.lblGeneroCadastro = new System.Windows.Forms.Label();
            this.lblAutorCadastro = new System.Windows.Forms.Label();
            this.lblNomeLivroCadastro = new System.Windows.Forms.Label();
            this.btnCancelarCadastro = new System.Windows.Forms.Button();
            this.btnIncluirLivro = new System.Windows.Forms.Button();
            this.tabControlCadastroLivro = new System.Windows.Forms.TabControl();
            this.tabInfoLivro = new System.Windows.Forms.TabPage();
            this.lblNPaginasCadastro = new System.Windows.Forms.Label();
            this.txtNPaginasCadastro = new System.Windows.Forms.MaskedTextBox();
            this.tabInfoSeq = new System.Windows.Forms.TabPage();
            this.txtValorLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlCadastroLivro.SuspendLayout();
            this.tabInfoLivro.SuspendLayout();
            this.tabInfoSeq.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGeneroCadastro
            // 
            this.txtGeneroCadastro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneroCadastro.Location = new System.Drawing.Point(184, 83);
            this.txtGeneroCadastro.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.txtGeneroCadastro.Name = "txtGeneroCadastro";
            this.txtGeneroCadastro.Size = new System.Drawing.Size(352, 29);
            this.txtGeneroCadastro.TabIndex = 3;
            // 
            // txtAutorCadastro
            // 
            this.txtAutorCadastro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutorCadastro.Location = new System.Drawing.Point(184, 187);
            this.txtAutorCadastro.Name = "txtAutorCadastro";
            this.txtAutorCadastro.Size = new System.Drawing.Size(352, 29);
            this.txtAutorCadastro.TabIndex = 7;
            // 
            // txtNomeLivroCadastro
            // 
            this.txtNomeLivroCadastro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivroCadastro.Location = new System.Drawing.Point(184, 31);
            this.txtNomeLivroCadastro.Margin = new System.Windows.Forms.Padding(10, 10, 10, 20);
            this.txtNomeLivroCadastro.Name = "txtNomeLivroCadastro";
            this.txtNomeLivroCadastro.Size = new System.Drawing.Size(352, 29);
            this.txtNomeLivroCadastro.TabIndex = 1;
            // 
            // txtNSequenciaLivro
            // 
            this.txtNSequenciaLivro.Location = new System.Drawing.Point(446, 51);
            this.txtNSequenciaLivro.Name = "txtNSequenciaLivro";
            this.txtNSequenciaLivro.ReadOnly = true;
            this.txtNSequenciaLivro.Size = new System.Drawing.Size(136, 28);
            this.txtNSequenciaLivro.TabIndex = 18;
            this.txtNSequenciaLivro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNSequenciaLivro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "N° Sequência";
            // 
            // comboBoxFormatoCadastro
            // 
            this.comboBoxFormatoCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormatoCadastro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFormatoCadastro.FormattingEnabled = true;
            this.comboBoxFormatoCadastro.Items.AddRange(new object[] {
            "Digital",
            "Físico",
            "Audiolivro"});
            this.comboBoxFormatoCadastro.Location = new System.Drawing.Point(184, 135);
            this.comboBoxFormatoCadastro.Name = "comboBoxFormatoCadastro";
            this.comboBoxFormatoCadastro.Size = new System.Drawing.Size(352, 30);
            this.comboBoxFormatoCadastro.TabIndex = 15;
            // 
            // lblFormatoCadastro
            // 
            this.lblFormatoCadastro.AutoSize = true;
            this.lblFormatoCadastro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoCadastro.Location = new System.Drawing.Point(13, 137);
            this.lblFormatoCadastro.Margin = new System.Windows.Forms.Padding(10);
            this.lblFormatoCadastro.Name = "lblFormatoCadastro";
            this.lblFormatoCadastro.Size = new System.Drawing.Size(172, 28);
            this.lblFormatoCadastro.TabIndex = 14;
            this.lblFormatoCadastro.Text = "Formato do livro";
            // 
            // txtSeqCadastro
            // 
            this.txtSeqCadastro.Location = new System.Drawing.Point(261, 124);
            this.txtSeqCadastro.Name = "txtSeqCadastro";
            this.txtSeqCadastro.ReadOnly = true;
            this.txtSeqCadastro.Size = new System.Drawing.Size(323, 28);
            this.txtSeqCadastro.TabIndex = 13;
            // 
            // checkBoxSeqCadastro
            // 
            this.checkBoxSeqCadastro.AutoSize = true;
            this.checkBoxSeqCadastro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSeqCadastro.Location = new System.Drawing.Point(205, 67);
            this.checkBoxSeqCadastro.Name = "checkBoxSeqCadastro";
            this.checkBoxSeqCadastro.Size = new System.Drawing.Size(139, 32);
            this.checkBoxSeqCadastro.TabIndex = 12;
            this.checkBoxSeqCadastro.Text = "Sequência?";
            this.checkBoxSeqCadastro.UseVisualStyleBackColor = true;
            this.checkBoxSeqCadastro.CheckedChanged += new System.EventHandler(this.checkBoxSeqCadastro_CheckedChanged);
            // 
            // lblGeneroCadastro
            // 
            this.lblGeneroCadastro.AutoSize = true;
            this.lblGeneroCadastro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneroCadastro.Location = new System.Drawing.Point(13, 84);
            this.lblGeneroCadastro.Margin = new System.Windows.Forms.Padding(10);
            this.lblGeneroCadastro.Name = "lblGeneroCadastro";
            this.lblGeneroCadastro.Size = new System.Drawing.Size(163, 28);
            this.lblGeneroCadastro.TabIndex = 2;
            this.lblGeneroCadastro.Text = "Gênero do livro";
            // 
            // lblAutorCadastro
            // 
            this.lblAutorCadastro.AutoSize = true;
            this.lblAutorCadastro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutorCadastro.Location = new System.Drawing.Point(13, 185);
            this.lblAutorCadastro.Margin = new System.Windows.Forms.Padding(10);
            this.lblAutorCadastro.Name = "lblAutorCadastro";
            this.lblAutorCadastro.Size = new System.Drawing.Size(146, 28);
            this.lblAutorCadastro.TabIndex = 6;
            this.lblAutorCadastro.Text = "Autor do livro";
            // 
            // lblNomeLivroCadastro
            // 
            this.lblNomeLivroCadastro.AutoSize = true;
            this.lblNomeLivroCadastro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLivroCadastro.Location = new System.Drawing.Point(13, 32);
            this.lblNomeLivroCadastro.Margin = new System.Windows.Forms.Padding(10);
            this.lblNomeLivroCadastro.Name = "lblNomeLivroCadastro";
            this.lblNomeLivroCadastro.Size = new System.Drawing.Size(151, 28);
            this.lblNomeLivroCadastro.TabIndex = 0;
            this.lblNomeLivroCadastro.Text = "Nome do livro";
            // 
            // btnCancelarCadastro
            // 
            this.btnCancelarCadastro.Location = new System.Drawing.Point(13, 515);
            this.btnCancelarCadastro.Name = "btnCancelarCadastro";
            this.btnCancelarCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCadastro.TabIndex = 2;
            this.btnCancelarCadastro.Text = "Cancelar";
            this.btnCancelarCadastro.UseVisualStyleBackColor = true;
            this.btnCancelarCadastro.Click += new System.EventHandler(this.btnCancelarCadastro_Click);
            // 
            // btnIncluirLivro
            // 
            this.btnIncluirLivro.Location = new System.Drawing.Point(543, 515);
            this.btnIncluirLivro.Name = "btnIncluirLivro";
            this.btnIncluirLivro.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirLivro.TabIndex = 3;
            this.btnIncluirLivro.Text = "Incluir";
            this.btnIncluirLivro.UseVisualStyleBackColor = true;
            this.btnIncluirLivro.Click += new System.EventHandler(this.btnIncluirLivro_Click);
            // 
            // tabControlCadastroLivro
            // 
            this.tabControlCadastroLivro.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlCadastroLivro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCadastroLivro.Controls.Add(this.tabInfoLivro);
            this.tabControlCadastroLivro.Controls.Add(this.tabInfoSeq);
            this.tabControlCadastroLivro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlCadastroLivro.Location = new System.Drawing.Point(13, 12);
            this.tabControlCadastroLivro.Name = "tabControlCadastroLivro";
            this.tabControlCadastroLivro.SelectedIndex = 0;
            this.tabControlCadastroLivro.Size = new System.Drawing.Size(605, 497);
            this.tabControlCadastroLivro.TabIndex = 0;
            // 
            // tabInfoLivro
            // 
            this.tabInfoLivro.Controls.Add(this.lblNPaginasCadastro);
            this.tabInfoLivro.Controls.Add(this.txtNPaginasCadastro);
            this.tabInfoLivro.Controls.Add(this.txtGeneroCadastro);
            this.tabInfoLivro.Controls.Add(this.txtAutorCadastro);
            this.tabInfoLivro.Controls.Add(this.comboBoxFormatoCadastro);
            this.tabInfoLivro.Controls.Add(this.txtNomeLivroCadastro);
            this.tabInfoLivro.Controls.Add(this.lblGeneroCadastro);
            this.tabInfoLivro.Controls.Add(this.lblFormatoCadastro);
            this.tabInfoLivro.Controls.Add(this.lblAutorCadastro);
            this.tabInfoLivro.Controls.Add(this.lblNomeLivroCadastro);
            this.tabInfoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInfoLivro.Location = new System.Drawing.Point(4, 4);
            this.tabInfoLivro.Margin = new System.Windows.Forms.Padding(10);
            this.tabInfoLivro.Name = "tabInfoLivro";
            this.tabInfoLivro.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoLivro.Size = new System.Drawing.Size(597, 463);
            this.tabInfoLivro.TabIndex = 0;
            this.tabInfoLivro.Text = "Informações de livro";
            this.tabInfoLivro.UseVisualStyleBackColor = true;
            // 
            // lblNPaginasCadastro
            // 
            this.lblNPaginasCadastro.AutoSize = true;
            this.lblNPaginasCadastro.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPaginasCadastro.Location = new System.Drawing.Point(20, 243);
            this.lblNPaginasCadastro.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.lblNPaginasCadastro.Name = "lblNPaginasCadastro";
            this.lblNPaginasCadastro.Size = new System.Drawing.Size(116, 28);
            this.lblNPaginasCadastro.TabIndex = 17;
            this.lblNPaginasCadastro.Text = "N° Páginas";
            // 
            // txtNPaginasCadastro
            // 
            this.txtNPaginasCadastro.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPaginasCadastro.Location = new System.Drawing.Point(25, 281);
            this.txtNPaginasCadastro.Mask = "00000";
            this.txtNPaginasCadastro.Name = "txtNPaginasCadastro";
            this.txtNPaginasCadastro.Size = new System.Drawing.Size(111, 29);
            this.txtNPaginasCadastro.TabIndex = 18;
            this.txtNPaginasCadastro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNPaginasCadastro.ValidatingType = typeof(int);
            this.txtNPaginasCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNPaginasCadastro_KeyPress);
            // 
            // tabInfoSeq
            // 
            this.tabInfoSeq.Controls.Add(this.txtValorLivro);
            this.tabInfoSeq.Controls.Add(this.label3);
            this.tabInfoSeq.Controls.Add(this.label2);
            this.tabInfoSeq.Controls.Add(this.txtNSequenciaLivro);
            this.tabInfoSeq.Controls.Add(this.txtSeqCadastro);
            this.tabInfoSeq.Controls.Add(this.label1);
            this.tabInfoSeq.Controls.Add(this.checkBoxSeqCadastro);
            this.tabInfoSeq.Location = new System.Drawing.Point(4, 4);
            this.tabInfoSeq.Name = "tabInfoSeq";
            this.tabInfoSeq.Padding = new System.Windows.Forms.Padding(3);
            this.tabInfoSeq.Size = new System.Drawing.Size(597, 463);
            this.tabInfoSeq.TabIndex = 1;
            this.tabInfoSeq.Text = "Informações de sequência";
            this.tabInfoSeq.UseVisualStyleBackColor = true;
            // 
            // txtValorLivro
            // 
            this.txtValorLivro.Location = new System.Drawing.Point(28, 58);
            this.txtValorLivro.MaxLength = 10;
            this.txtValorLivro.Name = "txtValorLivro";
            this.txtValorLivro.Size = new System.Drawing.Size(136, 28);
            this.txtValorLivro.TabIndex = 21;
            this.txtValorLivro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValorLivro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorLivro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Valor do livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome sequência";
            // 
            // CadastroLivro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(634, 561);
            this.ControlBox = false;
            this.Controls.Add(this.tabControlCadastroLivro);
            this.Controls.Add(this.btnIncluirLivro);
            this.Controls.Add(this.btnCancelarCadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CadastroLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Livro";
            this.tabControlCadastroLivro.ResumeLayout(false);
            this.tabInfoLivro.ResumeLayout(false);
            this.tabInfoLivro.PerformLayout();
            this.tabInfoSeq.ResumeLayout(false);
            this.tabInfoSeq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeLivroCadastro;
        private System.Windows.Forms.Label lblNomeLivroCadastro;
        private System.Windows.Forms.TextBox txtGeneroCadastro;
        private System.Windows.Forms.Label lblGeneroCadastro;
        private System.Windows.Forms.TextBox txtAutorCadastro;
        private System.Windows.Forms.Label lblAutorCadastro;
        private System.Windows.Forms.CheckBox checkBoxSeqCadastro;
        private System.Windows.Forms.TextBox txtSeqCadastro;
        private System.Windows.Forms.Button btnCancelarCadastro;
        private System.Windows.Forms.Button btnIncluirLivro;
        private System.Windows.Forms.ComboBox comboBoxFormatoCadastro;
        private System.Windows.Forms.Label lblFormatoCadastro;
        private System.Windows.Forms.MaskedTextBox txtNSequenciaLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlCadastroLivro;
        private System.Windows.Forms.TabPage tabInfoLivro;
        private System.Windows.Forms.TabPage tabInfoSeq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNPaginasCadastro;
        private System.Windows.Forms.MaskedTextBox txtNPaginasCadastro;
        private System.Windows.Forms.TextBox txtValorLivro;
    }
}
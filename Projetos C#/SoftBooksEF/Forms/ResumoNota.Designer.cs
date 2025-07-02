namespace Database_Books.Forms
{
    partial class ResumoNota
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
            this.txtResumoLivro = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnotacaoLivro = new System.Windows.Forms.RichTextBox();
            this.NotaNivel = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarResumoNota = new System.Windows.Forms.Button();
            this.btnCancelarResumoNota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NotaNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResumoLivro
            // 
            this.txtResumoLivro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResumoLivro.Location = new System.Drawing.Point(14, 40);
            this.txtResumoLivro.Margin = new System.Windows.Forms.Padding(5);
            this.txtResumoLivro.MaxLength = 200;
            this.txtResumoLivro.Name = "txtResumoLivro";
            this.txtResumoLivro.Size = new System.Drawing.Size(556, 150);
            this.txtResumoLivro.TabIndex = 0;
            this.txtResumoLivro.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resumo do livro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "O que eu achei do livro";
            // 
            // txtAnotacaoLivro
            // 
            this.txtAnotacaoLivro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnotacaoLivro.Location = new System.Drawing.Point(14, 235);
            this.txtAnotacaoLivro.Margin = new System.Windows.Forms.Padding(5);
            this.txtAnotacaoLivro.MaxLength = 200;
            this.txtAnotacaoLivro.Name = "txtAnotacaoLivro";
            this.txtAnotacaoLivro.Size = new System.Drawing.Size(556, 150);
            this.txtAnotacaoLivro.TabIndex = 4;
            this.txtAnotacaoLivro.Text = "";
            // 
            // NotaNivel
            // 
            this.NotaNivel.BackColor = System.Drawing.SystemColors.Control;
            this.NotaNivel.LargeChange = 1;
            this.NotaNivel.Location = new System.Drawing.Point(12, 393);
            this.NotaNivel.Name = "NotaNivel";
            this.NotaNivel.Size = new System.Drawing.Size(217, 45);
            this.NotaNivel.TabIndex = 5;
            this.NotaNivel.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 10, 10, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota";
            // 
            // btnSalvarResumoNota
            // 
            this.btnSalvarResumoNota.Location = new System.Drawing.Point(414, 453);
            this.btnSalvarResumoNota.Name = "btnSalvarResumoNota";
            this.btnSalvarResumoNota.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarResumoNota.TabIndex = 7;
            this.btnSalvarResumoNota.Text = "Salvar";
            this.btnSalvarResumoNota.UseVisualStyleBackColor = true;
            this.btnSalvarResumoNota.Click += new System.EventHandler(this.btnSalvarResumoNota_Click);
            // 
            // btnCancelarResumoNota
            // 
            this.btnCancelarResumoNota.Location = new System.Drawing.Point(495, 453);
            this.btnCancelarResumoNota.Name = "btnCancelarResumoNota";
            this.btnCancelarResumoNota.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarResumoNota.TabIndex = 8;
            this.btnCancelarResumoNota.Text = "Cancelar";
            this.btnCancelarResumoNota.UseVisualStyleBackColor = true;
            this.btnCancelarResumoNota.Click += new System.EventHandler(this.btnCancelarResumoNota_Click);
            // 
            // ResumoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 488);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarResumoNota);
            this.Controls.Add(this.btnSalvarResumoNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NotaNivel);
            this.Controls.Add(this.txtAnotacaoLivro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResumoLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResumoNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumo, anotação e nota do livro";
            this.Load += new System.EventHandler(this.ResumoNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotaNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtResumoLivro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtAnotacaoLivro;
        private System.Windows.Forms.TrackBar NotaNivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvarResumoNota;
        private System.Windows.Forms.Button btnCancelarResumoNota;
    }
}
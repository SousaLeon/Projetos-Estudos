using System.Drawing;

namespace Database_Books
{
    partial class FormLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblLeitor = new System.Windows.Forms.Label();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.lblSenhaUser = new System.Windows.Forms.Label();
            this.btnEsqueciSenha = new System.Windows.Forms.Button();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.ImageBook = new System.Windows.Forms.PictureBox();
            this.ImageGlasses = new System.Windows.Forms.PictureBox();
            this.txtSenhaUser = new System.Windows.Forms.TextBox();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGlasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe Script", 20.25F);
            this.lblBemVindo.Location = new System.Drawing.Point(226, 111);
            this.lblBemVindo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(178, 42);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem Vindo";
            // 
            // lblLeitor
            // 
            this.lblLeitor.Font = new System.Drawing.Font("Segoe Script", 20.25F);
            this.lblLeitor.Location = new System.Drawing.Point(197, 153);
            this.lblLeitor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLeitor.Name = "lblLeitor";
            this.lblLeitor.Size = new System.Drawing.Size(237, 52);
            this.lblLeitor.TabIndex = 7;
            this.lblLeitor.Text = "Leitores";
            this.lblLeitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.Font = new System.Drawing.Font("Segoe Script", 20.25F);
            this.lblNomeUser.Location = new System.Drawing.Point(48, 291);
            this.lblNomeUser.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(136, 52);
            this.lblNomeUser.TabIndex = 5;
            this.lblNomeUser.Text = "Nome";
            this.lblNomeUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSenhaUser
            // 
            this.lblSenhaUser.Font = new System.Drawing.Font("Segoe Script", 20.25F);
            this.lblSenhaUser.Location = new System.Drawing.Point(48, 367);
            this.lblSenhaUser.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblSenhaUser.Name = "lblSenhaUser";
            this.lblSenhaUser.Size = new System.Drawing.Size(144, 52);
            this.lblSenhaUser.TabIndex = 6;
            this.lblSenhaUser.Text = "Senha";
            this.lblSenhaUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEsqueciSenha
            // 
            this.btnEsqueciSenha.Location = new System.Drawing.Point(13, 559);
            this.btnEsqueciSenha.Margin = new System.Windows.Forms.Padding(4);
            this.btnEsqueciSenha.Name = "btnEsqueciSenha";
            this.btnEsqueciSenha.Size = new System.Drawing.Size(176, 28);
            this.btnEsqueciSenha.TabIndex = 4;
            this.btnEsqueciSenha.Text = "Esqueci minha senha";
            this.btnEsqueciSenha.UseVisualStyleBackColor = true;
            this.btnEsqueciSenha.Click += new System.EventHandler(this.btnEsqueciSenha_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.Location = new System.Drawing.Point(333, 453);
            this.btnAcessar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(107, 28);
            this.btnAcessar.TabIndex = 3;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // ImageBook
            // 
            this.ImageBook.BackColor = System.Drawing.Color.Transparent;
            this.ImageBook.Image = ((System.Drawing.Image)(resources.GetObject("ImageBook.Image")));
            this.ImageBook.Location = new System.Drawing.Point(343, 209);
            this.ImageBook.Margin = new System.Windows.Forms.Padding(4);
            this.ImageBook.Name = "ImageBook";
            this.ImageBook.Size = new System.Drawing.Size(97, 39);
            this.ImageBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBook.TabIndex = 3;
            this.ImageBook.TabStop = false;
            // 
            // ImageGlasses
            // 
            this.ImageGlasses.BackColor = System.Drawing.Color.Transparent;
            this.ImageGlasses.Image = ((System.Drawing.Image)(resources.GetObject("ImageGlasses.Image")));
            this.ImageGlasses.Location = new System.Drawing.Point(177, 209);
            this.ImageGlasses.Margin = new System.Windows.Forms.Padding(4);
            this.ImageGlasses.Name = "ImageGlasses";
            this.ImageGlasses.Size = new System.Drawing.Size(97, 39);
            this.ImageGlasses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageGlasses.TabIndex = 2;
            this.ImageGlasses.TabStop = false;
            // 
            // txtSenhaUser
            // 
            this.txtSenhaUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUser.Location = new System.Drawing.Point(177, 367);
            this.txtSenhaUser.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtSenhaUser.MaxLength = 20;
            this.txtSenhaUser.Name = "txtSenhaUser";
            this.txtSenhaUser.PasswordChar = '*';
            this.txtSenhaUser.Size = new System.Drawing.Size(263, 34);
            this.txtSenhaUser.TabIndex = 2;
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUser.Location = new System.Drawing.Point(177, 300);
            this.txtNomeUser.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txtNomeUser.MaxLength = 20;
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(263, 34);
            this.txtNomeUser.TabIndex = 1;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.txtSenhaUser);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.btnEsqueciSenha);
            this.Controls.Add(this.lblSenhaUser);
            this.Controls.Add(this.ImageBook);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.ImageGlasses);
            this.Controls.Add(this.lblLeitor);
            this.Controls.Add(this.lblBemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageGlasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblLeitor;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.Label lblSenhaUser;
        private System.Windows.Forms.Button btnEsqueciSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.PictureBox ImageBook;
        private System.Windows.Forms.PictureBox ImageGlasses;
        private System.Windows.Forms.TextBox txtSenhaUser;
        private System.Windows.Forms.TextBox txtNomeUser;
    }
}


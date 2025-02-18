namespace DB_Cadastro
{
    partial class MenuInicial
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
            this.Panel = new System.Windows.Forms.Panel();
            this.listUsers = new System.Windows.Forms.ListBox();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.txtNomeUser = new System.Windows.Forms.TextBox();
            this.lblEmailUser = new System.Windows.Forms.Label();
            this.txtEmailUser = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblLoginNome = new System.Windows.Forms.Label();
            this.txtLoginNome = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Panel.Controls.Add(this.listUsers);
            this.Panel.Controls.Add(this.lblUsers);
            this.Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(180, 461);
            this.Panel.TabIndex = 0;
            // 
            // listUsers
            // 
            this.listUsers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listUsers.FormattingEnabled = true;
            this.listUsers.ItemHeight = 16;
            this.listUsers.Location = new System.Drawing.Point(15, 37);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(148, 400);
            this.listUsers.Sorted = true;
            this.listUsers.TabIndex = 1;
            this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(12, 9);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(151, 16);
            this.lblUsers.TabIndex = 0;
            this.lblUsers.Text = "Usuários do Sistema";
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUser.Location = new System.Drawing.Point(224, 110);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(160, 25);
            this.lblNomeUser.TabIndex = 1;
            this.lblNomeUser.Text = "Nome Usuário";
            // 
            // txtNomeUser
            // 
            this.txtNomeUser.Location = new System.Drawing.Point(405, 115);
            this.txtNomeUser.MaxLength = 30;
            this.txtNomeUser.Name = "txtNomeUser";
            this.txtNomeUser.Size = new System.Drawing.Size(317, 20);
            this.txtNomeUser.TabIndex = 2;
            // 
            // lblEmailUser
            // 
            this.lblEmailUser.AutoSize = true;
            this.lblEmailUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblEmailUser.Location = new System.Drawing.Point(224, 150);
            this.lblEmailUser.Name = "lblEmailUser";
            this.lblEmailUser.Size = new System.Drawing.Size(158, 25);
            this.lblEmailUser.TabIndex = 3;
            this.lblEmailUser.Text = "Email Usuário";
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Location = new System.Drawing.Point(405, 156);
            this.txtEmailUser.MaxLength = 20;
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(317, 20);
            this.txtEmailUser.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(229, 381);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(310, 381);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(391, 381);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblLoginNome
            // 
            this.lblLoginNome.AutoSize = true;
            this.lblLoginNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginNome.Location = new System.Drawing.Point(224, 37);
            this.lblLoginNome.Name = "lblLoginNome";
            this.lblLoginNome.Size = new System.Drawing.Size(137, 25);
            this.lblLoginNome.TabIndex = 8;
            this.lblLoginNome.Text = "Nome Login";
            // 
            // txtLoginNome
            // 
            this.txtLoginNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginNome.Location = new System.Drawing.Point(379, 41);
            this.txtLoginNome.MaxLength = 30;
            this.txtLoginNome.Name = "txtLoginNome";
            this.txtLoginNome.Size = new System.Drawing.Size(120, 22);
            this.txtLoginNome.TabIndex = 9;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginSenha.Location = new System.Drawing.Point(379, 66);
            this.txtLoginSenha.MaxLength = 10;
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.PasswordChar = '*';
            this.txtLoginSenha.Size = new System.Drawing.Size(120, 22);
            this.txtLoginSenha.TabIndex = 11;
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblLoginSenha.Location = new System.Drawing.Point(224, 66);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(144, 25);
            this.lblLoginSenha.TabIndex = 10;
            this.lblLoginSenha.Text = "Senha Login";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(472, 381);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.lblLoginSenha);
            this.Controls.Add(this.txtLoginNome);
            this.Controls.Add(this.lblLoginNome);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtEmailUser);
            this.Controls.Add(this.lblEmailUser);
            this.Controls.Add(this.txtNomeUser);
            this.Controls.Add(this.lblNomeUser);
            this.Controls.Add(this.Panel);
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuInicial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuInicial_FormClosed);
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.TextBox txtNomeUser;
        private System.Windows.Forms.Label lblEmailUser;
        private System.Windows.Forms.TextBox txtEmailUser;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblLoginNome;
        private System.Windows.Forms.TextBox txtLoginNome;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Button btnLimpar;
    }
}
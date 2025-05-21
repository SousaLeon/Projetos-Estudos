namespace Database_Books.ControlUser
{
    partial class TelaUsuarios
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
            this.GridViewUsuario = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloqueado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.btnLimparUsuario = new System.Windows.Forms.Button();
            this.groupBoxUsuarios = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNomeUsuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxUserBloqueado = new System.Windows.Forms.CheckBox();
            this.BoxPerguntaCidade = new System.Windows.Forms.ComboBox();
            this.txtSenhaUsuario = new System.Windows.Forms.TextBox();
            this.BoxPerguntaObjeto = new System.Windows.Forms.ComboBox();
            this.lblSenhaUsuario = new System.Windows.Forms.Label();
            this.BoxPerguntaCachorro = new System.Windows.Forms.ComboBox();
            this.txtNomeLoginUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeLoginUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).BeginInit();
            this.groupBoxUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridViewUsuario
            // 
            this.GridViewUsuario.AllowUserToAddRows = false;
            this.GridViewUsuario.AllowUserToDeleteRows = false;
            this.GridViewUsuario.AllowUserToResizeColumns = false;
            this.GridViewUsuario.AllowUserToResizeRows = false;
            this.GridViewUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridViewUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UsuarioLogin,
            this.Bloqueado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridViewUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewUsuario.Location = new System.Drawing.Point(67, 62);
            this.GridViewUsuario.Margin = new System.Windows.Forms.Padding(67, 62, 67, 74);
            this.GridViewUsuario.Name = "GridViewUsuario";
            this.GridViewUsuario.RowTemplate.Height = 40;
            this.GridViewUsuario.Size = new System.Drawing.Size(612, 585);
            this.GridViewUsuario.TabIndex = 3;
            this.GridViewUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewUsuario_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UsuarioLogin.HeaderText = "Usuario";
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.ReadOnly = true;
            // 
            // Bloqueado
            // 
            this.Bloqueado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Bloqueado.HeaderText = "Bloqueado?";
            this.Bloqueado.Name = "Bloqueado";
            this.Bloqueado.ReadOnly = true;
            this.Bloqueado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Bloqueado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarUsuario.Location = new System.Drawing.Point(812, 667);
            this.btnSalvarUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnSalvarUsuario.TabIndex = 2;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.btnSalvarUsuario_Click);
            // 
            // btnLimparUsuario
            // 
            this.btnLimparUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimparUsuario.Location = new System.Drawing.Point(1113, 667);
            this.btnLimparUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.btnLimparUsuario.Name = "btnLimparUsuario";
            this.btnLimparUsuario.Size = new System.Drawing.Size(100, 28);
            this.btnLimparUsuario.TabIndex = 0;
            this.btnLimparUsuario.Text = "Limpar";
            this.btnLimparUsuario.UseVisualStyleBackColor = true;
            this.btnLimparUsuario.Click += new System.EventHandler(this.btnLimparUsuario_Click);
            // 
            // groupBoxUsuarios
            // 
            this.groupBoxUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUsuarios.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBoxUsuarios.Controls.Add(this.label5);
            this.groupBoxUsuarios.Controls.Add(this.txtNomeUsuario);
            this.groupBoxUsuarios.Controls.Add(this.label4);
            this.groupBoxUsuarios.Controls.Add(this.lblNomeUsuario);
            this.groupBoxUsuarios.Controls.Add(this.label3);
            this.groupBoxUsuarios.Controls.Add(this.checkBoxUserBloqueado);
            this.groupBoxUsuarios.Controls.Add(this.BoxPerguntaCidade);
            this.groupBoxUsuarios.Controls.Add(this.txtSenhaUsuario);
            this.groupBoxUsuarios.Controls.Add(this.BoxPerguntaObjeto);
            this.groupBoxUsuarios.Controls.Add(this.lblSenhaUsuario);
            this.groupBoxUsuarios.Controls.Add(this.BoxPerguntaCachorro);
            this.groupBoxUsuarios.Controls.Add(this.txtNomeLoginUsuario);
            this.groupBoxUsuarios.Controls.Add(this.label2);
            this.groupBoxUsuarios.Controls.Add(this.lblNomeLoginUsuario);
            this.groupBoxUsuarios.Controls.Add(this.label1);
            this.groupBoxUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBoxUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsuarios.Location = new System.Drawing.Point(812, 62);
            this.groupBoxUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxUsuarios.Name = "groupBoxUsuarios";
            this.groupBoxUsuarios.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxUsuarios.Size = new System.Drawing.Size(401, 585);
            this.groupBoxUsuarios.TabIndex = 4;
            this.groupBoxUsuarios.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nome Cidade";
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuario.Location = new System.Drawing.Point(161, 107);
            this.txtNomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(231, 26);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 468);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome Objeto";
            // 
            // lblNomeUsuario
            // 
            this.lblNomeUsuario.AutoSize = true;
            this.lblNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuario.Location = new System.Drawing.Point(17, 107);
            this.lblNomeUsuario.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblNomeUsuario.Name = "lblNomeUsuario";
            this.lblNomeUsuario.Size = new System.Drawing.Size(110, 20);
            this.lblNomeUsuario.TabIndex = 14;
            this.lblNomeUsuario.Text = "Nome Usuário";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 411);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome Cachorro";
            // 
            // checkBoxUserBloqueado
            // 
            this.checkBoxUserBloqueado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUserBloqueado.AutoSize = true;
            this.checkBoxUserBloqueado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUserBloqueado.Location = new System.Drawing.Point(23, 247);
            this.checkBoxUserBloqueado.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxUserBloqueado.Name = "checkBoxUserBloqueado";
            this.checkBoxUserBloqueado.Size = new System.Drawing.Size(173, 24);
            this.checkBoxUserBloqueado.TabIndex = 11;
            this.checkBoxUserBloqueado.Text = "Usuário Bloqueado?";
            this.checkBoxUserBloqueado.UseVisualStyleBackColor = true;
            // 
            // BoxPerguntaCidade
            // 
            this.BoxPerguntaCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxPerguntaCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxPerguntaCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPerguntaCidade.FormattingEnabled = true;
            this.BoxPerguntaCidade.Items.AddRange(new object[] {
            "Paris",
            "Florianópolis",
            "Washington DC",
            "Barcelona",
            "Orlando"});
            this.BoxPerguntaCidade.Location = new System.Drawing.Point(167, 521);
            this.BoxPerguntaCidade.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.BoxPerguntaCidade.Name = "BoxPerguntaCidade";
            this.BoxPerguntaCidade.Size = new System.Drawing.Size(203, 24);
            this.BoxPerguntaCidade.TabIndex = 6;
            // 
            // txtSenhaUsuario
            // 
            this.txtSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaUsuario.Location = new System.Drawing.Point(160, 206);
            this.txtSenhaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaUsuario.Name = "txtSenhaUsuario";
            this.txtSenhaUsuario.PasswordChar = '*';
            this.txtSenhaUsuario.Size = new System.Drawing.Size(232, 26);
            this.txtSenhaUsuario.TabIndex = 3;
            // 
            // BoxPerguntaObjeto
            // 
            this.BoxPerguntaObjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxPerguntaObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxPerguntaObjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPerguntaObjeto.FormattingEnabled = true;
            this.BoxPerguntaObjeto.Items.AddRange(new object[] {
            "Bola",
            "Caderno",
            "Mesa",
            "Garrafa",
            "Cama"});
            this.BoxPerguntaObjeto.Location = new System.Drawing.Point(167, 464);
            this.BoxPerguntaObjeto.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.BoxPerguntaObjeto.Name = "BoxPerguntaObjeto";
            this.BoxPerguntaObjeto.Size = new System.Drawing.Size(203, 24);
            this.BoxPerguntaObjeto.TabIndex = 5;
            // 
            // lblSenhaUsuario
            // 
            this.lblSenhaUsuario.AutoSize = true;
            this.lblSenhaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaUsuario.Location = new System.Drawing.Point(17, 206);
            this.lblSenhaUsuario.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblSenhaUsuario.Name = "lblSenhaUsuario";
            this.lblSenhaUsuario.Size = new System.Drawing.Size(99, 20);
            this.lblSenhaUsuario.TabIndex = 12;
            this.lblSenhaUsuario.Text = "Senha Login";
            // 
            // BoxPerguntaCachorro
            // 
            this.BoxPerguntaCachorro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxPerguntaCachorro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxPerguntaCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxPerguntaCachorro.FormattingEnabled = true;
            this.BoxPerguntaCachorro.Items.AddRange(new object[] {
            "Bob",
            "Dingo",
            "Domo",
            "Xuxu",
            "Stetiz"});
            this.BoxPerguntaCachorro.Location = new System.Drawing.Point(166, 408);
            this.BoxPerguntaCachorro.Margin = new System.Windows.Forms.Padding(20, 18, 20, 18);
            this.BoxPerguntaCachorro.Name = "BoxPerguntaCachorro";
            this.BoxPerguntaCachorro.Size = new System.Drawing.Size(203, 24);
            this.BoxPerguntaCachorro.TabIndex = 4;
            // 
            // txtNomeLoginUsuario
            // 
            this.txtNomeLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLoginUsuario.Location = new System.Drawing.Point(160, 156);
            this.txtNomeLoginUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeLoginUsuario.Name = "txtNomeLoginUsuario";
            this.txtNomeLoginUsuario.Size = new System.Drawing.Size(232, 26);
            this.txtNomeLoginUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Informações para recuperação de senha";
            // 
            // lblNomeLoginUsuario
            // 
            this.lblNomeLoginUsuario.AutoSize = true;
            this.lblNomeLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLoginUsuario.Location = new System.Drawing.Point(17, 156);
            this.lblNomeLoginUsuario.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.lblNomeLoginUsuario.Name = "lblNomeLoginUsuario";
            this.lblNomeLoginUsuario.Size = new System.Drawing.Size(94, 20);
            this.lblNomeLoginUsuario.TabIndex = 13;
            this.lblNomeLoginUsuario.Text = "Nome Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(33, 12, 33, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações do Usuário";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncluir.Location = new System.Drawing.Point(963, 667);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 25);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(100, 28);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // TelaUsuarios
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.groupBoxUsuarios);
            this.Controls.Add(this.btnLimparUsuario);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.GridViewUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaUsuarios";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewUsuario)).EndInit();
            this.groupBoxUsuarios.ResumeLayout(false);
            this.groupBoxUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewUsuario;
        private System.Windows.Forms.Button btnSalvarUsuario;
        private System.Windows.Forms.Button btnLimparUsuario;
        private System.Windows.Forms.GroupBox groupBoxUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaUsuario;
        private System.Windows.Forms.Label lblSenhaUsuario;
        private System.Windows.Forms.TextBox txtNomeLoginUsuario;
        private System.Windows.Forms.Label lblNomeLoginUsuario;
        private System.Windows.Forms.CheckBox checkBoxUserBloqueado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BoxPerguntaCidade;
        private System.Windows.Forms.ComboBox BoxPerguntaObjeto;
        private System.Windows.Forms.ComboBox BoxPerguntaCachorro;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Label lblNomeUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloqueado;
        private System.Windows.Forms.Button btnIncluir;
    }
}

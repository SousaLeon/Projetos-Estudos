using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;


namespace Database_Books
{
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }        
        public string TxtNomeUser
        {
            get { return txtNomeUser.Text; }
            set { txtNomeUser.Text = value; }
        }

        public string NomeUsuario { get; private set; }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string hash = "";
            bool valido = false;

            if (string.IsNullOrWhiteSpace(txtNomeUser.Text) || string.IsNullOrWhiteSpace(txtSenhaUser.Text))
            {
                MessageBox.Show("Há informações faltando ser mencionadas, Usuário ou Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryNomeUsuario, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeLogin", txtNomeUser.Text);

                        object resultado = CommandSql.ExecuteScalar();

                        if (resultado != null)
                        {
                            NomeUsuario = resultado.ToString();
                        }                        
                    }

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryLogin, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeLogin", txtNomeUser.Text);

                        object resultado = CommandSql.ExecuteScalar();

                        if (resultado != null)
                        {
                            hash = resultado.ToString();
                            valido = BCrypt.Net.BCrypt.Verify(txtSenhaUser.Text, hash);
                        }

                        if (valido)
                        {
                            this.Hide();
                            ScreenBook screenBook = new ScreenBook(this);
                            screenBook.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorreto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSenhaUser.Clear();
                            txtNomeUser.Focus();
                            return;
                        }                        
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar com banco de dados para acesso ao sistema! " + ex.Message, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeUser.Text))
            {
                MessageBox.Show("Informe o nome do usuário que esqueceu a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryNomeLogin, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeLogin", txtNomeUser.Text);

                        using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                        {
                            if (ReaderSql.Read())
                            {
                                EsqueciSenha ES = new EsqueciSenha(this);
                                ES.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Nome de usuário não existe no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }                            
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um erro inesperado ao tentar consultar este nome de usuário! \n" + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

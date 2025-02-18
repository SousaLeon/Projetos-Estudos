using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DB_Cadastro
{
    public partial class Login: Form
    {
        public Login()
        {
            InitializeComponent();
        }

        void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection ConnectionSQL = new MySqlConnection(DB_Variaveis.StringConnection))
                {
                    ConnectionSQL.Open();

                    string Query = "SELECT SENHA FROM LOGIN WHERE USUARIO = @Usuario";

                    using (MySqlCommand CommandSQL = new MySqlCommand(Query, ConnectionSQL))
                    {
                        // Usa parâmetros para evitar SQL Injection
                        CommandSQL.Parameters.AddWithValue("@Usuario", TxtNomeLogin.Text);

                        // Executa o comando e obtém a senha
                        object resultado = CommandSQL.ExecuteScalar();

                        if (resultado != null && resultado.ToString() == txtSenha.Text)
                        {
                            MenuInicial MI = new MenuInicial();
                            Hide();
                            MI.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou Senha incorretos.");
                            txtSenha.Text = "";
                            TxtNomeLogin.Focus();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Usuário não encontrado no banco de dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
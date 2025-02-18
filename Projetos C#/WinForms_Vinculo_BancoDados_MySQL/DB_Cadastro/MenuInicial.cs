using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cadastro
{
    public partial class MenuInicial: Form
    {
        public MenuInicial()
        {
            InitializeComponent();            
        }
        void MenuInicial_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection ConnectionSQL = new MySqlConnection(DB_Variaveis.StringConnection))
                {
                    ConnectionSQL.Open();
                    string Query = "SELECT USUARIO FROM LOGIN";

                    using (MySqlCommand CommandSQL = new MySqlCommand(Query, ConnectionSQL))
                    {
                        using (MySqlDataReader reader = CommandSQL.ExecuteReader())
                        {
                            while (reader.Read()) // Percorre todas as linhas do resultado
                            {
                                listUsers.Items.Add(reader["USUARIO"].ToString());
                            }                            
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao iniciar as informações da lista de usuários. " + Ex.Message);
            }
        }
        void listUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem == null)
            {
                return; // Sai do método se nenhum item estiver selecionado
            }

            txtEmailUser.Clear();
            txtLoginNome.Clear();
            txtLoginSenha.Clear();
            txtNomeUser.Clear();
            try
            {
                string selectedItem = listUsers.SelectedItem.ToString();

                using (MySqlConnection ConnectionSQL = new MySqlConnection(DB_Variaveis.StringConnection))
                {
                    ConnectionSQL.Open();

                    //string QueryNomePessoa = "SELECT NOME FROM PESSOAS WHERE NOMELOGIN = @NomePessoa";
                    //string QueryNomeLogin = "SELECT USUARIO FROM LOGIN WHERE USUARIO = @NomeLogin";
                    //string QueryNomeSenha = "SELECT SENHA FROM LOGIN WHERE USUARIO = @Senha";
                    //string QueryEmail = "SELECT EMAIL FROM PESSOAS WHERE NOMELOGIN = @Email";

                    //using (MySqlCommand CommandSQL = new MySqlCommand(QueryNomePessoa, ConnectionSQL))
                    //{
                    //    CommandSQL.Parameters.AddWithValue("@NomePessoa", selectedItem);
                    //    object ResulNome = CommandSQL.ExecuteScalar();
                    //    txtNomeUser.Text = ResulNome.ToString();
                    //}
                    //using (MySqlCommand CommandSQL = new MySqlCommand(QueryNomeLogin, ConnectionSQL))
                    //{
                    //    CommandSQL.Parameters.AddWithValue("@NomeLogin", selectedItem);
                    //    object ResulNome = CommandSQL.ExecuteScalar();
                    //    txtLoginNome.Text = ResulNome.ToString();
                    //}
                    //using (MySqlCommand CommandSQL = new MySqlCommand(QueryEmail, ConnectionSQL))
                    //{
                    //    CommandSQL.Parameters.AddWithValue("@Email", selectedItem);
                    //    object ResulEmail = CommandSQL.ExecuteScalar();
                    //    txtEmailUser.Text = ResulEmail.ToString();
                    //}
                    //using (MySqlCommand CommandSQL = new MySqlCommand(QueryNomeSenha, ConnectionSQL))
                    //{
                    //    CommandSQL.Parameters.AddWithValue("@Senha", selectedItem);
                    //    object ResulEmail = CommandSQL.ExecuteScalar();
                    //    txtLoginSenha.Text = ResulEmail.ToString();
                    //}
                    //
                    string Query = "SELECT P.NOME, P.EMAIL, L.SENHA FROM PESSOAS P " +
               "INNER JOIN LOGIN L ON P.NOMELOGIN = L.USUARIO " +
               "WHERE P.NOMELOGIN = @NomeLogin";

                    using (MySqlCommand CommandSQL = new MySqlCommand(Query, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@NomeLogin", selectedItem);

                        using (MySqlDataReader reader = CommandSQL.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtNomeUser.Text = reader["NOME"].ToString();
                                txtEmailUser.Text = reader["EMAIL"].ToString();
                                txtLoginSenha.Text = reader["SENHA"].ToString();
                                txtLoginNome.Text = selectedItem; // O próprio usuário selecionado
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao trazer informações da opção selecionada. " + Ex.Message);
            }
        }
        void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection ConnectionSQL = new MySqlConnection(DB_Variaveis.StringConnection))
                {
                    ConnectionSQL.Open();

                    // Verifica se o usuário já existe
                    string QueryNomeLogin = "SELECT COUNT(*) FROM LOGIN WHERE USUARIO = @Usuario";
                    using (MySqlCommand CommandSQL = new MySqlCommand(QueryNomeLogin, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@Usuario", txtLoginNome.Text);
                        int userExists = Convert.ToInt32(CommandSQL.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Este usuário já existe!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Sai da função
                        }
                    }
                    string QuerySenha = "SELECT COUNT(*) FROM LOGIN WHERE SENHA = @Senha";
                    using (MySqlCommand CommandSQL = new MySqlCommand(QuerySenha, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@Senha", txtLoginSenha.Text);
                        int userExists = Convert.ToInt32(CommandSQL.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Não se pode haver duas senhas iguais para usuários distintos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Sai da função
                        }
                        if (txtLoginSenha.Text == "" && txtLoginNome.Text == "" && txtNomeUser.Text == "")
                        {
                            MessageBox.Show("Não há informações a serem adicionadas, por favor, informe-as. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (txtLoginSenha.Text == "")
                        {
                            MessageBox.Show("Necessário informar a senha! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (txtLoginNome.Text == "")
                        {
                            MessageBox.Show("Necessário informar o nome para login! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        if (txtNomeUser.Text == "")
                        {
                            MessageBox.Show("Necessário informar o seu nome! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    

                    // Se chegou até aqui, significa que o usuário não existe, então podemos adicionar
                    string QueryAddPessoas = "INSERT INTO PESSOAS (NOME, EMAIL, NOMELOGIN) VALUES(@nome, @email, @nomeLogin)";
                    string QueryAddLogin = "INSERT INTO LOGIN (USUARIO, SENHA, BLOQUEADO) VALUES(@User, @Password, 'F')";

                    using (MySqlCommand CommandSQL = new MySqlCommand(QueryAddPessoas, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@nome", txtNomeUser.Text);
                        CommandSQL.Parameters.AddWithValue("@email", txtEmailUser.Text);
                        CommandSQL.Parameters.AddWithValue("@nomeLogin", txtLoginNome.Text);
                        CommandSQL.ExecuteNonQuery();
                    }

                    using (MySqlCommand CommandSQL = new MySqlCommand(QueryAddLogin, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@User", txtLoginNome.Text);
                        CommandSQL.Parameters.AddWithValue("@Password", txtLoginSenha.Text);
                        CommandSQL.ExecuteNonQuery();
                    }                    
                }
                listUsers.Items.Add(txtLoginNome.Text);
                //txtEmailUser.Clear();
                //txtLoginNome.Clear();
                //txtLoginSenha.Clear();
                //txtNomeUser.Clear();
                listUsers.SelectedItem = txtLoginNome.Text;

                MessageBox.Show("Usuário adicionado com sucesso!");
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar adicionar um usuário. " + Ex.Message);
            }
        }
        void btnExcluir_Click(object sender, EventArgs e)
        {

            if (listUsers.SelectedItem == null)
            {
                MessageBox.Show("Nenhum usuário selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string SelectedItem = listUsers.SelectedItem.ToString();
            try
            {
                using (MySqlConnection ConnectionSQL = new MySqlConnection(DB_Variaveis.StringConnection))
                {

                    if (SelectedItem.ToString() == "ADMIN")
                    {
                        MessageBox.Show("Não é permitido excluir o usuário ADMIN!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        return;
                    }

                    ConnectionSQL.Open();
                    string QueryDeletePessoas = "DELETE FROM PESSOAS WHERE NOMELOGIN = @NomeLogin";
                    string QueryDeleteLogin = "DELETE FROM LOGIN WHERE USUARIO = @NomeUser";

                    using (MySqlCommand CommandSQL = new MySqlCommand(QueryDeletePessoas, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@NomeLogin", SelectedItem);
                        CommandSQL.ExecuteNonQuery();
                    }
                    using (MySqlCommand CommandSQL = new MySqlCommand(QueryDeleteLogin, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@NomeUser", SelectedItem);
                        CommandSQL.ExecuteNonQuery();
                    }
                    listUsers.SelectedIndex = 0;
                    listUsers.Items.Remove(SelectedItem);

                    txtEmailUser.Clear();
                    txtLoginNome.Clear();
                    txtLoginSenha.Clear();
                    txtNomeUser.Clear();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar excluir o usuário. " + Ex.Message);
            }
        }

        void btnEditar_Click(object sender, EventArgs e)
        {

            if (listUsers.SelectedItem == null)
            {
                MessageBox.Show("Nenhum usuário selecionado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string SelectedItem = listUsers.SelectedItem.ToString();
            try
            {
                using (MySqlConnection ConnectionSQL = new MySqlConnection(DB_Variaveis.StringConnection))
                {
                    ConnectionSQL.Open();

                    string QuerySenha = "SELECT COUNT(*) FROM LOGIN WHERE SENHA = @Senha";
                    using (MySqlCommand CommandSQL = new MySqlCommand(QuerySenha, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@Senha", txtLoginSenha.Text);
                        int userExists = Convert.ToInt32(CommandSQL.ExecuteScalar());

                        if (userExists > 0)
                        {
                            MessageBox.Show("Não se pode haver duas senhas iguais para usuários!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Sai da função
                        }
                        if (txtLoginSenha.Text == "")
                        {
                            MessageBox.Show("Necessário informar a senha! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    
                    string QueryUpdatePessoas = "UPDATE PESSOAS SET NOME = @NomePessoa, EMAIL = @EmailPessoa, NOMELOGIN = @NomeLogin WHERE NOMELOGIN = @SelectedItem";
                    string QueryUpdateLogin = "UPDATE LOGIN SET USUARIO = @UserNome, SENHA = @Password WHERE USUARIO = @SelectedItem";

                    using (MySqlCommand CommandSQL = new MySqlCommand(QueryUpdatePessoas, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@NomePessoa", txtNomeUser.Text);
                        CommandSQL.Parameters.AddWithValue("@EmailPessoa", txtEmailUser.Text);
                        CommandSQL.Parameters.AddWithValue("@NomeLogin", txtLoginNome.Text);
                        CommandSQL.Parameters.AddWithValue("@SelectedItem", SelectedItem);
                        CommandSQL.ExecuteNonQuery();
                    }
                    using (MySqlCommand CommandSQL = new MySqlCommand(QueryUpdateLogin, ConnectionSQL))
                    {
                        CommandSQL.Parameters.AddWithValue("@UserNome", txtLoginNome.Text);
                        CommandSQL.Parameters.AddWithValue("@Password", txtLoginSenha.Text);
                        CommandSQL.Parameters.AddWithValue("@SelectedItem", SelectedItem);
                        CommandSQL.ExecuteNonQuery();
                    }                    
                }
                MessageBox.Show("Informações alteradas corretamente!", "Alteração realizada corretamente.");
                txtEmailUser.Clear();
                txtLoginNome.Clear();
                txtLoginSenha.Clear();
                txtNomeUser.Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Erro ao editar a informação do usuário. " + Ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEmailUser.Clear();
            txtLoginNome.Clear();
            txtLoginSenha.Clear();
            txtNomeUser.Clear();
        }

        private void MenuInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    
    }
}
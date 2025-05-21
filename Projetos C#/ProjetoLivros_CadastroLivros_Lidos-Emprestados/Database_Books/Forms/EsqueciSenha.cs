using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Books
{
    public partial class EsqueciSenha : Form
    {
        private FormLogin FL;

        List<string> Perguntas = new List<string>();

        public EsqueciSenha(FormLogin formLogin)
        {
            InitializeComponent();
            FL = formLogin;

            try
            {
                string Pergunta0 = "";
                string Pergunta1 = "";
                string Pergunta2 = "";

                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryEsqueciSenha, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeLogin", FL.TxtNomeUser);

                        using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                        {
                            while (ReaderSql.Read())
                            {
                                if (ReaderSql.IsDBNull(0))
                                {
                                    Pergunta0 = "";
                                }else { Pergunta0 = ReaderSql.GetString(0); }
                                
                                if (ReaderSql.IsDBNull(1))
                                {
                                    Pergunta1 = "";
                                }else { Pergunta1 = ReaderSql.GetString(1); }
                                
                                if (ReaderSql.IsDBNull(2))
                                {
                                    Pergunta2 = "";
                                }else { Pergunta2 = ReaderSql.GetString(2); }                           
                            }
                        }
                    }
                }
                if (!string.IsNullOrWhiteSpace(Pergunta0) || !string.IsNullOrWhiteSpace(Pergunta1) || !string.IsNullOrWhiteSpace(Pergunta2))
                {
                    Perguntas.Add(Pergunta0);
                    Perguntas.Add(Pergunta1);
                    Perguntas.Add(Pergunta2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado. " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxPerguntaCachorro.SelectedIndex == -1 || BoxPerguntaCidade.SelectedIndex == -1 || BoxPerguntaObjeto.SelectedIndex == -1)
                {
                    MessageBox.Show("Não pode haver campos sem informação selecionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSenhaNova.Text))
                {
                    MessageBox.Show("Senha nova não pode ficar em branco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Perguntas.Count > 0 && (Perguntas[0].ToString() == BoxPerguntaCachorro.SelectedItem.ToString() && Perguntas[1].ToString() == BoxPerguntaCidade.SelectedItem.ToString() && Perguntas[2].ToString() == BoxPerguntaObjeto.SelectedItem.ToString()))
                {
                    using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                    {
                        ConnectionSql.Open();

                        using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryNovaSenha, ConnectionSql))
                        {
                            string senha = txtSenhaNova.Text;
                            string hash = BCrypt.Net.BCrypt.HashPassword(senha);

                            CommandSql.Parameters.AddWithValue("@SenhaNova", hash);
                            CommandSql.Parameters.AddWithValue("@NomeLogin", FL.TxtNomeUser);
                            CommandSql.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Alteração de senha realizada corretamente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Alteração não concedida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado. " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnCancelarEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

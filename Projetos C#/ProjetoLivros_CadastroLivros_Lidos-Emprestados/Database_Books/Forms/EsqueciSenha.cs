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
                                Perguntas.Add(ReaderSql.GetString(0));
                                Perguntas.Add(ReaderSql.GetString(1));
                                Perguntas.Add(ReaderSql.GetString(2));
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
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

            if (Perguntas[0].ToString() == BoxPerguntaCachorro.SelectedItem.ToString() && Perguntas[1].ToString() == BoxPerguntaCidade.SelectedItem.ToString() && Perguntas[2].ToString() == BoxPerguntaObjeto.SelectedItem.ToString())
            {
                SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection);
                ConnectionSql.Open();
                SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryNovaSenha, ConnectionSql);
                CommandSql.Parameters.AddWithValue("@SenhaNova", txtSenhaNova.Text);
                CommandSql.Parameters.AddWithValue("@NomeLogin", FL.TxtNomeUser);
                CommandSql.ExecuteNonQuery();
                CommandSql.Dispose();
                MessageBox.Show("Alteração de senha realizada corretamente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Alteração não concedida");
            }
        }

        private void btnCancelarEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

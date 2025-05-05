using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace Database_Books.ControlUser
{
    public partial class TelaVisualizarCadastroLivro: UserControl
    {
        private ScreenBook screenbook;
        private TelaCadastroLivro TCL;

        public TelaVisualizarCadastroLivro(ScreenBook screenbook, TelaCadastroLivro TCL)
        {
            InitializeComponent();
            this.screenbook = screenbook;
            this.TCL = TCL; 
        }

        private void TelaVisualizarCadastroLivro_Load(object sender, EventArgs e)
        {
            int IdTelaCadastroLivro = TCL.IdSelecionado;
            int Npagina = 0;
            int NSeq = 0;
            decimal Valor = 0;

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.BuscaVisualizaCadastroLivro, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@Id", IdTelaCadastroLivro);
                        using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                        {
                            while (ReaderSql.Read())
                            {
                                txtNomeLivroVisuCadastro.Text = ReaderSql.GetString(0);
                                txtGeneroLivroVisuCadastro.Text = ReaderSql.GetString(1);
                                Npagina = ReaderSql.GetInt32(2);
                                txtNPaginaVisuCadastro.Text = Convert.ToString(Npagina);

                                string formato = ReaderSql.GetString(3).Trim();
                                BoxFormatoVisuCadastro.SelectedItem = formato;

                                if (ReaderSql.GetValue(4) == (object)DBNull.Value)
                                {
                                    txtNomeSeqVisuCadastro.Text = "";
                                }
                                else
                                {
                                    txtNomeSeqVisuCadastro.Text = ReaderSql.GetString(4);
                                }

                                if (ReaderSql.GetValue(5) == (object)DBNull.Value)
                                {
                                    txtNSeqVisuCadastro.Text = "";
                                }
                                else
                                {
                                    NSeq = ReaderSql.GetInt32(5);
                                    txtNSeqVisuCadastro.Text = Convert.ToString(NSeq);
                                }                                    

                                txtAutorVisuCadastro.Text = ReaderSql.GetString(6);

                                if (ReaderSql.GetValue(7) == (object)DBNull.Value)
                                {
                                    txtValorLivroVisuCadastro.Text = "";
                                }
                                else
                                {
                                    Valor = ReaderSql.GetDecimal(7);
                                    txtValorLivroVisuCadastro.Text = Convert.ToString(Valor);
                                }
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar com banco de dados para acesso ao sistema! " + ex, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFecharVisualizaCadastroLivro_Click(object sender, EventArgs e)
        {
            DialogResult Resul = MessageBox.Show("Deseja fechar as informações deste cadastro de livro? ", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Resul == DialogResult.Yes)
            {
                this.screenbook.CarregarTela(new TelaCadastroLivro(this.screenbook));
            }            
        }

        private void btnSalvarVisualizarCadastroLivro_Click(object sender, EventArgs e)
        {

            int IdTelaCadastroLivro = TCL.IdSelecionado;


            if (string.IsNullOrWhiteSpace(txtNomeLivroVisuCadastro.Text) || string.IsNullOrWhiteSpace(txtGeneroLivroVisuCadastro.Text) || string.IsNullOrWhiteSpace(txtNPaginaVisuCadastro.Text) || BoxFormatoVisuCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Algumas das informações estão pendentes de serem informadas: Nome do Livro, Gênero do Livro, Formato ou Número de Páginas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryUpdateCadastroLivro, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeLivro", txtNomeLivroVisuCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@GeneroLivro", txtGeneroLivroVisuCadastro.Text);

                        int NPaginas = Convert.ToInt32(txtNPaginaVisuCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@NPaginas", NPaginas);

                        CommandSql.Parameters.AddWithValue("@Formato", BoxFormatoVisuCadastro.SelectedItem.ToString());
                        CommandSql.Parameters.AddWithValue("@NomeSequencia", string.IsNullOrWhiteSpace(txtNomeSeqVisuCadastro.Text) ? (object)DBNull.Value : txtNomeSeqVisuCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@NSequencia", string.IsNullOrWhiteSpace(txtNSeqVisuCadastro.Text) ? (object)DBNull.Value : txtNSeqVisuCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@Autor", string.IsNullOrWhiteSpace(txtAutorVisuCadastro.Text) ? (object)DBNull.Value : txtAutorVisuCadastro.Text);
                        
                        if (!string.IsNullOrWhiteSpace(txtValorLivroVisuCadastro.Text))
                        {
                            decimal ValorLivroAjustado = decimal.Parse(txtValorLivroVisuCadastro.Text, CultureInfo.GetCultureInfo("pt-BR"));
                            CommandSql.Parameters.AddWithValue("@Valor", ValorLivroAjustado);
                        }
                        else
                        {
                            CommandSql.Parameters.AddWithValue("@Valor", DBNull.Value);
                        }

                        CommandSql.Parameters.AddWithValue("@Id", IdTelaCadastroLivro);

                        CommandSql.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Atualização de informações efetuada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.screenbook.CarregarTela(new TelaCadastroLivro(this.screenbook));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar efetuar a atualização de informações! \n" + ex, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirCadastroLivro_Click(object sender, EventArgs e)
        {
            int IdCadastroLivro = TCL.IdSelecionado;

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryBuscaCadastroId_LeituraLivros, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@CadastroId", IdCadastroLivro);
                        using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                        {
                            if (ReaderSql.Read())
                            {
                                MessageBox.Show("Não é possível excluir este cadastro pois ele está associado a uma ou mais de uma leitura.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar com banco de dados para excluir informação! " + ex, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            

            DialogResult DR = MessageBox.Show("Deseja realmente realizar a exclusão deste livro?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DR == DialogResult.Yes)
            {
                try
                {
                    SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection);
                    ConnectionSql.Open();
                    SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryDeleteCadastroLivro, ConnectionSql);
                    CommandSql.Parameters.AddWithValue("@Id", IdCadastroLivro);
                    CommandSql.ExecuteNonQuery();
                    ConnectionSql.Dispose();

                    MessageBox.Show("Exclusão de livro realizada corretamente.", "Sucesso em exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.screenbook.CarregarTela(new TelaCadastroLivro(this.screenbook));
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar conectar com banco de dados para excluir informação! " + ex, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

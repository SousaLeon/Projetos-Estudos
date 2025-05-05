using Database_Books.ControlUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Books.Forms
{
    public partial class InclusaoLeitura : Form
    {

        private List<KeyValuePair<int, string>> NomeLivro = new List<KeyValuePair<int, string>>();
        private List<KeyValuePair<int, string>> Leitor = new List<KeyValuePair<int, string>>();

        private TelaLivros TL;

        public InclusaoLeitura(TelaLivros TL)
        {
            InitializeComponent();
            this.TL = TL;
        }

        private void InclusaoLeitura_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryBoxNomeLivro, ConnectionSql))
                    using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                    {
                        while (ReaderSql.Read())
                        {
                            NomeLivro.Add(new KeyValuePair<int, string>(
                                ReaderSql.GetInt32(ReaderSql.GetOrdinal("Id")),
                                ReaderSql.GetString(ReaderSql.GetOrdinal("NomeLivro"))));
                        }
                    }
                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryBoxLeitor, ConnectionSql))
                    using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                    {
                        while (ReaderSql.Read())
                        {
                            Leitor.Add(new KeyValuePair<int, string>(
                                ReaderSql.GetInt32(ReaderSql.GetOrdinal("Id")),
                                ReaderSql.GetString(ReaderSql.GetOrdinal("NomeUsuario"))));
                        }
                    }
                }
                BoxLivros.DataSource = NomeLivro;
                BoxLivros.DisplayMember = "Value";
                BoxLivros.ValueMember = "Key";

                BoxLeitor.DataSource = Leitor;
                BoxLeitor.DisplayMember = "Value";
                BoxLeitor.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValorEmprestimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resul = MessageBox.Show("Deseja cancelar a inclusão da leitura/empréstimo?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (Resul == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIncluirLeituraLivro_Click(object sender, EventArgs e)
        {
            int IdLeituraLivro = 0;

            if (checkBoxEmprestimo.Checked && string.IsNullOrWhiteSpace(txtLeitorEmprestimo.Text))
            {
                MessageBox.Show("Necessário a informação da pessoa ao qual irá ser emprestado o livro. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryInsertLivroLendo, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@DataInicioLeitura", DataInicioLeitura.Value.ToString("dd/MM/yyyy"));
                        CommandSql.Parameters.AddWithValue("@DataEstimativa", DataFimLeituraEstimativa.Value.ToString("dd/MM/yyyy"));

                        if (BoxLeitor.SelectedItem is KeyValuePair<int,string> IdUsuario)
                        {
                            CommandSql.Parameters.AddWithValue("@UsuarioId", IdUsuario.Key);
                        }

                        if (BoxLivros.SelectedItem is KeyValuePair<int, string> IdCadastroLivro)
                        {
                            CommandSql.Parameters.AddWithValue("@CadastroLivroId", IdCadastroLivro.Key);
                        }

                        if (checkBoxEmprestimo.Checked)
                        {
                            CommandSql.Parameters.AddWithValue("@StatusLeitura", "Emprestado");
                        }
                        else
                        {
                            CommandSql.Parameters.AddWithValue("@StatusLeitura", "Lendo");
                        }

                            object resultado = CommandSql.ExecuteScalar();
                        IdLeituraLivro = Convert.ToInt32(resultado.ToString());
                    }

                    if (checkBoxEmprestimo.Checked)
                    {
                        using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryInsertEmprestimo, ConnectionSql))
                        {
                            CommandSql.Parameters.AddWithValue("@PessoaEmprestimo", txtLeitorEmprestimo.Text);

                            if (!string.IsNullOrWhiteSpace(txtValorEmprestimo.Text))
                            {
                                decimal ValorEmprestimo = decimal.Parse(txtValorEmprestimo.Text, CultureInfo.GetCultureInfo("pt-BR"));
                                CommandSql.Parameters.AddWithValue("@ValorEmprestimo", ValorEmprestimo);
                            }
                            else
                            {
                                CommandSql.Parameters.AddWithValue("@ValorEmprestimo", DBNull.Value);
                            }
                            CommandSql.Parameters.AddWithValue("@DataEmprestimo", DataEmprestimo.Value.ToString("dd/MM/yyyy"));
                            CommandSql.Parameters.AddWithValue("@DataDevolucao", DataDevolucao.Value.ToString("dd/MM/yyyy"));
                            CommandSql.Parameters.AddWithValue("@LeituraLivrosId", IdLeituraLivro);

                            CommandSql.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Informações incluídas corretamente. Boa leitura!! ", "Viaje bastante na imaginação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

                this.TL.CarregarLeituraLivros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar incluir o livro para leitura/empréstimo! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabIncluirLeitura_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((e.TabPage == tabPageInfoEmprestimo) && checkBoxEmprestimo.Checked == false)
            {
                e.Cancel = true;
            }
        }
    }
}

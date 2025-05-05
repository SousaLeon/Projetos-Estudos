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
using System.Globalization;

namespace Database_Books
{
    public partial class CadastroLivro: Form
    {
        private TelaCadastroLivro TCL;

        public CadastroLivro(TelaCadastroLivro TCL)
        {
            InitializeComponent();
            this.TCL = TCL;
        }

        private void checkBoxSeqCadastro_CheckedChanged(object sender, EventArgs e)
        {
            txtSeqCadastro.ReadOnly = !checkBoxSeqCadastro.Checked;  
            txtNSequenciaLivro.ReadOnly = !checkBoxSeqCadastro.Checked;
            if (txtSeqCadastro.ReadOnly && txtNSequenciaLivro.ReadOnly)
            {
                txtSeqCadastro.Text = "";
                txtNSequenciaLivro.Text = "";
            }
        }

        private void btnCancelarCadastro_Click(object sender, EventArgs e)
        {
            DialogResult Resul = MessageBox.Show("Deseja fechar a tela de cadastro de livro?", "Dúvida",MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (Resul == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnIncluirLivro_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeLivroCadastro.Text) || string.IsNullOrWhiteSpace(txtGeneroCadastro.Text) || string.IsNullOrWhiteSpace(txtNPaginasCadastro.Text) || comboBoxFormatoCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Algumas das informações estão pendentes de serem informadas: Nome do Livro, Gênero do Livro, Formato ou Número de Páginas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryInsertLivro, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeLivro", txtNomeLivroCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@GeneroLivro", txtGeneroCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@NPaginas", txtNPaginasCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@Formato", comboBoxFormatoCadastro.SelectedItem.ToString());
                        CommandSql.Parameters.AddWithValue("@NomeSeq", string.IsNullOrWhiteSpace(txtSeqCadastro.Text) ? (object)DBNull.Value : txtSeqCadastro.Text);
                        CommandSql.Parameters.AddWithValue("@NSeq", string.IsNullOrWhiteSpace(txtNSequenciaLivro.Text) ? (object)DBNull.Value : txtNSequenciaLivro.Text);
                        CommandSql.Parameters.AddWithValue("@Autor", string.IsNullOrWhiteSpace(txtAutorCadastro.Text) ? (object)DBNull.Value : txtAutorCadastro.Text);

                        if (!string.IsNullOrWhiteSpace(txtValorLivro.Text))
                        {
                            decimal ValorLivroAjustado = decimal.Parse(txtValorLivro.Text, CultureInfo.GetCultureInfo("pt-BR"));
                            CommandSql.Parameters.AddWithValue("@Valor", ValorLivroAjustado);
                        }
                        else
                        {
                            CommandSql.Parameters.AddWithValue("@Valor", DBNull.Value);
                        }
                        CommandSql.ExecuteNonQuery();
                    }
                    TCL.BuscarCadastroLivro();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em conexão com banco de dados para inclusão de livro. \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNPaginasCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValorLivro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNSequenciaLivro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
using Database_Books.ControlUser;
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

namespace Database_Books.Forms
{
    public partial class ResumoNota : Form
    {
        private TelaLivros TL;

        public ResumoNota(TelaLivros TL)
        {
            InitializeComponent();
            this.TL = TL;
        }
        private void ResumoNota_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection);
                ConnectionSql.Open();
                SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryBuscaResumoNota, ConnectionSql);
                CommandSql.Parameters.AddWithValue("@Id", TL.IdSelecionado);
                SqlDataReader ReaderSql = CommandSql.ExecuteReader();
                while (ReaderSql.Read())
                {
                    if (ReaderSql.IsDBNull(0))
                    {
                        txtResumoLivro.Text = "";
                    }
                    else { txtResumoLivro.Text = ReaderSql.GetString(0); }
                    
                    if (ReaderSql.IsDBNull(1))
                    {
                        txtAnotacaoLivro.Text = "";
                    }
                    else { txtAnotacaoLivro.Text = ReaderSql.GetString(1); }
                    
                    if (ReaderSql.IsDBNull(2))
                    {
                        NotaNivel.Value = 0;
                    }
                    else { NotaNivel.Value = ReaderSql.GetInt32(2); }                    
                }
                ConnectionSql.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar trazer as informações! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarResumoNota_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryUpdateResumoNota, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@Resumo", string.IsNullOrWhiteSpace(txtResumoLivro.Text) ? (object)DBNull.Value : txtResumoLivro.Text);
                        CommandSql.Parameters.AddWithValue("@Anotacao", string.IsNullOrWhiteSpace(txtAnotacaoLivro.Text) ? (object)DBNull.Value : txtAnotacaoLivro.Text);
                        CommandSql.Parameters.AddWithValue("@Nota", NotaNivel.Value);
                        CommandSql.Parameters.AddWithValue("@Id", TL.IdSelecionado);
                        CommandSql.ExecuteNonQuery();
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar salvar as informações! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarResumoNota_Click(object sender, EventArgs e)
        {
            DialogResult Resul = MessageBox.Show("Deseja fechar esta tela sem salvar as alterações?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resul == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
    }
}

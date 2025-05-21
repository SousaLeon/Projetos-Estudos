using Database_Books.Forms;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Books.ControlUser
{
    public partial class TelaVisualizarLeituraLivros : UserControl
    {
        private TelaLivros TL;
        private ScreenBook SB;

        public TelaVisualizarLeituraLivros(TelaLivros TL, ScreenBook SB)
        {
            InitializeComponent();
            this.TL = TL;
            this.SB = SB;
        }

        private void TelaVisualizarLeituraLivros_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryPreencheTelaLeituraLivros, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@Id", TL.IdSelecionado);

                        using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                        {
                            while (ReaderSql.Read())
                            {
                                txtNomeLivro.Text = ReaderSql.GetString(0);
                                txtGeneroLivro.Text = ReaderSql.GetString(1);

                                if (ReaderSql.IsDBNull(2))
                                {
                                    txtAutorLivro.Text = "";
                                }else { txtAutorLivro.Text = ReaderSql.GetString(2); }                                    

                                if (ReaderSql.IsDBNull(3))
                                {
                                    txtNomeSeq.Text = "";
                                }else{ txtNomeSeq.Text = ReaderSql.GetString(3); }

                                if (ReaderSql.IsDBNull(4))
                                {
                                    txtNumeroSeq.Text = "";
                                }else{ txtNumeroSeq.Text = ReaderSql.GetString(4); }

                                BoxStatus.SelectedItem = ReaderSql.GetString(5);

                                txtLeitor.Text = ReaderSql.GetString(6);

                                DataFimEstimativa.Value = ReaderSql.GetDateTime(7).Date;

                                if (ReaderSql.IsDBNull(8) && (BoxStatus.SelectedIndex != 1 || BoxStatus.SelectedIndex != 3))
                                {
                                    DataFimLeitura.Visible = false;
                                }else{ DataFimLeitura.Value = ReaderSql.GetDateTime(8).Date; }
                                
                                DataInicioLeitura.Value = ReaderSql.GetDateTime(9).Date;

                                if (ReaderSql.IsDBNull(10))
                                {
                                    DataDevolucao.Visible = false;
                                }else { DataDevolucao.Value = ReaderSql.GetDateTime(10).Date; }

                                if (ReaderSql.IsDBNull(11))
                                {
                                    DataEmprestimo.Visible = false;
                                }else{ DataEmprestimo.Value = ReaderSql.GetDateTime(11).Date; }

                                if (ReaderSql.IsDBNull(12))
                                {
                                    txtPessoaEmprestimo.Text = "";
                                }
                                else{ txtPessoaEmprestimo.Text = ReaderSql.GetString(12); }

                                if (ReaderSql.IsDBNull(13))
                                {
                                    txtValorEmprestimo.Text = "";
                                }else {
                                    decimal Valor = ReaderSql.GetDecimal(13);
                                    txtValorEmprestimo.Text = Convert.ToString(Valor); 
                                }
                            }
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar conectar com o banco de dados para trazer informações. \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarLeituraLivro_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryUpdateLeituraLivros, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@Status", BoxStatus.SelectedItem.ToString());
                        CommandSql.Parameters.AddWithValue("@DataFim", DataFimLeitura.Value.ToString("dd/MM/yyyy"));
                        CommandSql.Parameters.AddWithValue("@Id", TL.IdSelecionado);
                        CommandSql.ExecuteNonQuery();
                    }
                }
                this.SB.CarregarTela(new TelaLivros(this.SB));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar salvar as informações! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarLeituraLivro_Click(object sender, EventArgs e)
        {
            DialogResult Resul = MessageBox.Show("Deseja fechar esta tela sem salvar as alterações?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resul == DialogResult.Yes)
            {
                this.SB.CarregarTela(new TelaLivros(this.SB));
            }
        }

        private void btnExcluirLeituraLivro_Click(object sender, EventArgs e)
        {
            if (BoxStatus.SelectedIndex == 1 || BoxStatus.SelectedIndex == 3)
            {
                MessageBox.Show("Não é possível excluir esta leitura pois está marcada como Lida ou Devolvida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            DialogResult Resul = MessageBox.Show("Deseja realmente excluir esta leitura?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Resul == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                    {
                        ConnectionSql.Open();

                        using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryDeleteLeituraLivros, ConnectionSql))
                        {
                            CommandSql.Parameters.AddWithValue("@Id", TL.IdSelecionado);
                            CommandSql.ExecuteNonQuery();
                        }
                    }
                    this.SB.CarregarTela(new TelaLivros(this.SB));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado ao tentar salvar as informações! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        private void btnResumoNota_Click(object sender, EventArgs e)
        {
            ResumoNota RN = new ResumoNota(this.TL);
            RN.ShowDialog();
        }

        private void BoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (BoxStatus.SelectedIndex)
            {
                case 0: //Lendo
                    DataFimLeitura.Visible = false;
                    DataEmprestimo.Visible = false;
                    DataDevolucao.Visible = false;
                    break;

                case 1://Lido                    
                    DataFimLeitura.Visible = true;
                    break;

                case 2://Emprestado
                    DataFimLeitura.Visible = false;
                    DataEmprestimo.Visible = true;
                    DataDevolucao.Visible = true;
                    break;

                case 3://Devolvido
                    DataFimLeitura.Visible = false;
                    break;
            }
        }

        private void btnPDFLivro_Click(object sender, EventArgs e)
        {
            VisualizadorPDF visualizadoPDF = new VisualizadorPDF(TL);
            visualizadoPDF.ShowDialog();
        }
    }
}

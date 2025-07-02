using Database_Books.Forms;
using Microsoft.EntityFrameworkCore;
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

        private async void TelaVisualizarLeituraLivros_Load(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new DataDbContext())
                {
                    var VisualizaLeitura = await _context.LeituraLivros
                                        .Include(livro => livro.CadastroLivro)
                                        .Include(livro => livro.Usuario)
                                        .FirstOrDefaultAsync(x => x.Id == TL.IdSelecionado);

                    txtNomeLivro.Text = VisualizaLeitura.CadastroLivro.NomeLivro;
                    txtGeneroLivro.Text = VisualizaLeitura.CadastroLivro.GeneroLivro;
                    txtAutorLivro.Text = VisualizaLeitura.CadastroLivro.Autor;
                    BoxStatus.SelectedItem = VisualizaLeitura.StatusLeitura;
                    txtLeitor.Text = VisualizaLeitura.Usuario.NomeUsuario;
                    DataInicioLeitura.Value = VisualizaLeitura.DataInicioLeitura.Date;
                    DataFimLeitura.Value = VisualizaLeitura?.DataFimLeitura?.Date ?? DateTime.Now;
                    DataFimEstimativa.Value = VisualizaLeitura.DataEstimativa.Date;
                    txtNomeSeq.Text = VisualizaLeitura.CadastroLivro.NomeSequencia;
                    txtNumeroSeq.Text = Convert.ToString(VisualizaLeitura.CadastroLivro.NSequencia);
                }

                using (var _context = new DataDbContext())
                {
                    var PreencheEmprestimo = await _context.EmprestimoLivro
                        .Include(x => x.LeituraLivros)
                        .FirstOrDefaultAsync(x => x.LeituraLivrosId == TL.IdSelecionado);

                    if (PreencheEmprestimo != null)
                    {
                        txtPessoaEmprestimo.Text = PreencheEmprestimo.PessoaEmprestimo;
                        txtValorEmprestimo.Text = Convert.ToString(PreencheEmprestimo.ValorEmprestimo);
                        DataEmprestimo.Value = PreencheEmprestimo?.DataEmprestimo?.Date ?? DateTime.MinValue;
                        DataDevolucao.Value = PreencheEmprestimo?.DataDevolucao?.Date ?? DateTime.MinValue;
                    }
                    else
                    {
                        DataEmprestimo.Visible = false;
                        DataDevolucao.Visible = false;
                    }
                }                   

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado. \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSalvarLeituraLivro_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new DataDbContext())
                {
                    var SalvaLeitura = await _context.LeituraLivros.FirstOrDefaultAsync(x => x.Id == TL.IdSelecionado);

                    SalvaLeitura.StatusLeitura = BoxStatus.SelectedItem.ToString();
                    SalvaLeitura.DataFimLeitura = DataFimLeitura.Value;

                    await _context.SaveChangesAsync();
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

        private async void btnExcluirLeituraLivro_Click(object sender, EventArgs e)
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

                    using (var _context = new DataDbContext())
                    {
                        var DeletaEmprestimo = await _context.EmprestimoLivro.FirstOrDefaultAsync(x => x.LeituraLivrosId == TL.IdSelecionado);
                        if (DeletaEmprestimo != null)
                        {
                            _context.Remove(DeletaEmprestimo);
                            await _context.SaveChangesAsync();
                        }
                    }
                    using (var _context = new DataDbContext())
                    {
                        var DeletaLivro = await _context.LeituraLivros.FirstOrDefaultAsync(x => x.Id == TL.IdSelecionado);
                        _context.Remove(DeletaLivro);
                        await _context.SaveChangesAsync();
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

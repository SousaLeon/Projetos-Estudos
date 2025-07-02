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
using System.IO;
using iTextSharp.text.pdf;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Database_Books.DataBaseClass;

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

        private async void TelaVisualizarCadastroLivro_Load(object sender, EventArgs e)
        {
            int IdTelaCadastroLivro = TCL.IdSelecionado;

            try
            {
                using (var _context = new DataDbContext())
                {
                    var CarregarLivros = await _context.CadastroLivro.FirstOrDefaultAsync(x => x.Id == IdTelaCadastroLivro);

                    txtNomeLivroVisuCadastro.Text = CarregarLivros.NomeLivro;
                    txtGeneroLivroVisuCadastro.Text = CarregarLivros.GeneroLivro;
                    txtNPaginaVisuCadastro.Text = Convert.ToString(CarregarLivros.NPaginas);
                    BoxFormatoVisuCadastro.SelectedItem = CarregarLivros.Formato.Trim();
                    txtAutorVisuCadastro.Text = CarregarLivros?.Autor;
                    txtNomeSeqVisuCadastro.Text = CarregarLivros?.NomeSequencia;
                    txtNSeqVisuCadastro.Text = Convert.ToString(CarregarLivros?.NSequencia);
                    txtValorLivroVisuCadastro.Text = Convert.ToString(CarregarLivros.Valor);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar com banco de dados para acesso ao sistema! " + ex, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (var _context = new DataDbContext())
                {
                    var CarregarPDF = await _context.ArquivosPDF.FirstOrDefaultAsync(x => x.CadastroLivroId == IdTelaCadastroLivro);

                    if (CarregarPDF != null)
                    {
                        btnAdicionarPDF.Enabled = false;
                        lblAdicionarPDF.Text = "Este livro já tem um PDF.";
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar carregar o PDF" + ex, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void btnSalvarVisualizarCadastroLivro_Click(object sender, EventArgs e)
        {
            int IdTelaCadastroLivro = TCL.IdSelecionado;
            int? nseq = null;
            decimal? valor = null;

            if (string.IsNullOrWhiteSpace(txtNomeLivroVisuCadastro.Text) || string.IsNullOrWhiteSpace(txtGeneroLivroVisuCadastro.Text) || string.IsNullOrWhiteSpace(txtNPaginaVisuCadastro.Text) || BoxFormatoVisuCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Algumas das informações estão pendentes de serem informadas: Nome do Livro, Gênero do Livro, Formato ou Número de Páginas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtValorLivroVisuCadastro.Text))
            {
                valor = decimal.Parse(txtValorLivroVisuCadastro.Text, CultureInfo.GetCultureInfo("pt-BR"));
            }
            if (!string.IsNullOrWhiteSpace(txtNSeqVisuCadastro.Text))
            {
                nseq = Convert.ToInt32(txtNSeqVisuCadastro.Text);
            }

            try
            {
                using (var _context = new DataDbContext())
                {
                    var SalvarCadastroLivro = await _context.CadastroLivro.FirstOrDefaultAsync(x => x.Id == IdTelaCadastroLivro);

                    SalvarCadastroLivro.NomeLivro = txtNomeLivroVisuCadastro.Text;
                    SalvarCadastroLivro.NomeSequencia = txtNomeSeqVisuCadastro?.Text;
                    SalvarCadastroLivro.GeneroLivro = txtGeneroLivroVisuCadastro.Text;
                    SalvarCadastroLivro.Formato = BoxFormatoVisuCadastro.SelectedItem.ToString();
                    SalvarCadastroLivro.Autor = txtAutorVisuCadastro?.Text;
                    SalvarCadastroLivro.NPaginas = Convert.ToInt32(txtNPaginaVisuCadastro.Text);
                    SalvarCadastroLivro.NSequencia = nseq;
                    SalvarCadastroLivro.Valor = valor;

                    await _context.SaveChangesAsync();

                }
                MessageBox.Show("Atualização de informações efetuada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.screenbook.CarregarTela(new TelaCadastroLivro(this.screenbook));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar efetuar a atualização de informações! \n" + ex, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnExcluirCadastroLivro_Click(object sender, EventArgs e)
        {
            int IdCadastroLivro = TCL.IdSelecionado;

            try
            {
                using (var _context = new DataDbContext())
                {
                    var BuscarCadastroIdEmLeituraLivros = await _context.LeituraLivros
                        .FirstOrDefaultAsync(livro => livro.CadastroLivroId == IdCadastroLivro);

                    if (BuscarCadastroIdEmLeituraLivros != null)
                    {
                        MessageBox.Show("Não é possível excluir este cadastro pois ele está associado a uma ou mais de uma leitura.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        var RemoverPDFCadastroLivro = await _context.ArquivosPDF
                            .FirstOrDefaultAsync(x => x.CadastroLivroId == IdCadastroLivro);

                        _context.Remove(RemoverPDFCadastroLivro);
                        await _context.SaveChangesAsync();

                        var RemoverCadastroLivro = await _context.CadastroLivro
                            .FirstOrDefaultAsync(x => x.Id == IdCadastroLivro);

                        _context.Remove(RemoverCadastroLivro);
                        await _context.SaveChangesAsync();

                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar conectar com banco de dados para excluir informação! " + ex, "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdicionarPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Arquivos PDF (*.pdf)|*.pdf";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    byte[] pdfByte = File.ReadAllBytes(openFile.FileName);
                    string NomeArquivoPDF = Path.GetFileName(openFile.FileName);

                    try
                    {
                        using (var _context = new DataDbContext())
                        {
                            var IncluirPDF = new ArquivosPdfData
                            {
                                NomeArquivo = NomeArquivoPDF,
                                ConteudoPDF = pdfByte,
                                CadastroLivroId = TCL.IdSelecionado
                            };

                            _context.Add(IncluirPDF);
                            await _context.SaveChangesAsync();
                        }
                        
                        MessageBox.Show("PDF salvo com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnAdicionarPDF.Enabled = false;
                        lblAdicionarPDF.Text = "Este livro já tem um PDF.";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro inesperado ao tentar adicionar o PDF." + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }            
        }
    }
}

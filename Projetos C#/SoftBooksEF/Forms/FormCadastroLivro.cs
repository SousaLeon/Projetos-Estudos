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
using System.IO;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using Database_Books.DataBaseClass;

namespace Database_Books
{
    public partial class FormCadastroLivro: Form
    {
        private TelaCadastroLivro TCL;

        public FormCadastroLivro(TelaCadastroLivro TCL)
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

        private async void btnIncluirLivro_Click(object sender, EventArgs e)
        {
            object result_insert_cadastroId = 0;
            int IdCadastroLivro = 0;
            decimal? ValorLivroAjustado = null;
            int? nSequencia = null;
            string AutorLivro = null;
            string NomeSequenciaLivro = null;

            if (string.IsNullOrWhiteSpace(txtNomeLivroCadastro.Text) || string.IsNullOrWhiteSpace(txtGeneroCadastro.Text) || string.IsNullOrWhiteSpace(txtNPaginasCadastro.Text) || comboBoxFormatoCadastro.SelectedIndex == -1)
            {
                MessageBox.Show("Algumas das informações estão pendentes de serem informadas: Nome do Livro, Gênero do Livro, Formato ou Número de Páginas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!string.IsNullOrWhiteSpace(txtValorLivro.Text))
            {
                ValorLivroAjustado = decimal.Parse(txtValorLivro.Text, CultureInfo.GetCultureInfo("pt-BR"));
            }
            else if (int.TryParse(txtValorLivro?.Text, out int tempValor))
            {
                ValorLivroAjustado = tempValor;
            }

            if (int.TryParse(txtNSequenciaLivro?.Text, out int tempNSequencia))
            {
                nSequencia = tempNSequencia;
            }

            if (!string.IsNullOrWhiteSpace(txtAutorCadastro.Text))
            {
                AutorLivro = txtAutorCadastro.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtSeqCadastro.Text))
            {
                NomeSequenciaLivro = txtSeqCadastro.Text;
            }

            try
            {
                using (var _context = new DataDbContext())
                {
                    var cadastroLivro = new CadastroLivroData
                    {
                        NomeLivro = txtNomeLivroCadastro.Text,
                        GeneroLivro = txtGeneroCadastro.Text,
                        NPaginas = Convert.ToInt32(txtNPaginasCadastro.Text),
                        Formato = comboBoxFormatoCadastro.SelectedItem.ToString(),

                        NomeSequencia = NomeSequenciaLivro,
                        NSequencia = nSequencia,
                        Autor = AutorLivro,
                        Valor = ValorLivroAjustado                        
                    };

                    _context.Add(cadastroLivro);
                    await _context.SaveChangesAsync();

                    IdCadastroLivro = cadastroLivro.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em conexão com banco de dados para inclusão de livro. \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;    
            }

            try
            {
                using (var _context = new DataDbContext())
                {
                    var result = MessageBox.Show("Deseja adicionar o PDF deste livro?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (OpenFileDialog openFile = new OpenFileDialog())
                        {
                            openFile.Filter = "Arquivos PDF (*.pdf)|*.pdf";

                            if (openFile.ShowDialog() == DialogResult.OK)
                            {
                                byte[] pdfByte = File.ReadAllBytes(openFile.FileName);
                                string NomeArquivoPDF = Path.GetFileName(openFile.FileName);

                                var cadastroPDF = new ArquivosPdfData
                                {
                                    NomeArquivo = NomeArquivoPDF,
                                    ConteudoPDF = pdfByte,
                                    CadastroLivroId = IdCadastroLivro
                                };

                                _context.Add(cadastroPDF);
                                await _context.SaveChangesAsync();

                                MessageBox.Show("PDF salvo com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                
                TCL.BuscarCadastroLivro();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro em conexão com banco de dados para salvar pdf. \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
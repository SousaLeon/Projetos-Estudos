using Database_Books.ControlUser;
using Microsoft.EntityFrameworkCore;
using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Books.Forms
{
    public partial class VisualizadorPDF : Form
    {
        private TelaLivros TL;
        string caminhoArquivo = Path.Combine("C:\\SoftBooks\\TempPDF", "ArquivoPDF_Temp.pdf");

        public VisualizadorPDF(TelaLivros TL)
        {
            InitializeComponent();
            this.TL = TL;
        }

        private async void VisualizadorPDF_Load(object sender, EventArgs e)
        {            
            if (!Directory.Exists("C:\\SoftBooks\\TempPDF"))
                Directory.CreateDirectory("C:\\SoftBooks\\TempPDF");

            try
            {
                using (var _context = new DataDbContext())
                {
                    var BuscaIdCadastro = await _context.LeituraLivros
                        .Where(x => x.Id == TL.IdSelecionado)
                        .Select(x => x.CadastroLivroId)
                        .FirstOrDefaultAsync();

                    var CarregarVisualizadorPDF = await _context.ArquivosPDF
                        .Include(l => l.CadastroLivro)
                        .FirstOrDefaultAsync(x => x.CadastroLivroId == BuscaIdCadastro);

                    if (CarregarVisualizadorPDF != null)
                    {
                        byte[] pdfBytes = CarregarVisualizadorPDF.ConteudoPDF;

                        if (pdfBytes != null)
                        {
                            caminhoArquivo = Path.Combine(caminhoArquivo);

                            File.WriteAllBytes(caminhoArquivo, pdfBytes);

                            var pdfviewer = new PdfViewer();
                            pdfviewer.Dock = DockStyle.Fill;
                            pdfviewer.Document = PdfDocument.Load(caminhoArquivo);

                            panelVisualizaPDF.Controls.Clear();
                            panelVisualizaPDF.Controls.Add(pdfviewer);
                        }                        
                    }
                    else
                    {
                        MessageBox.Show("PDF não encontrado no banco.");
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar carregar o PDF! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VisualizadorPDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Control control in panelVisualizaPDF.Controls)
            {
                if (control is PdfiumViewer.PdfViewer viewer)
                {
                    viewer.Document.Dispose();
                    viewer.Dispose();
                }
            }
            panelVisualizaPDF.Controls.Clear();

            if (!string.IsNullOrEmpty(caminhoArquivo)
                && File.Exists(caminhoArquivo))
            {
                File.Delete(caminhoArquivo);
            }
        }
    }
}

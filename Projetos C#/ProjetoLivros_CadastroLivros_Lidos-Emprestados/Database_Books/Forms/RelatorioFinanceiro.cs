using Database_Books.ControlUser;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class RelatorioFinanceiro : Form
    {
        private TelaRelatorios telaRelatorio;

        public RelatorioFinanceiro(TelaRelatorios telaRelatorio)
        {
            this.telaRelatorio = telaRelatorio;
            InitializeComponent();
        }

        void CarregarDataTable(string QuerySql, string QueryConnection)
        {
            DataTable DataValorLivro = new DataTable();
            DataValorLivro.Clear();
            SqlDataAdapter Adapter = new SqlDataAdapter(QuerySql, QueryConnection);
            Adapter.Fill(DataValorLivro);
            
            GridViewRelatorioFinanceiro.Rows.Clear();

            foreach (DataRow linhas in DataValorLivro.Rows)
            {
                GridViewRelatorioFinanceiro.Rows.Add(linhas.ItemArray);
            }
        }

        private void RelatorioFinanceiro_Load(object sender, EventArgs e)
        {
            if (telaRelatorio.CheckBoxApresentaValorEmprestimo && telaRelatorio.CheckBoxApresentaValorLivro)
            {
                CarregarDataTable(ComandosSQL.RelValorLivroEmprestimo, ComandosSQL.StrConnection);
                return;
            }
            else if (telaRelatorio.CheckBoxApresentaValorEmprestimo)
            {
                GridViewRelatorioFinanceiro.Columns.Remove(ValorLivro);
                CarregarDataTable(ComandosSQL.RelValorEmprestimo, ComandosSQL.StrConnection);
                return;
            }
            else if (telaRelatorio.CheckBoxApresentaValorLivro)
            {
                GridViewRelatorioFinanceiro.Columns.Remove(ValorEmprestimo);
                CarregarDataTable(ComandosSQL.RelValorLivro, ComandosSQL.StrConnection);
                return;
            }
        }

        public Bitmap CapturarPaneleGridView(Panel panel)
        {
            Bitmap bmp = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, panel.Width, panel.Height));
            return bmp;
        }

        public void ExportarPanelEDataGridParaPDF(Panel panel, DataGridView dgv)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "PDF file |*.pdf";
                dlg.Title = "Salvar relatório completo";
                dlg.FileName = "relatorio_completo";

                if (dlg.ShowDialog() != DialogResult.OK) return;

                
                Document doc = new Document(PageSize.A4.Rotate(), 20, 20, 20, 20);
                PdfWriter.GetInstance(doc, new FileStream(dlg.FileName, FileMode.Create));
                doc.Open();

                
                BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
                iTextSharp.text.Font fTitulo = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font fData = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font fTabela = new iTextSharp.text.Font(bf, 10);

                
                Paragraph titulo = new Paragraph("Relatório teste de sistema", fTitulo) { Alignment = Element.ALIGN_CENTER };
                Paragraph data = new Paragraph("Gerado em: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fData) { Alignment = Element.ALIGN_CENTER };
                doc.Add(titulo);
                doc.Add(data);
                doc.Add(new Paragraph("\n"));

                
                Bitmap bmpPanel = CapturarPaneleGridView(panel);
                using (MemoryStream ms = new MemoryStream())
                {
                    bmpPanel.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());
                    img.ScaleToFit(doc.PageSize.Width - 40, 150); // ajusta largura e altura
                    img.Alignment = Element.ALIGN_CENTER;
                    doc.Add(img);
                }
                doc.Add(new Paragraph("\n"));

                
                PdfPTable tabela = new PdfPTable(dgv.ColumnCount) { WidthPercentage = 100f };
                foreach (DataGridViewColumn col in dgv.Columns)
                {
                    PdfPCell header = new PdfPCell(new Phrase(col.HeaderText, fTabela))
                    {
                        BackgroundColor = new BaseColor(220, 220, 220),
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    tabela.AddCell(header);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        tabela.AddCell(new Phrase(cell.Value?.ToString() ?? "", fTabela));
                    }
                }
                doc.Add(tabela);

                doc.Close();
                MessageBox.Show("PDF completo gerado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSalvarPDF_Click(object sender, EventArgs e)
        {
            ExportarPanelEDataGridParaPDF(panelCabecalho, GridViewRelatorioFinanceiro);
        }
    }
}

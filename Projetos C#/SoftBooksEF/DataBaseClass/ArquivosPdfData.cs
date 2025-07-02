
namespace Database_Books.DataBaseClass
{
    public class ArquivosPdfData
    {
        public int Id { get; set; }
        public string NomeArquivo { get; set; }
        public byte[] ConteudoPDF { get; set; }
        public int CadastroLivroId { get; set; }
        public CadastroLivroData CadastroLivro { get; set; }
    }
}

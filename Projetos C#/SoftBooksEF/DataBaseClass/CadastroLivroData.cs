
namespace Database_Books.DataBaseClass
{
    public class CadastroLivroData
    {
        public int Id { get; set; }
        public string NomeLivro { get; set; }
        public string GeneroLivro { get; set; }
        public int NPaginas { get; set; }
        public string Formato { get; set; }
        public string NomeSequencia { get; set; } = string.Empty;
        public int? NSequencia { get; set; }
        public string Autor { get; set; }
        public decimal? Valor { get; set; }
    }
}

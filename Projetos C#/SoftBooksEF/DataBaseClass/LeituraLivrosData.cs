using System;

namespace Database_Books.DataBaseClass
{
    public class LeituraLivrosData
    {
        public int Id { get; set; }
        public string StatusLeitura { get; set; }
        public DateTime DataInicioLeitura { get; set; }
        public DateTime? DataFimLeitura { get; set; }
        public DateTime DataEstimativa { get; set; }
        public string ResumoLivro { get; set; }
        public string Anotacao { get; set; }
        public int? Nota { get; set;}
        public int UsuarioId { get; set; }
        public int CadastroLivroId { get; set; }
        public CadastroLivroData CadastroLivro { get; set; }
        public UsuarioData Usuario { get; set; }
    }
}

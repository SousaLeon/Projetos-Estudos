using System;

namespace Database_Books.DataBaseClass
{
    public class EmprestimoData
    {
        public int Id { get; set; }
        public string PessoaEmprestimo { get; set; }
        public decimal? ValorEmprestimo { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public int LeituraLivrosId { get; set; }
        public LeituraLivrosData LeituraLivros { get; set; }
    }
}

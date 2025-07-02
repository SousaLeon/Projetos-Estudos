
namespace Database_Books.DataBaseClass
{  
    public class UsuarioData
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string NomeLogin { get; set; }
        public string SenhaLogin { get; set; }
        public string Bloqueado { get; set; }
        public string PerguntaCidade { get; set; }
        public string PerguntaObjeto { get; set; }
        public string PerguntaCachorro { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Books
{
    public static class ComandosSQL
    {
        public static string StrConnection = "Server = 192.168.5.134; Database = BookStation; User id = sa; Password = leon@123;";

        #region Login
        public static string QueryLogin = "select SenhaLogin from Usuario where NomeLogin = @NomeLogin";
        public static string QueryNomeUsuario = "select NomeUsuario from Usuario where NomeLogin = @NomeLogin";
        public static string QueryEsqueciSenha = "select PerguntaCachorro, PerguntaCidade, PerguntaObjeto from Usuario where NomeLogin = @Nomelogin";
        public static string QueryNovaSenha = "update Usuario set senhalogin = @SenhaNova where NomeLogin = @NomeLogin" ;
        public static string QueryNomeLogin = "select NomeLogin from usuario where NomeLogin = @NomeLogin";
        #endregion

        #region CadastroLivro
        public static string QueryInsertLivro = "insert into CadastroLivro values(@NomeLivro, @GeneroLivro, @NPaginas, @Formato, @NomeSeq, @NSeq, @Autor, @Valor); SELECT SCOPE_IDENTITY();";
        public static string BuscaCadastroLivro = "select Id, NomeLivro, GeneroLivro, Autor, Formato from CadastroLivro";
        public static string BuscaAutorCadastroLivro = "select Id, NomeLivro, GeneroLivro, Autor, Formato from CadastroLivro where Autor = @Autor";
        public static string BuscaNomeCadastroLivro = "select Id, NomeLivro, GeneroLivro, Autor, Formato from CadastroLivro where NomeLivro = @NomeLivro";
        public static string BuscaGeneroCadastroLivro = "select Id, NomeLivro, GeneroLivro, Autor, Formato from CadastroLivro where GeneroLivro like @GeneroLivro";
        public static string BuscaVisualizaCadastroLivro = "select NomeLivro, GeneroLivro, NPaginas, Formato, NomeSequencia, NSequencia, Autor, Valor from CadastroLivro where id = @Id";
        public static string QueryUpdateCadastroLivro = "update CadastroLivro set NomeLivro = @NomeLivro, GeneroLivro = @GeneroLivro, NPaginas = @NPaginas, Formato = @Formato, NomeSequencia = @NomeSequencia, NSequencia = @NSequencia, Autor = @Autor, Valor = @Valor where Id = @Id";
        public static string QueryDeleteCadastroLivro = "delete from CadastroLivro where id = @Id";
        public static string QueryBuscaCadastroId_LeituraLivros = "select CadastroLivroId from LeituraLivros where CadastroLivroId = @CadastroId";
        #endregion

        #region Usuario
        public static string QueryBuscaUsuarios = "select Id, NomeLogin, Bloqueado from Usuario";
        public static string QueryPreencheUsuario = "select NomeUsuario, NomeLogin, SenhaLogin, Bloqueado, PerguntaCidade, PerguntaObjeto, PerguntaCachorro  from Usuario where id = @Id";
        public static string QueryUpdateUsuario = "update usuario set NomeUsuario = @NomeUsuario, NomeLogin = @NomeLogin, Bloqueado = @Bloqueado, PerguntaCidade = @PerguntaCidade, PerguntaObjeto = @PerguntaObjeto, PerguntaCachorro = @PerguntaCachorro where Id = @Id";
        public static string QueryInsertUsuario = "insert into usuario values (@NomeUsuario, @NomeLogin, @SenhaLogin, 'Desbloqueado', @PerguntaCidade, @PerguntaObjeto, @PerguntaCachorro)";
        #endregion

        #region LeituraLivros
        public static string QueryBoxNomeLivro = "select Id, NomeLivro from CadastroLivro";
        public static string QueryBoxLeitor = "select Id, NomeUsuario from Usuario";
        public static string QueryInsertLivroLendo = "insert into LeituraLivros (DataInicioLeitura, DataEstimativa, UsuarioId, CadastroLivroId, StatusLeitura) values (@DataInicioLeitura, @DataEstimativa, @UsuarioId, @CadastroLivroId, @StatusLeitura); select scope_identity();";
        public static string QueryInsertEmprestimo = "insert into EmprestimoLivro (PessoaEmprestimo, ValorEmprestimo, DataEmprestimo, DataDevolucao, LeituraLivrosId) values (@PessoaEmprestimo, @ValorEmprestimo, @DataEmprestimo, @DataDevolucao, @LeituraLivrosId)";
        public static string QueryBuscaLeitura = "select L.Id, C.NomeLivro, C.GeneroLivro, C.Autor, L.StatusLeitura from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId";
        public static string QueryBuscaLeituraLivro = "select L.Id, C.NomeLivro, C.GeneroLivro, C.Autor, L.StatusLeitura from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId where C.NomeLivro = @NomeLivro";
        public static string QueryBuscaLeituraStatus = "select L.Id, C.NomeLivro, C.GeneroLivro, C.Autor, L.StatusLeitura from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId where L.StatusLeitura = @Status";
        public static string QueryPreencheTelaLeituraLivros = "select C.NomeLivro,C.GeneroLivro, C.Autor, C.NomeSequencia, C.NSequencia,L.StatusLeitura, U.NomeUsuario,L.DataEstimativa, L.DataFimLeitura,L.DataInicioLeitura, E.DataDevolucao,E.DataEmprestimo, E.PessoaEmprestimo,E.ValorEmprestimo from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId left join EmprestimoLivro E on  E.LeituraLivrosId = L.Id inner join Usuario U on U.Id = L.UsuarioId where L.Id = @Id";
        public static string QueryDeleteLeituraLivros = "delete from LeituraLivros where Id = @Id";
        public static string QueryUpdateLeituraLivros = "update LeituraLivros set StatusLeitura = @Status, DataFimLeitura = @DataFim where Id = @Id";
        public static string QueryUpdateResumoNota = "update LeituraLivros set ResumoLivro = @Resumo, Anotacao = @Anotacao, Nota = @Nota where Id = @Id";
        public static string QueryBuscaResumoNota = "select ResumoLivro, Anotacao, Nota from LeituraLivros where Id = @Id";
        #endregion

        #region Tela_Inicial
        public static string QueryBuscaLivrosLendo = "select C.NomeLivro, L.DataInicioLeitura, U.NomeUsuario from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId inner join Usuario U on U.Id = L.UsuarioId where StatusLeitura = 'Lendo'";
        public static string QueryBuscaLivrosEmprestimo = "select C.NomeLivro, E.DataEmprestimo, E.DataDevolucao, E.PessoaEmprestimo from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId inner join EmprestimoLivro E on E.LeituraLivrosId = L.Id where StatusLeitura = 'Emprestado'";
        #endregion
    }
}

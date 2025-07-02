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
        public static string StrConnection = "Server = localhost; Database = BookStation; User id = sa; Password = leon@123;";

        #region CadastroLivro
        public static string BuscaCadastroLivro = "select Id, NomeLivro, GeneroLivro, Autor, Formato from CadastroLivro";
        #endregion

        #region Usuario
        public static string QueryBuscaUsuarios = "select Id, NomeLogin, Bloqueado from Usuario";
        #endregion

        #region LeituraLivros
        public static string QueryBuscaLeitura = "select L.Id, C.NomeLivro, C.GeneroLivro, C.Autor, L.StatusLeitura from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId";
        #endregion

        #region Tela_Inicial
        public static string QueryBuscaLivrosLendo = "select C.NomeLivro, L.DataInicioLeitura, U.NomeUsuario from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId inner join Usuario U on U.Id = L.UsuarioId where StatusLeitura = 'Lendo'";
        public static string QueryBuscaLivrosEmprestimo = "select C.NomeLivro, E.DataEmprestimo, E.DataDevolucao, E.PessoaEmprestimo from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId inner join EmprestimoLivro E on E.LeituraLivrosId = L.Id where StatusLeitura = 'Emprestado'";
        #endregion

        #region Relatorios
        public static string RelValorLivroEmprestimo = "select C.Valor, E.ValorEmprestimo from CadastroLivro C right join LeituraLivros L on L.CadastroLivroId = C.Id inner join EmprestimoLivro E on E.LeituraLivrosId = L.Id";
        public static string RelValorLivro = "select valor from CadastroLivro where valor is not null";
        public static string RelValorEmprestimo = "select ValorEmprestimo from EmprestimoLivro";
        public static string RelLivro = "select C.NomeLivro, C.GeneroLivro, C.Formato, C.Autor, L.StatusLeitura, U.NomeUsuario, L.DataInicioLeitura, L.DataFimLeitura from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId inner join Usuario U on U.Id = L.UsuarioId where 1 = 1 ";
        public static string RelLivroBackup = RelLivro;
        public static string RelLivroEmprestimo = "select C.NomeLivro, C.GeneroLivro, C.Formato, C.Autor, L.StatusLeitura, E.PessoaEmprestimo, E.DataEmprestimo, E.DataDevolucao from LeituraLivros L inner join CadastroLivro C on C.Id = L.CadastroLivroId inner join Usuario U on U.Id = L.UsuarioId inner join EmprestimoLivro E on E.LeituraLivrosId = L.Id where L.StatusLeitura not in ('Lido', 'Lendo')";
        public static string RelLivroEmprestimoBackup = RelLivroEmprestimo;
        #endregion
    }
}

using Database_Books.DataBaseClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Books
{
    public class DataDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["StringDataConnection"].ConnectionString;
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public DbSet<UsuarioData> Usuario { get; set; }
        public DbSet<CadastroLivroData> CadastroLivro { get; set; }
        public DbSet<ArquivosPdfData> ArquivosPDF { get; set; }
        public DbSet<LeituraLivrosData> LeituraLivros { get; set; }
        public DbSet<EmprestimoData> EmprestimoLivro { get; set; }
    }
}

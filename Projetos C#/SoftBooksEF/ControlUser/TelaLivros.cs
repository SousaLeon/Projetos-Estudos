using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Books.Forms;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Database_Books.ControlUser
{
    public partial class TelaLivros: UserControl
    {
        public int IdSelecionado { get; private set; }

        private ScreenBook _screenbook;

        public TelaLivros(ScreenBook _screenbook)
        {
            InitializeComponent();
            this._screenbook = _screenbook;
        }

        private void btnIncluirLivroLendo_Click(object sender, EventArgs e)
        {
            InclusaoLeitura IL = new InclusaoLeitura(this);
            IL.ShowDialog();
        }

        public void CarregarLeituraLivros()
        {
            DataTable LeituraLivros = new DataTable();
            SqlDataAdapter ReaderSql = new SqlDataAdapter(ComandosSQL.QueryBuscaLeitura, ComandosSQL.StrConnection);

            ReaderSql.Fill(LeituraLivros);

            GridViewLivros.Rows.Clear();

            foreach (DataRow linha in LeituraLivros.Rows)
            {
                GridViewLivros.Rows.Add(linha.ItemArray);
            }
        }

        private async void btnBuscarLeitura_Click(object sender, EventArgs e)
        {

            string pesquisa = txtBuscaLeitura.Text;

            if (string.IsNullOrWhiteSpace(txtBuscaLeitura.Text) || txtBuscaLeitura.Text == "%")
            {
                CarregarLeituraLivros();
                txtBuscaLeitura.Text = "";
                return;
            }
            switch (BoxBuscaPersonalizada.SelectedIndex)
            {
                case 0:

                    using (var _context = new DataDbContext())
                    {
                        var consultaLivro = await _context.LeituraLivros
                                                .Include(l => l.CadastroLivro)
                                                .Where(l => l.CadastroLivro.NomeLivro.Contains(pesquisa))
                                                .Select(l => new
                                                {
                                                    l.Id,
                                                    l.CadastroLivro.NomeLivro,
                                                    l.CadastroLivro.GeneroLivro,
                                                    l.CadastroLivro.Autor,
                                                    l.StatusLeitura
                                                }).ToListAsync();

                        GridViewLivros.Rows.Clear();

                        foreach (var livroPesquisa in consultaLivro)
                        {
                            GridViewLivros.Rows.Add(
                                livroPesquisa.Id,
                                livroPesquisa.NomeLivro,
                                livroPesquisa.GeneroLivro,
                                livroPesquisa.Autor,
                                livroPesquisa.StatusLeitura
                            );
                        }
                    }                        

                    break;
                case 1:

                    using (var _context = new DataDbContext())
                    {
                        var consultaStatus = await _context.LeituraLivros
                                                .Include(l => l.CadastroLivro)
                                                .Where(l => l.StatusLeitura.Contains(pesquisa))
                                                .Select(l => new
                                                {
                                                    l.Id,
                                                    l.CadastroLivro.NomeLivro,
                                                    l.CadastroLivro.GeneroLivro,
                                                    l.CadastroLivro.Autor,
                                                    l.StatusLeitura
                                                }).ToListAsync();

                        GridViewLivros.Rows.Clear();

                        foreach (var livroPesquisa in consultaStatus)
                        {
                            GridViewLivros.Rows.Add(
                                livroPesquisa.Id,
                                livroPesquisa.NomeLivro,
                                livroPesquisa.GeneroLivro,
                                livroPesquisa.Autor,
                                livroPesquisa.StatusLeitura
                            );
                        }
                    }                        
                    break;
            }                
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtBuscaLeitura.Text = "";
            BoxBuscaPersonalizada.SelectedIndex = -1;
        }

        private void GridViewLivros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IdSelecionado = Convert.ToInt32(GridViewLivros.CurrentRow.Cells["Id"].Value);
                _screenbook.CarregarTela(new TelaVisualizarLeituraLivros(this, this._screenbook));
            }
        }
    }
}
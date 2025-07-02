using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Database_Books.ControlUser;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Database_Books
{
    public partial class TelaCadastroLivro: UserControl
    {
        private ScreenBook _screenbook;
        public DataGridView DGV => GridViewCadastroLivro;
        public int IdSelecionado { get; private set; }

        public TelaCadastroLivro(ScreenBook screenbook)
        {
            InitializeComponent();
            _screenbook = screenbook;
            //GridViewCadastroLivro.Sort(GridViewCadastroLivro.Columns["Nome_Livro"], ListSortDirection.Ascending);
        }
        
        public void BuscarCadastroLivro()
        {
            DataTable Data_CadastroLivro = new DataTable();
            SqlDataAdapter Adaptador = new SqlDataAdapter(ComandosSQL.BuscaCadastroLivro, ComandosSQL.StrConnection);

            Adaptador.Fill(Data_CadastroLivro);


            GridViewCadastroLivro.Rows.Clear();

            foreach (DataRow linha in Data_CadastroLivro.Rows)
            {
                GridViewCadastroLivro.Rows.Add(linha.ItemArray);
            }
        }
        
        private void btnIncluirCadastroLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivro CL = new FormCadastroLivro(this);
            CL.ShowDialog();
        }

        private void GridViewCadastroLivro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IdSelecionado = Convert.ToInt32(GridViewCadastroLivro.CurrentRow.Cells["Id"].Value);
                _screenbook.CarregarTela(new TelaVisualizarCadastroLivro(_screenbook, this));
            }            
        }

        private async void btnBuscarCadastroLivro_Click(object sender, EventArgs e)
        {
            string pesquisa = txtBuscaCadastroLivro.Text;

            if (string.IsNullOrWhiteSpace(txtBuscaCadastroLivro.Text) || txtBuscaCadastroLivro.Text == "%")
            {
                BuscarCadastroLivro();
                txtBuscaCadastroLivro.Text = "";
                return;
            }

            switch (BoxBuscaPersonalizada.SelectedIndex)
            {
                case 0:

                    try
                    {
                        using (var _context = new DataDbContext())
                        {
                            var consulta = await _context.CadastroLivro
                                .Where(autorPesquisa => autorPesquisa.Autor.Contains(pesquisa))
                                .ToListAsync();

                            GridViewCadastroLivro.Rows.Clear();

                            foreach (var autorPesquisa in consulta)
                            {
                                GridViewCadastroLivro.Rows.Add(
                                    autorPesquisa.Id,
                                    autorPesquisa.NomeLivro,
                                    autorPesquisa.GeneroLivro,
                                    autorPesquisa.Autor,
                                    autorPesquisa.Formato
                                );
                            }
                        }                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar trazer informações. \n" + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case 1:

                    try
                    {
                        using (var _context = new DataDbContext())
                        {
                            var consulta = await _context.CadastroLivro
                                .Where(autorPesquisa => autorPesquisa.NomeLivro.Contains(pesquisa))
                                .ToListAsync();

                            GridViewCadastroLivro.Rows.Clear();

                            foreach (var autorPesquisa in consulta)
                            {
                                GridViewCadastroLivro.Rows.Add(
                                    autorPesquisa.Id,
                                    autorPesquisa.NomeLivro,
                                    autorPesquisa.GeneroLivro,
                                    autorPesquisa.Autor,
                                    autorPesquisa.Formato
                                );
                            }
                        }                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar trazer informações. \n" + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                case 2:

                    try
                    {
                        using (var _context = new DataDbContext())
                        {
                            var consulta = await _context.CadastroLivro
                                .Where(autorPesquisa => autorPesquisa.GeneroLivro.Contains(pesquisa))
                                .ToListAsync();

                            GridViewCadastroLivro.Rows.Clear();

                            foreach (var autorPesquisa in consulta)
                            {
                                GridViewCadastroLivro.Rows.Add(
                                    autorPesquisa.Id,
                                    autorPesquisa.NomeLivro,
                                    autorPesquisa.GeneroLivro,
                                    autorPesquisa.Autor,
                                    autorPesquisa.Formato
                                );
                            }
                        }                            
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao tentar trazer informações. \n" + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

            }
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtBuscaCadastroLivro.Text = "";
            BoxBuscaPersonalizada.SelectedIndex = -1;
        }
    }
}
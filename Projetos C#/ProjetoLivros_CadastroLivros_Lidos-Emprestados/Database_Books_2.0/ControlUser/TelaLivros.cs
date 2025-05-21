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
using System.Net.Http.Headers;

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

        private void btnBuscarLeitura_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscaLeitura.Text) || txtBuscaLeitura.Text == "%")
            {
                CarregarLeituraLivros();
                txtBuscaLeitura.Text = "";
                return;
            }
            using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
            {
                ConnectionSql.Open();

                switch (BoxBuscaPersonalizada.SelectedIndex)
                {
                    case 0:

                        using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryBuscaLeituraLivro, ConnectionSql))
                        {
                            CommandSql.Parameters.AddWithValue("@NomeLivro", txtBuscaLeitura.Text);

                            DataTable DataBuscaLivro = new DataTable();
                            SqlDataAdapter Adapter = new SqlDataAdapter(CommandSql);
                            Adapter.Fill(DataBuscaLivro);
                            GridViewLivros.Rows.Clear();

                            foreach (DataRow linha in DataBuscaLivro.Rows)
                            {
                                GridViewLivros.Rows.Add(linha.ItemArray);
                            }
                        }

                    break;
                    case 1:

                        using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryBuscaLeituraStatus, ConnectionSql))
                        {
                            CommandSql.Parameters.AddWithValue("@Status", txtBuscaLeitura.Text);

                            DataTable DataBuscaLivro = new DataTable();
                            SqlDataAdapter Adapter = new SqlDataAdapter(CommandSql);
                            Adapter.Fill(DataBuscaLivro);
                            GridViewLivros.Rows.Clear();

                            foreach (DataRow linha in DataBuscaLivro.Rows)
                            {
                                GridViewLivros.Rows.Add(linha.ItemArray);
                            }
                        }

                    break;
                }
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
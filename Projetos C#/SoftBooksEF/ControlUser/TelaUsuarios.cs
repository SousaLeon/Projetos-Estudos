using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Database_Books.DataBaseClass;

namespace Database_Books.ControlUser
{
    public partial class TelaUsuarios: UserControl
    {
        public TelaUsuarios()
        {
            InitializeComponent();
            CarregarUsuarios();
        }

        void CarregarUsuarios()
        {
            DataTable dataUsuario = new DataTable();

            SqlDataAdapter Adapter = new SqlDataAdapter(ComandosSQL.QueryBuscaUsuarios, ComandosSQL.StrConnection);
            Adapter.Fill(dataUsuario);

            GridViewUsuario.Rows.Clear();

            foreach (DataRow linha in dataUsuario.Rows)
            {
                GridViewUsuario.Rows.Add(linha.ItemArray);
            }
            GridViewUsuario.ClearSelection();
        }

        private async void GridViewUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdUsuario = 0;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IdUsuario = Convert.ToInt32(GridViewUsuario.CurrentRow.Cells["Id"].Value);

                try
                {
                    using (var _context = new DataDbContext())
                    {
                        var UsuarioBusca = await _context.Usuario.FirstOrDefaultAsync(user => user.Id == IdUsuario);

                        txtNomeUsuario.Text = UsuarioBusca.NomeUsuario;
                        txtNomeLoginUsuario.Text = UsuarioBusca.NomeLogin;
                        txtSenhaUsuario.Text = UsuarioBusca.SenhaLogin;
                        BoxPerguntaCachorro.SelectedItem = UsuarioBusca?.PerguntaCachorro;
                        BoxPerguntaCidade.SelectedItem = UsuarioBusca?.PerguntaCidade;
                        BoxPerguntaObjeto.SelectedItem = UsuarioBusca?.PerguntaObjeto;

                    }
                    txtSenhaUsuario.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado. \n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //private static string GetStringFromReader(SqlDataReader reader, int columnIndex)
        //{
        //    return reader.IsDBNull(columnIndex) ? string.Empty : reader.GetString(columnIndex);
        //}

        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            txtNomeLoginUsuario.Text = "";
            txtNomeUsuario.Text = "";
            txtSenhaUsuario.Text = "";
            txtSenhaUsuario.ReadOnly = false;
            checkBoxUserBloqueado.Checked = false;
            BoxPerguntaCachorro.SelectedIndex = -1;
            BoxPerguntaCidade.SelectedIndex = -1;
            BoxPerguntaObjeto.SelectedIndex = -1;
            GridViewUsuario.ClearSelection();
        }

        private async void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            //string Bloqueado = "";

            int IdUsuario = Convert.ToInt32(GridViewUsuario.CurrentRow.Cells["Id"].Value);

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) || string.IsNullOrWhiteSpace(txtNomeLoginUsuario.Text))
            {
                MessageBox.Show("Há informações em branco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (var _context = new DataDbContext())
                {
                    var SalvarUsuario = await _context.Usuario.FirstOrDefaultAsync(x => x.Id == IdUsuario);

                    SalvarUsuario.NomeUsuario = txtNomeUsuario.Text;
                    SalvarUsuario.NomeLogin = txtNomeLoginUsuario.Text;
                    SalvarUsuario.PerguntaCachorro = BoxPerguntaCachorro.SelectedItem?.ToString();
                    SalvarUsuario.PerguntaCidade = BoxPerguntaCidade.SelectedItem?.ToString();
                    SalvarUsuario.PerguntaObjeto = BoxPerguntaObjeto.SelectedItem?.ToString();

                    _context.Update(SalvarUsuario);
                    await _context.SaveChangesAsync();
                }                    

                txtNomeLoginUsuario.Text = "";
                txtNomeUsuario.Text = "";
                txtSenhaUsuario.Text = "";
                checkBoxUserBloqueado.Checked = false;
                BoxPerguntaCachorro.SelectedIndex = -1;
                BoxPerguntaCidade.SelectedIndex = -1;
                BoxPerguntaObjeto.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado. \n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnIncluir_Click(object sender, EventArgs e)
        {
            string hash = BCrypt.Net.BCrypt.HashPassword(txtSenhaUsuario.Text);

            if (string.IsNullOrWhiteSpace(txtNomeLoginUsuario.Text) || string.IsNullOrWhiteSpace(txtNomeUsuario.Text) || string.IsNullOrWhiteSpace(txtSenhaUsuario.Text))
            {
                MessageBox.Show("É necessário que todas as informações estejam preenchidas! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (var _context = new DataDbContext())
                {
                    var NovoUsuario = new UsuarioData
                    {
                        NomeUsuario = txtNomeUsuario.Text,
                        NomeLogin = txtNomeLoginUsuario.Text,
                        SenhaLogin = hash,
                        Bloqueado = "Desbloqueado",
                        PerguntaCidade = BoxPerguntaCidade.SelectedItem?.ToString(),
                        PerguntaObjeto = BoxPerguntaObjeto.SelectedItem?.ToString(),
                        PerguntaCachorro = BoxPerguntaCachorro.SelectedItem?.ToString()
                    };

                    if (txtNomeLoginUsuario.Text.Length > 30)
                    {
                        MessageBox.Show("É permitido apenas 30 caracteres para o nome de login!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (txtSenhaUsuario.Text.Length > 12)
                    {
                        MessageBox.Show("É permitido apenas 12 caracteres para sua senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    _context.Add(NovoUsuario);
                    await _context.SaveChangesAsync();
                }                    

                MessageBox.Show("Usuário adicionado corretamente! ", "Sucesso em inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado. \n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
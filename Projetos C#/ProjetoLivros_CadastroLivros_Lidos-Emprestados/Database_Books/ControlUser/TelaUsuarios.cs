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
        }

        private void GridViewUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdUsuario = 0;
            string Bloqueado = "";
            string PerguntaCidade = "";
            string PerguntaObjeto = "";
            string PerguntaCachorro = "";

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                IdUsuario = Convert.ToInt32(GridViewUsuario.CurrentRow.Cells["Id"].Value);

                try
                {
                    using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                    {
                        ConnectionSql.Open();
                        using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryPreencheUsuario, ConnectionSql))
                        {
                            CommandSql.Parameters.Add("@Id", SqlDbType.Int).Value = IdUsuario;

                            using (SqlDataReader ReaderSql = CommandSql.ExecuteReader())
                            {
                                while (ReaderSql.Read())
                                {
                                    txtNomeUsuario.Text = ReaderSql.GetString(0);
                                    txtNomeLoginUsuario.Text = ReaderSql.GetString(1);
                                    txtSenhaUsuario.Text = ReaderSql.GetString(2);

                                    Bloqueado = ReaderSql.GetString(3);
                                    checkBoxUserBloqueado.Checked = Bloqueado == "Bloqueado";

                                    PerguntaCidade = GetStringFromReader(ReaderSql, 4);
                                    BoxPerguntaCidade.SelectedItem = !string.IsNullOrEmpty(PerguntaCidade) ? PerguntaCidade : null;

                                    PerguntaObjeto = GetStringFromReader(ReaderSql, 5);
                                    BoxPerguntaObjeto.SelectedItem = !string.IsNullOrEmpty(PerguntaObjeto) ? PerguntaObjeto : null;

                                    PerguntaCachorro = GetStringFromReader(ReaderSql, 6);
                                    BoxPerguntaCachorro.SelectedItem = !string.IsNullOrEmpty(PerguntaCachorro) ? PerguntaCachorro : null;
                                }
                            }
                        }
                    }
                    txtSenhaUsuario.ReadOnly = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tentar trazer informações. \n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private static string GetStringFromReader(SqlDataReader reader, int columnIndex)
        {
            return reader.IsDBNull(columnIndex) ? string.Empty : reader.GetString(columnIndex);
        }

        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            txtNomeLoginUsuario.Text = "";
            txtNomeUsuario.Text = "";
            txtSenhaUsuario.Text = "";
            checkBoxUserBloqueado.Checked = false;
            BoxPerguntaCachorro.SelectedIndex = -1;
            BoxPerguntaCidade.SelectedIndex = -1;
            BoxPerguntaObjeto.SelectedIndex = -1;
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string Bloqueado = "";

            int IdUsuario = Convert.ToInt32(GridViewUsuario.CurrentRow.Cells["Id"].Value);

            if (string.IsNullOrWhiteSpace(txtNomeUsuario.Text) || string.IsNullOrWhiteSpace(txtNomeLoginUsuario.Text))
            {
                MessageBox.Show("Há informações em branco. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();

                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryUpdateUsuario,ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeUsuario", txtNomeUsuario.Text);
                        CommandSql.Parameters.AddWithValue("@NomeLogin", txtNomeLoginUsuario.Text);

                        if (checkBoxUserBloqueado.Checked)
                        {
                            Bloqueado = "Bloqueado";
                        }
                        else
                        {
                            Bloqueado = "Desbloqueado";
                        }
                        CommandSql.Parameters.AddWithValue("@Bloqueado", Bloqueado);

                        CommandSql.Parameters.AddWithValue("@PerguntaCidade", BoxPerguntaCidade.SelectedIndex == -1 ? (object)DBNull.Value : BoxPerguntaCidade.SelectedItem.ToString());
                        CommandSql.Parameters.AddWithValue("@PerguntaObjeto", BoxPerguntaObjeto.SelectedIndex == -1 ? (object)DBNull.Value : BoxPerguntaObjeto.SelectedItem.ToString());
                        CommandSql.Parameters.AddWithValue("@PerguntaCachorro", BoxPerguntaCachorro.SelectedIndex == -1 ? (object)DBNull.Value : BoxPerguntaCachorro.SelectedItem.ToString());
                        CommandSql.Parameters.AddWithValue("@Id", IdUsuario);
                        
                        CommandSql.ExecuteNonQuery();
                    }
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
                MessageBox.Show("Erro ao tentar trazer informações. \n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeLoginUsuario.Text) || string.IsNullOrWhiteSpace(txtNomeUsuario.Text) || string.IsNullOrWhiteSpace(txtSenhaUsuario.Text))
            {
                MessageBox.Show("É necessário que todas as informações estejam preenchidas! ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                using (SqlConnection ConnectionSql = new SqlConnection(ComandosSQL.StrConnection))
                {
                    ConnectionSql.Open();
                    using (SqlCommand CommandSql = new SqlCommand(ComandosSQL.QueryInsertUsuario, ConnectionSql))
                    {
                        CommandSql.Parameters.AddWithValue("@NomeUsuario", txtNomeUsuario.Text);
                        CommandSql.Parameters.AddWithValue("@NomeLogin", txtNomeLoginUsuario.Text);
                        CommandSql.Parameters.AddWithValue("SenhaLogin", txtSenhaUsuario.Text);

                        if (BoxPerguntaCidade.SelectedIndex >= 0)
                        {
                            CommandSql.Parameters.AddWithValue("@PerguntaCidade", BoxPerguntaCidade.SelectedItem.ToString());
                        }
                        else { CommandSql.Parameters.AddWithValue("@PerguntaCidade", (object)DBNull.Value); }

                        if (BoxPerguntaObjeto.SelectedIndex >= 0)
                        {
                            CommandSql.Parameters.AddWithValue("@PerguntaObjeto", BoxPerguntaObjeto.SelectedItem.ToString());
                        }
                        else { CommandSql.Parameters.AddWithValue("@PerguntaObjeto", (object)DBNull.Value); }

                        if (BoxPerguntaCachorro.SelectedIndex >= 0)
                        {
                            CommandSql.Parameters.AddWithValue("@PerguntaCachorro", BoxPerguntaCachorro.SelectedItem.ToString());
                        } 
                        else { CommandSql.Parameters.AddWithValue("@PerguntaCachorro", (object)DBNull.Value); }

                        CommandSql.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Usuário adicionado corretamente! ", "Sucesso em inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar trazer informações. \n" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
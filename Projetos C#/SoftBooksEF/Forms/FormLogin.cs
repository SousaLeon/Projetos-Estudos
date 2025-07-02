using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;
using Microsoft.EntityFrameworkCore;


namespace Database_Books
{
    public partial class FormLogin : Form
    {
        public string NomeUsuario { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
        }
        public string TxtNomeUser
        {
            get { return txtNomeUser.Text; }
            set { txtNomeUser.Text = value; }
        }

        private async void btnAcessar_Click(object sender, EventArgs e)
        {
            string hash = "";
            bool valido = false;

            if (string.IsNullOrWhiteSpace(txtNomeUser.Text) || string.IsNullOrWhiteSpace(txtSenhaUser.Text))
            {
                MessageBox.Show("Há informações faltando ser mencionadas, Usuário ou Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (var _context = new DataDbContext())
                {
                    var consulta = await _context.Usuario.FirstOrDefaultAsync(user => user.NomeLogin == txtNomeUser.Text);

                    if (consulta != null)
                    {
                        hash = consulta.SenhaLogin;
                        NomeUsuario = consulta.NomeUsuario;

                        valido = BCrypt.Net.BCrypt.Verify(txtSenhaUser.Text, hash);

                        if (valido)
                        {
                            this.Hide();
                            ScreenBook screenBook = new ScreenBook(this);
                            screenBook.Show();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorreto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtSenhaUser.Clear();
                            txtNomeUser.Focus();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private async void btnEsqueciSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeUser.Text))
            {
                MessageBox.Show("Informe o nome do usuário que esqueceu a senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                using (var _context = new DataDbContext())
                {
                    var consulta = await _context.Usuario.FirstOrDefaultAsync(user => user.NomeLogin == txtNomeUser.Text);

                    if (consulta != null)
                    {
                        EsqueciSenha ES = new EsqueciSenha(this);
                        ES.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário não existe no sistema!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Foi encontrado um erro inesperado ao tentar consultar este nome de usuário! \n" + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

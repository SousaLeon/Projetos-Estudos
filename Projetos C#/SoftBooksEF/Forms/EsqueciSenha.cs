using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Books
{
    public partial class EsqueciSenha : Form
    {
        private FormLogin FL;

        List<string> Perguntas = new List<string>();

        public EsqueciSenha(FormLogin formLogin)
        {
            InitializeComponent();
            FL = formLogin;
        }

        private async void EsqueciSenha_Load(object sender, EventArgs e)
        {
            await PerguntasSenha();
        }

        public async Task PerguntasSenha()
        {
            try
            {
                using (var _context = new DataDbContext())
                {
                    var consulta = await _context.Usuario.Where(u => u.NomeLogin == FL.TxtNomeUser)
                        .Select(u => new
                        {
                            u.PerguntaCachorro,
                            u.PerguntaCidade,
                            u.PerguntaObjeto
                        })
                        .FirstOrDefaultAsync();

                    if (consulta != null)
                    {
                        Perguntas.Add(consulta.PerguntaCachorro);
                        Perguntas.Add(consulta.PerguntaCidade);
                        Perguntas.Add(consulta.PerguntaObjeto);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }                            
        }

        public async Task AtualizaSenha()
        {
            using (var _context = new DataDbContext())
            {
                var SenhaBanco = await _context.Usuario.FirstOrDefaultAsync(user => user.NomeLogin == FL.TxtNomeUser);

                string novaSenha = txtSenhaNova.Text;

                string senhaHash = BCrypt.Net.BCrypt.HashPassword(novaSenha);

                SenhaBanco.SenhaLogin = senhaHash;

                _context.Update(SenhaBanco);

                await _context.SaveChangesAsync();
            }
        }

        private async void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (BoxPerguntaCachorro.SelectedIndex == -1 || BoxPerguntaCidade.SelectedIndex == -1 || BoxPerguntaObjeto.SelectedIndex == -1)
                {
                    MessageBox.Show("Não pode haver campos sem informação selecionada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSenhaNova.Text))
                {
                    MessageBox.Show("Senha nova não pode ficar em branco!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (Perguntas.Count > 0 && (Perguntas[0].ToString() == BoxPerguntaCachorro.SelectedItem.ToString() && Perguntas[1].ToString() == BoxPerguntaCidade.SelectedItem.ToString() && Perguntas[2].ToString() == BoxPerguntaObjeto.SelectedItem.ToString()))
                {
                    try
                    {
                        await AtualizaSenha();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    MessageBox.Show("Alteração de senha realizada corretamente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Alteração não concedida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado. " + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarEsqueciSenha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

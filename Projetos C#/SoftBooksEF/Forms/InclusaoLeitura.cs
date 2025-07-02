using Database_Books.ControlUser;
using Database_Books.DataBaseClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Books.Forms
{
    public partial class InclusaoLeitura : Form
    {

        List<KeyValuePair<int, string>> NomeLivro = new List<KeyValuePair<int, string>>();
        List<KeyValuePair<int, string>> Leitor = new List<KeyValuePair<int, string>>();
        TelaLivros TL;

        public InclusaoLeitura(TelaLivros TL)
        {
            InitializeComponent();
            this.TL = TL;
        }

        private async void InclusaoLeitura_Load(object sender, EventArgs e)
        {
            try
            {

                using (var _context = new DataDbContext())
                {
                    var CarregaNomeLivro = await _context.CadastroLivro.ToListAsync();

                    foreach (var livro in CarregaNomeLivro)
                    {
                        NomeLivro.Add(new KeyValuePair<int, string>(
                            livro.Id,
                            livro.NomeLivro
                            ));
                    }
                    var CarregaNomeLeitor = await _context.Usuario.ToListAsync();

                    foreach (var user in CarregaNomeLeitor)
                    {
                        Leitor.Add(new KeyValuePair<int, string>(
                            user.Id,
                            user.NomeUsuario
                            ));
                    }
                }

                BoxLivros.DataSource = NomeLivro;
                BoxLivros.DisplayMember = "Value";
                BoxLivros.ValueMember = "Key";

                BoxLeitor.DataSource = Leitor;
                BoxLeitor.DisplayMember = "Value";
                BoxLeitor.ValueMember = "Key";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValorEmprestimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Resul = MessageBox.Show("Deseja cancelar a inclusão da leitura/empréstimo?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            if (Resul == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void btnIncluirLeituraLivro_Click(object sender, EventArgs e)
        {
            decimal? _ValorEmprestimo = null;
            int IdUsuario = 0;
            int IdCadastro = 0;
            int IdLeituraLivros = 0;
            string Status;

            if (checkBoxEmprestimo.Checked && string.IsNullOrWhiteSpace(txtLeitorEmprestimo.Text))
            {
                MessageBox.Show("Necessário a informação da pessoa ao qual irá ser emprestado o livro. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (checkBoxEmprestimo.Checked)
                Status = "Emprestado";
            else { Status = "Lendo"; }

            if (BoxLeitor.SelectedItem is KeyValuePair<int, string> UsuarioId)
                IdUsuario = UsuarioId.Key;

            if (BoxLivros.SelectedItem is KeyValuePair<int, string> CadastroId)
                IdCadastro = CadastroId.Key;

            if (!string.IsNullOrWhiteSpace(txtValorEmprestimo.Text))
                _ValorEmprestimo = decimal.Parse(txtValorEmprestimo.Text, CultureInfo.GetCultureInfo("pt-BR"));

                try
                {
                    using (var _context = new DataDbContext())
                    {
                        var IncluirLivro = new LeituraLivrosData
                        {
                            StatusLeitura = Status,
                            CadastroLivroId = IdCadastro,
                            UsuarioId = IdUsuario,
                            DataInicioLeitura = DataInicioLeitura.Value,
                            DataEstimativa = DataFimLeituraEstimativa.Value
                        };

                        _context.Add(IncluirLivro);
                        await _context.SaveChangesAsync();

                        IdLeituraLivros = IncluirLivro.Id;

                        if (checkBoxEmprestimo.Checked)
                        {
                            var IncluiEmprestimo = new EmprestimoData
                            {
                                PessoaEmprestimo = txtLeitorEmprestimo.Text,
                                ValorEmprestimo = _ValorEmprestimo,
                                DataEmprestimo = DataEmprestimo.Value,
                                DataDevolucao = DataDevolucao.Value,
                                LeituraLivrosId = IdLeituraLivros
                            };
                            
                            _context.Add(IncluiEmprestimo);
                            await _context.SaveChangesAsync();
                        }
                    }

                    MessageBox.Show("Informações incluídas corretamente. Boa leitura!! ", "Viaje bastante na imaginação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    this.TL.CarregarLeituraLivros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao tentar incluir o livro para leitura/empréstimo! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void tabIncluirLeitura_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if ((e.TabPage == tabPageInfoEmprestimo) && checkBoxEmprestimo.Checked == false)
            {
                e.Cancel = true;
            }
        }
    }
}

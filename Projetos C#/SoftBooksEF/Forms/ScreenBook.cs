using Database_Books.ControlUser;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Database_Books
{
    public partial class ScreenBook : Form
    {
        private FormLogin loginForm;

        public ScreenBook(FormLogin loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        public void CarregarTela(UserControl NovaTela)
        {
            panelTelas.Controls.Clear();
            NovaTela.Dock = DockStyle.Fill;
            panelTelas.Controls.Add(NovaTela);
        }

        #region Buttons_LoadScreen
        void btnHome_Click(object sender, EventArgs e)
        {
            CarregarTela(new TelaInicial(this.loginForm));
        }
        void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            CarregarTela(new TelaCadastroLivro(this));
        }
        void btnLivros_Click(object sender, EventArgs e)
        {
            CarregarTela(new TelaLivros(this));
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            CarregarTela(new TelaUsuarios());
        }
        private void btnSobre_Click(object sender, EventArgs e)
        {
            CarregarTela(new TelaSobre());
        }
        #endregion

        private void ScreenBook_Load(object sender, EventArgs e)
        {
            CarregarTela(new TelaInicial(this.loginForm));
        }
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            CarregarTela(new TelaRelatorios());
        }

        private void ScreenBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
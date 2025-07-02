using Database_Books.ControlUser;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Identity.Client;
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

namespace Database_Books.Forms
{
    public partial class ResumoNota : Form
    {
        private TelaLivros TL;

        public ResumoNota(TelaLivros TL)
        {
            InitializeComponent();
            this.TL = TL;
        }
        private async void ResumoNota_Load(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new DataDbContext())
                {
                    var CarregarResumoNota = await _context.LeituraLivros
                        .FirstOrDefaultAsync( x => x.Id == TL.IdSelecionado);

                    txtResumoLivro.Text = CarregarResumoNota?.ResumoLivro;
                    txtAnotacaoLivro.Text = CarregarResumoNota?.Anotacao;
                    NotaNivel.Value = CarregarResumoNota?.Nota ?? 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar trazer as informações! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSalvarResumoNota_Click(object sender, EventArgs e)
        {
            string ResumoLivro = null;
            string Anotacao = null;

            if (!string.IsNullOrWhiteSpace(txtResumoLivro.Text))
                ResumoLivro = txtResumoLivro.Text;

            if (!string.IsNullOrWhiteSpace(txtAnotacaoLivro.Text))
                Anotacao = txtAnotacaoLivro.Text;

            try
            {
                using (var _context = new DataDbContext())
                {
                    var AtualizaResumoNota = await _context.LeituraLivros
                        .FirstOrDefaultAsync( x => x.Id == TL.IdSelecionado);

                    AtualizaResumoNota.ResumoLivro = ResumoLivro;
                    AtualizaResumoNota.Anotacao = Anotacao;
                    AtualizaResumoNota.Nota = NotaNivel.Value;

                    _context.Update(AtualizaResumoNota);
                    await _context.SaveChangesAsync(); 
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado ao tentar salvar as informações! \n" + ex, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarResumoNota_Click(object sender, EventArgs e)
        {
            DialogResult Resul = MessageBox.Show("Deseja fechar esta tela sem salvar as alterações?", "Dúvida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Resul == DialogResult.Yes)
            {
                this.Close();
            }
        }
       
    }
}

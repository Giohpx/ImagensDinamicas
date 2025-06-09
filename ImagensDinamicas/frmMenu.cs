using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ImagensDinamicas.frmCarregaFoto;

namespace ImagensDinamicas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnJogoDado_Click(object sender, EventArgs e)
        {
               frmJogoDados jogodado = new frmJogoDados(txtJogador1.Text, txtJogador2.Text);
               jogodado.ShowDialog();
               
        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            frmCarregaFoto carregafoto = new frmCarregaFoto();
            carregafoto.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            txtJogador1.Text = Usuario.NomeJogador1;
            txtJogador2.Text = Usuario.NomeJogador2;

            picFoto.Image = Usuario.FotoJogador1;
            picFoto1.Image = Usuario.FotoJogador2;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair?", "MENU - CTI", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
   
    }
}

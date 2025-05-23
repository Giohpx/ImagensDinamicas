using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
               frmJogoDados jogodado = new frmJogoDados(lblJogador1.Text, lblJogador2.Text);
               jogodado.ShowDialog();
               
        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            frmCarregaFoto carregafoto = new frmCarregaFoto();
            carregafoto.ShowDialog();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja sair?", "MENU - CTI", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No)
            {
                Application.Exit();
            }


        }
    }
}

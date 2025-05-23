using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ImagensDinamicas
{
    public partial class frmJogoDados : Form
    {
        private Random sorteio = new Random();
        private int dadoJog1, dadoJog2;
        private int placar1 = 0, placar2 = 0;

        public frmJogoDados()
        {
            InitializeComponent();
       
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {

            dadoJog1 = SorteioDado(picDado1);
            dadoJog2 = SorteioDado(picDado2);

            if (dadoJog1 > dadoJog2)
            {
                placar1 += 1;
                lblPlacar1.Text = placar1.ToString();
            }
            else if (dadoJog2 > dadoJog1)
            {
                placar2 += 1;
                lblPlacar2.Text = placar2.ToString();
            }
            else
            {
                MessageBox.Show("Houve um empate nessa rodada!!!", "Jogo de dados CTI",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private int SorteioDado(PictureBox dado)
        {
            int valorDado = sorteio.Next(1, 7);
            //colocar a pasta imagens dentro da pasta \bin\debug do projeto
            String arquivoDado = ".\\imagens\\dado" + valorDado.ToString() + ".jpg";
            dado.Image = Image.FromFile(arquivoDado);
            return valorDado;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            placar1 = 0;
            placar2 = 0;
            lblPlacar1.Text = "0";
            lblPlacar2.Text = "0";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (placar1 > placar2)
            {
                MessageBox.Show("Jogador 1 Venceu!!");

            }

            else if (placar2 > placar1)
            {

                MessageBox.Show("Jogador 2 Venceu!!");
            }

            else
            {
                MessageBox.Show("Empatou!!");
                Application.Exit();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
        private String jogador1, jogador2;

        //método construtor da classe frmJogoDados, é um método que é executado quando é criada a nova instância dessa classe. em que vc pode 
        // por exemplo, adicionar comando que serão executados logo na criação da classe
        public frmJogoDados(String jogador1, String jogador2)
        {
            InitializeComponent();
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
        }
        private void frmJogoDados_Load(object sender, EventArgs e)
        {
            lblJogador1.Text += jogador1;
            lblJogador2 .Text += jogador2;
        }


        private void btnJogar_Click(object sender, EventArgs e)
        {

            dadoJog1 = SorteioDado(picDado1);
            dadoJog2 = SorteioDado(picDado2);

            if (dadoJog1 > dadoJog2)
            {
                placar1 += 1;
                lblPlacar1.Text = placar1.ToString();
                MessageBox.Show("Jogador 1 Venceu!!");

            }
            else if (dadoJog1 < dadoJog2)
            {
                placar2 += 1;
                lblPlaca2.Text = placar2.ToString();
                MessageBox.Show("Jogador 2 Venceu!!");

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

        private void frmJogoDados_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Deseja sair?", "Jogo de dados CTI", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.No)
            {
                Application.Exit();
            }
           
         
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
            this.Close();

        }
    }
}

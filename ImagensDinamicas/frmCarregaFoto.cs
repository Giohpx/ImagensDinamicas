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
    public partial class frmCarregaFoto : Form
    {
        public frmCarregaFoto()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckFoto.Checked)
            {
                btnCarregarFoto.Enabled = true;
                picFoto.Image = null;
                picFoto.BackColor = SystemColors.Control; // Cor neutra
            }
            else
            {
                btnCarregarFoto.Enabled = false;
                picFoto.Image = null;
                picFoto.BackColor = Color.LightGray; // Cor fictícia
            }

        }

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            opdFoto.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os Arquivos|*.*";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(opdFoto.FileName);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada."); 
                picFoto.Image = null;
            }
           

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair?", "MENU - CTI", MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.ShowDialog();

            
            }

        private void btnCarregarFoto2_Click(object sender, EventArgs e)
        {
            opdFoto.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os Arquivos|*.*";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Image = Image.FromFile(opdFoto.FileName);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada.");
                picFoto.Image = null;
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
          Usuario.NomeJogador1 = txtJogador1.Text;
          Usuario.NomeJogador2 = txtJogador2.Text;

          Usuario.FotoJogador1 = picFoto.Image;
          Usuario.FotoJogador2 = picFoto1.Image;
        }
        public static class Usuario
        {
            public static String NomeJogador1 { get; set; }
            public static String NomeJogador2 { get; set; }

            public static Image FotoJogador1 { get; set; }
            public static Image FotoJogador2 { get; set; }
        }

        private void frmCarregaFoto_Load(object sender, EventArgs e)
        {

        }

        private void btnCarregarFoto2_Click_1(object sender, EventArgs e)
        {

            opdFoto.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Todos os Arquivos|*.*";
            if (opdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto1.Image = Image.FromFile(opdFoto.FileName);
            }
            else
            {
                MessageBox.Show("Nenhuma imagem selecionada.");
                picFoto1.Image = null;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnCarregarFoto2.Enabled = true;
                picFoto1.Image = null;
                picFoto1.BackColor = SystemColors.Control; 
            }
            else
            {
                btnCarregarFoto2.Enabled = false;
                picFoto1.Image = null; 
                picFoto1.BackColor = Color.LightGray; 
            }
        }

        private void CheckFoto_Click(object sender, EventArgs e)
        {
            if (CheckFoto.Checked)
            {
                picFoto.Visible = true;
                btnCarregarFoto.Visible = true;
            }
            else
            {
                picFoto.Visible = false;
                btnCarregarFoto.Visible = false;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                picFoto1.Visible = true;
                btnCarregarFoto2.Visible = true;
            }
            else
            {
                picFoto1.Visible = false;
                btnCarregarFoto2.Visible = false;
            }
        }
    }
}

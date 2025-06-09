namespace ImagensDinamicas
{
    partial class frmCarregaFoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarregaFoto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckFoto = new System.Windows.Forms.CheckBox();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.opdFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnMenu = new System.Windows.Forms.Button();
            this.picFoto1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnCarregarFoto2 = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "JOGADOR 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "JOGADOR 2:";
            // 
            // CheckFoto
            // 
            this.CheckFoto.BackColor = System.Drawing.Color.Transparent;
            this.CheckFoto.Location = new System.Drawing.Point(157, 196);
            this.CheckFoto.Name = "CheckFoto";
            this.CheckFoto.Size = new System.Drawing.Size(104, 24);
            this.CheckFoto.TabIndex = 2;
            this.CheckFoto.Text = "Com foto";
            this.CheckFoto.UseVisualStyleBackColor = false;
            this.CheckFoto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(157, 109);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(89, 83);
            this.picFoto.TabIndex = 3;
            this.picFoto.TabStop = false;
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.Location = new System.Drawing.Point(420, 169);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(161, 29);
            this.btnCarregarFoto.TabIndex = 6;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = true;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // txtJogador1
            // 
            this.txtJogador1.Location = new System.Drawing.Point(265, 173);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(149, 20);
            this.txtJogador1.TabIndex = 7;
            // 
            // txtJogador2
            // 
            this.txtJogador2.Location = new System.Drawing.Point(265, 290);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(149, 20);
            this.txtJogador2.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(671, 359);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 43);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "IDENTIFICAÇÃO DE  JOGADOR";
            // 
            // opdFoto
            // 
            this.opdFoto.FileName = "openFileDialog1";
            this.opdFoto.Filter = "Bitmaps|*.bmp|JPEG|*.jpg";
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(543, 359);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(99, 43);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // picFoto1
            // 
            this.picFoto1.Location = new System.Drawing.Point(157, 226);
            this.picFoto1.Name = "picFoto1";
            this.picFoto1.Size = new System.Drawing.Size(89, 84);
            this.picFoto1.TabIndex = 3;
            this.picFoto1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(157, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Com foto";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // btnCarregarFoto2
            // 
            this.btnCarregarFoto2.Location = new System.Drawing.Point(420, 290);
            this.btnCarregarFoto2.Name = "btnCarregarFoto2";
            this.btnCarregarFoto2.Size = new System.Drawing.Size(161, 29);
            this.btnCarregarFoto2.TabIndex = 13;
            this.btnCarregarFoto2.Text = "Carregar Foto";
            this.btnCarregarFoto2.UseVisualStyleBackColor = true;
            this.btnCarregarFoto2.Click += new System.EventHandler(this.btnCarregarFoto2_Click_1);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(288, 329);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(99, 43);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmCarregaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCarregarFoto2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtJogador2);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.picFoto1);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.CheckFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCarregaFoto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCarregaFoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckFoto;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog opdFoto;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox picFoto1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCarregarFoto2;
        private System.Windows.Forms.Button btnConfirmar;
    }
}


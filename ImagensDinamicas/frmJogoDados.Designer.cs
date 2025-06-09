namespace ImagensDinamicas
{
    partial class frmJogoDados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJogoDados));
            this.picDado1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picDado2 = new System.Windows.Forms.PictureBox();
            this.lblPlacar2 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblPlacar1 = new System.Windows.Forms.Label();
            this.lblPlaca2 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.picFoto1 = new System.Windows.Forms.PictureBox();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // picDado1
            // 
            this.picDado1.BackColor = System.Drawing.Color.Transparent;
            this.picDado1.Location = new System.Drawing.Point(45, 59);
            this.picDado1.Name = "picDado1";
            this.picDado1.Size = new System.Drawing.Size(191, 181);
            this.picDado1.TabIndex = 0;
            this.picDado1.TabStop = false;
            // 
            // picDado2
            // 
            this.picDado2.BackColor = System.Drawing.Color.Transparent;
            this.picDado2.Location = new System.Drawing.Point(364, 59);
            this.picDado2.Name = "picDado2";
            this.picDado2.Size = new System.Drawing.Size(188, 181);
            this.picDado2.TabIndex = 3;
            this.picDado2.TabStop = false;
            // 
            // lblPlacar2
            // 
            this.lblPlacar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar2.Location = new System.Drawing.Point(608, 243);
            this.lblPlacar2.Name = "lblPlacar2";
            this.lblPlacar2.Size = new System.Drawing.Size(60, 60);
            this.lblPlacar2.TabIndex = 5;
            this.lblPlacar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnJogar.ForeColor = System.Drawing.Color.Black;
            this.btnJogar.Location = new System.Drawing.Point(256, 306);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(75, 23);
            this.btnJogar.TabIndex = 6;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReiniciar.Location = new System.Drawing.Point(94, 306);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSair.Location = new System.Drawing.Point(415, 306);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblPlacar1
            // 
            this.lblPlacar1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlacar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacar1.Location = new System.Drawing.Point(94, 243);
            this.lblPlacar1.Name = "lblPlacar1";
            this.lblPlacar1.Size = new System.Drawing.Size(75, 60);
            this.lblPlacar1.TabIndex = 2;
            this.lblPlacar1.Text = "0";
            this.lblPlacar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlaca2
            // 
            this.lblPlaca2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlaca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca2.Location = new System.Drawing.Point(415, 243);
            this.lblPlaca2.Name = "lblPlaca2";
            this.lblPlaca2.Size = new System.Drawing.Size(75, 60);
            this.lblPlaca2.TabIndex = 2;
            this.lblPlaca2.Text = "0";
            this.lblPlaca2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFoto
            // 
            this.picFoto.BackColor = System.Drawing.Color.Transparent;
            this.picFoto.Location = new System.Drawing.Point(56, 12);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(57, 41);
            this.picFoto.TabIndex = 9;
            this.picFoto.TabStop = false;
            // 
            // picFoto1
            // 
            this.picFoto1.BackColor = System.Drawing.Color.Transparent;
            this.picFoto1.Location = new System.Drawing.Point(481, 12);
            this.picFoto1.Name = "picFoto1";
            this.picFoto1.Size = new System.Drawing.Size(57, 41);
            this.picFoto1.TabIndex = 10;
            this.picFoto1.TabStop = false;
            // 
            // txtJogador1
            // 
            this.txtJogador1.Location = new System.Drawing.Point(119, 33);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(100, 20);
            this.txtJogador1.TabIndex = 11;
            // 
            // txtJogador2
            // 
            this.txtJogador2.Location = new System.Drawing.Point(375, 33);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(100, 20);
            this.txtJogador2.TabIndex = 12;
            // 
            // frmJogoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 373);
            this.Controls.Add(this.txtJogador2);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.picFoto1);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.lblPlaca2);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.lblPlacar2);
            this.Controls.Add(this.picDado2);
            this.Controls.Add(this.lblPlacar1);
            this.Controls.Add(this.picDado1);
            this.Name = "frmJogoDados";
            this.Text = "Jogo de Dados";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmJogoDados_FormClosed);
            this.Load += new System.EventHandler(this.frmJogoDados_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDado1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picDado2;
        private System.Windows.Forms.Label lblPlacar2;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblPlacar1;
        private System.Windows.Forms.Label lblPlaca2;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.PictureBox picFoto1;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.TextBox txtJogador2;
    }
}
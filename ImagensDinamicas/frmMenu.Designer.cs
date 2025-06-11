namespace ImagensDinamicas
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnJogoDado = new System.Windows.Forms.Button();
            this.btnCarregaFoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ta = new System.Windows.Forms.Label();
            this.ae = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.picFoto1 = new System.Windows.Forms.PictureBox();
            this.txtJogador1 = new System.Windows.Forms.TextBox();
            this.txtJogador2 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.resultado1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogoDado
            // 
            this.btnJogoDado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJogoDado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJogoDado.BackgroundImage")));
            this.btnJogoDado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnJogoDado.ForeColor = System.Drawing.Color.White;
            this.btnJogoDado.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJogoDado.Location = new System.Drawing.Point(12, 22);
            this.btnJogoDado.Name = "btnJogoDado";
            this.btnJogoDado.Size = new System.Drawing.Size(176, 143);
            this.btnJogoDado.TabIndex = 0;
            this.btnJogoDado.UseVisualStyleBackColor = false;
            this.btnJogoDado.Click += new System.EventHandler(this.btnJogoDado_Click);
            // 
            // btnCarregaFoto
            // 
            this.btnCarregaFoto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCarregaFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCarregaFoto.BackgroundImage")));
            this.btnCarregaFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarregaFoto.Location = new System.Drawing.Point(406, 22);
            this.btnCarregaFoto.Name = "btnCarregaFoto";
            this.btnCarregaFoto.Size = new System.Drawing.Size(176, 143);
            this.btnCarregaFoto.TabIndex = 1;
            this.btnCarregaFoto.UseVisualStyleBackColor = false;
            this.btnCarregaFoto.Click += new System.EventHandler(this.btnCarregaFoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "JOGO DE DADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "CARREGAR FOTOS";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.label3.Location = new System.Drawing.Point(247, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "MENU";
            // 
            // ta
            // 
            this.ta.AutoSize = true;
            this.ta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ta.Location = new System.Drawing.Point(86, 376);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(64, 16);
            this.ta.TabIndex = 5;
            this.ta.Text = "Jogador 1:";
            // 
            // ae
            // 
            this.ae.AutoSize = true;
            this.ae.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ae.Location = new System.Drawing.Point(86, 453);
            this.ae.Name = "ae";
            this.ae.Size = new System.Drawing.Size(64, 16);
            this.ae.TabIndex = 6;
            this.ae.Text = "Jogador 2:";
            // 
            // picFoto
            // 
            this.picFoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFoto.BackgroundImage")));
            this.picFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFoto.Location = new System.Drawing.Point(12, 358);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(68, 50);
            this.picFoto.TabIndex = 7;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // picFoto1
            // 
            this.picFoto1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFoto1.BackgroundImage")));
            this.picFoto1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFoto1.Location = new System.Drawing.Point(12, 429);
            this.picFoto1.Name = "picFoto1";
            this.picFoto1.Size = new System.Drawing.Size(68, 50);
            this.picFoto1.TabIndex = 8;
            this.picFoto1.TabStop = false;
            // 
            // txtJogador1
            // 
            this.txtJogador1.BackColor = System.Drawing.Color.Silver;
            this.txtJogador1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtJogador1.Location = new System.Drawing.Point(165, 372);
            this.txtJogador1.Name = "txtJogador1";
            this.txtJogador1.Size = new System.Drawing.Size(100, 20);
            this.txtJogador1.TabIndex = 9;
            // 
            // txtJogador2
            // 
            this.txtJogador2.BackColor = System.Drawing.Color.Silver;
            this.txtJogador2.ForeColor = System.Drawing.Color.Black;
            this.txtJogador2.Location = new System.Drawing.Point(165, 449);
            this.txtJogador2.Name = "txtJogador2";
            this.txtJogador2.Size = new System.Drawing.Size(100, 20);
            this.txtJogador2.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(507, 437);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 42);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(372, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "PLACAR";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado.Location = new System.Drawing.Point(489, 332);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(23, 25);
            this.resultado.TabIndex = 15;
            this.resultado.Text = "0";
            // 
            // resultado1
            // 
            this.resultado1.AutoSize = true;
            this.resultado1.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultado1.Location = new System.Drawing.Point(489, 383);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(23, 25);
            this.resultado1.TabIndex = 16;
            this.resultado1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "JOGADOR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(373, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Jogador 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Jogador 1:";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 511);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtJogador2);
            this.Controls.Add(this.txtJogador1);
            this.Controls.Add(this.picFoto1);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.ae);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarregaFoto);
            this.Controls.Add(this.btnJogoDado);
            this.Name = "frmMenu";
            this.Text = "Menu Projetos Imagens Dinâmicas";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogoDado;
        private System.Windows.Forms.Button btnCarregaFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ta;
        private System.Windows.Forms.Label ae;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.PictureBox picFoto1;
        private System.Windows.Forms.TextBox txtJogador1;
        private System.Windows.Forms.TextBox txtJogador2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label resultado1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
﻿namespace VegaJuego
{
    partial class Level1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            MovEnemigos = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelVida = new Label();
            labelEscudo = new Label();
            labelArma = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // MovEnemigos
            // 
            MovEnemigos.Enabled = true;
            MovEnemigos.Tick += MovEnemigos_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.salud;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(759, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 39);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelVida
            // 
            labelVida.AutoSize = true;
            labelVida.BackColor = Color.Transparent;
            labelVida.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelVida.ForeColor = Color.Gold;
            labelVida.Location = new Point(808, 12);
            labelVida.Name = "labelVida";
            labelVida.Size = new Size(46, 23);
            labelVida.TabIndex = 1;
            labelVida.Text = "Vida";
            // 
            // labelEscudo
            // 
            labelEscudo.AutoSize = true;
            labelEscudo.BackColor = Color.Transparent;
            labelEscudo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelEscudo.ForeColor = Color.Gold;
            labelEscudo.Location = new Point(808, 57);
            labelEscudo.Name = "labelEscudo";
            labelEscudo.Size = new Size(65, 23);
            labelEscudo.TabIndex = 2;
            labelEscudo.Text = "Escudo";
            // 
            // labelArma
            // 
            labelArma.AutoSize = true;
            labelArma.BackColor = Color.Transparent;
            labelArma.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelArma.ForeColor = Color.Gold;
            labelArma.Location = new Point(808, 102);
            labelArma.Name = "labelArma";
            labelArma.Size = new Size(54, 23);
            labelArma.TabIndex = 3;
            labelArma.Text = "Arma";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.escudo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(759, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 39);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.Arma;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(759, 102);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 39);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Level1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = Properties.Resources.FondoFinal;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(882, 588);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(labelArma);
            Controls.Add(labelEscudo);
            Controls.Add(labelVida);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Level1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VegaZelda";
            FormClosed += Level1_FormClosed;
            KeyPress += Level1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer MovEnemigos;
        private PictureBox pictureBox1;
        private Label labelVida;
        private Label labelEscudo;
        private Label labelArma;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
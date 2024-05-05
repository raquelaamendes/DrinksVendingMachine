namespace MaquinaVendaBebidas
{
    partial class Form1
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
            imgMaquinaBebidas = new PictureBox();
            imgMoedaTroco = new PictureBox();
            imgColocarMoeda = new PictureBox();
            btnTrocoGrande = new PictureBox();
            btnCafe = new PictureBox();
            btnCappuccino = new PictureBox();
            btnCha = new PictureBox();
            btnChocolate = new PictureBox();
            imgCopo = new PictureBox();
            lblVisor = new Label();
            imgRanhura = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)imgMaquinaBebidas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMoedaTroco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgColocarMoeda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnTrocoGrande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCafe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCappuccino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnChocolate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCopo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgRanhura).BeginInit();
            SuspendLayout();
            // 
            // imgMaquinaBebidas
            // 
            imgMaquinaBebidas.Image = Properties.Resources.maquinabebidasPNG;
            imgMaquinaBebidas.Location = new Point(1, 1);
            imgMaquinaBebidas.Margin = new Padding(6, 5, 6, 5);
            imgMaquinaBebidas.Name = "imgMaquinaBebidas";
            imgMaquinaBebidas.Size = new Size(600, 800);
            imgMaquinaBebidas.SizeMode = PictureBoxSizeMode.AutoSize;
            imgMaquinaBebidas.TabIndex = 0;
            imgMaquinaBebidas.TabStop = false;
            // 
            // imgMoedaTroco
            // 
            imgMoedaTroco.BackColor = Color.Transparent;
            imgMoedaTroco.Enabled = false;
            imgMoedaTroco.Image = Properties.Resources.moedaTrocoPNG;
            imgMoedaTroco.Location = new Point(471, 688);
            imgMoedaTroco.Name = "imgMoedaTroco";
            imgMoedaTroco.Size = new Size(96, 64);
            imgMoedaTroco.TabIndex = 1;
            imgMoedaTroco.TabStop = false;
            imgMoedaTroco.Visible = false;
            imgMoedaTroco.Click += imgMoedaTroco_Click;
            // 
            // imgColocarMoeda
            // 
            imgColocarMoeda.BackColor = Color.Transparent;
            imgColocarMoeda.Image = Properties.Resources.ColocarMoedaPNG;
            imgColocarMoeda.Location = new Point(374, 71);
            imgColocarMoeda.Name = "imgColocarMoeda";
            imgColocarMoeda.Size = new Size(30, 86);
            imgColocarMoeda.SizeMode = PictureBoxSizeMode.AutoSize;
            imgColocarMoeda.TabIndex = 2;
            imgColocarMoeda.TabStop = false;
            imgColocarMoeda.Visible = false;
            imgColocarMoeda.Click += imgColocarMoeda_Click;
            imgColocarMoeda.MouseLeave += imgColocarMoeda_MouseLeave;
            // 
            // btnTrocoGrande
            // 
            btnTrocoGrande.BackColor = Color.Transparent;
            btnTrocoGrande.BackgroundImageLayout = ImageLayout.Zoom;
            btnTrocoGrande.Enabled = false;
            btnTrocoGrande.Image = Properties.Resources.btnGrandePNG;
            btnTrocoGrande.Location = new Point(422, 77);
            btnTrocoGrande.Name = "btnTrocoGrande";
            btnTrocoGrande.Size = new Size(69, 69);
            btnTrocoGrande.SizeMode = PictureBoxSizeMode.AutoSize;
            btnTrocoGrande.TabIndex = 3;
            btnTrocoGrande.TabStop = false;
            btnTrocoGrande.Click += btnTrocoGrande_Click;
            // 
            // btnCafe
            // 
            btnCafe.BackColor = Color.Transparent;
            btnCafe.Image = Properties.Resources.btnPequenoPNG;
            btnCafe.Location = new Point(254, 230);
            btnCafe.Name = "btnCafe";
            btnCafe.Size = new Size(39, 39);
            btnCafe.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCafe.TabIndex = 4;
            btnCafe.TabStop = false;
            btnCafe.Click += btnCafe_Click;
            // 
            // btnCappuccino
            // 
            btnCappuccino.BackColor = Color.Transparent;
            btnCappuccino.Image = Properties.Resources.btnPequenoPNG;
            btnCappuccino.Location = new Point(310, 230);
            btnCappuccino.Name = "btnCappuccino";
            btnCappuccino.Size = new Size(39, 39);
            btnCappuccino.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCappuccino.TabIndex = 4;
            btnCappuccino.TabStop = false;
            btnCappuccino.Click += btnCappuccino_Click;
            // 
            // btnCha
            // 
            btnCha.BackColor = Color.Transparent;
            btnCha.Image = Properties.Resources.btnPequenoPNG;
            btnCha.Location = new Point(310, 309);
            btnCha.Name = "btnCha";
            btnCha.Size = new Size(39, 39);
            btnCha.SizeMode = PictureBoxSizeMode.AutoSize;
            btnCha.TabIndex = 4;
            btnCha.TabStop = false;
            btnCha.Click += btnCha_Click;
            // 
            // btnChocolate
            // 
            btnChocolate.BackColor = Color.Transparent;
            btnChocolate.Image = Properties.Resources.btnPequenoPNG;
            btnChocolate.Location = new Point(254, 309);
            btnChocolate.Name = "btnChocolate";
            btnChocolate.Size = new Size(39, 39);
            btnChocolate.SizeMode = PictureBoxSizeMode.AutoSize;
            btnChocolate.TabIndex = 4;
            btnChocolate.TabStop = false;
            btnChocolate.Click += btnChocolate_Click;
            // 
            // imgCopo
            // 
            imgCopo.BackColor = Color.Transparent;
            imgCopo.Enabled = false;
            imgCopo.Image = Properties.Resources.copoPNG;
            imgCopo.Location = new Point(70, 423);
            imgCopo.Name = "imgCopo";
            imgCopo.Size = new Size(459, 266);
            imgCopo.SizeMode = PictureBoxSizeMode.AutoSize;
            imgCopo.TabIndex = 5;
            imgCopo.TabStop = false;
            imgCopo.Visible = false;
            imgCopo.Click += imgCopo_Click;
            // 
            // lblVisor
            // 
            lblVisor.BackColor = Color.Transparent;
            lblVisor.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVisor.Location = new Point(69, 95);
            lblVisor.Name = "lblVisor";
            lblVisor.Size = new Size(214, 27);
            lblVisor.TabIndex = 6;
            lblVisor.Text = "Em funcionamento";
            lblVisor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgRanhura
            // 
            imgRanhura.BackColor = Color.Transparent;
            imgRanhura.Image = Properties.Resources.RanhuraMoedaPNG1;
            imgRanhura.Location = new Point(354, 54);
            imgRanhura.Name = "imgRanhura";
            imgRanhura.Size = new Size(60, 126);
            imgRanhura.SizeMode = PictureBoxSizeMode.AutoSize;
            imgRanhura.TabIndex = 7;
            imgRanhura.TabStop = false;
            imgRanhura.MouseHover += imgRanhura_MouseHover;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 796);
            Controls.Add(lblVisor);
            Controls.Add(imgCopo);
            Controls.Add(btnChocolate);
            Controls.Add(btnCha);
            Controls.Add(btnCappuccino);
            Controls.Add(btnCafe);
            Controls.Add(btnTrocoGrande);
            Controls.Add(imgColocarMoeda);
            Controls.Add(imgMoedaTroco);
            Controls.Add(imgMaquinaBebidas);
            Controls.Add(imgRanhura);
            Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Maquina de Bebidas";
            ((System.ComponentModel.ISupportInitialize)imgMaquinaBebidas).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMoedaTroco).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgColocarMoeda).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnTrocoGrande).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCafe).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCappuccino).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCha).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnChocolate).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCopo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgRanhura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgMaquinaBebidas;
        private PictureBox imgMoedaTroco;
        private PictureBox imgColocarMoeda;
        private PictureBox btnTrocoGrande;
        private PictureBox btnCafe;
        private PictureBox btnCappuccino;
        private PictureBox btnCha;
        private PictureBox btnChocolate;
        private PictureBox imgCopo;
        private Label lblVisor;
        private PictureBox imgRanhura;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

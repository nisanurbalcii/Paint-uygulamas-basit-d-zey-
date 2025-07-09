namespace örnek12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSilgi = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            buttonRenkSec = new Button();
            btnTumunuSil = new Button();
            buttonArkaPlan = new Button();
            buttonKaydet = new Button();
            btnGeriAl = new Button();
            btnIleriAl = new Button();
            cmbSekil = new ComboBox();
            fontDialog1 = new FontDialog();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnFontSec = new Button();
            btnYaziModu = new Button();
            txtYazi = new TextBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // buttonSilgi
            // 
            buttonSilgi.BackColor = Color.LightPink;
            buttonSilgi.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonSilgi.Location = new Point(16, 235);
            buttonSilgi.Name = "buttonSilgi";
            buttonSilgi.Size = new Size(33, 32);
            buttonSilgi.TabIndex = 0;
            buttonSilgi.Text = "TEMİZLE";
            buttonSilgi.UseVisualStyleBackColor = false;
            buttonSilgi.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.White;
            trackBar1.Location = new Point(9, 146);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(138, 56);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(156, 152);
            label1.Name = "label1";
            label1.Size = new Size(28, 24);
            label1.TabIndex = 2;
            label1.Text = "***";
            // 
            // buttonRenkSec
            // 
            buttonRenkSec.BackColor = Color.Lime;
            buttonRenkSec.Font = new Font("Georgia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonRenkSec.Location = new Point(98, 65);
            buttonRenkSec.Name = "buttonRenkSec";
            buttonRenkSec.Size = new Size(86, 75);
            buttonRenkSec.TabIndex = 3;
            buttonRenkSec.Text = "RENK PALETİ";
            buttonRenkSec.UseVisualStyleBackColor = false;
            buttonRenkSec.Click += button2_Click;
            // 
            // btnTumunuSil
            // 
            btnTumunuSil.BackColor = Color.Red;
            btnTumunuSil.Font = new Font("Georgia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnTumunuSil.Location = new Point(66, 226);
            btnTumunuSil.Name = "btnTumunuSil";
            btnTumunuSil.Size = new Size(118, 43);
            btnTumunuSil.TabIndex = 4;
            btnTumunuSil.Text = "TÜMÜNÜ SİL";
            btnTumunuSil.UseVisualStyleBackColor = false;
            btnTumunuSil.Click += button3_Click;
            // 
            // buttonArkaPlan
            // 
            buttonArkaPlan.BackColor = Color.Yellow;
            buttonArkaPlan.Font = new Font("Georgia", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonArkaPlan.Location = new Point(9, 65);
            buttonArkaPlan.Name = "buttonArkaPlan";
            buttonArkaPlan.Size = new Size(86, 75);
            buttonArkaPlan.TabIndex = 5;
            buttonArkaPlan.Text = "SAYFA RENGİNİ DEĞİŞ";
            buttonArkaPlan.UseVisualStyleBackColor = false;
            buttonArkaPlan.Click += buttonArkaPlan_Click;
            // 
            // buttonKaydet
            // 
            buttonKaydet.BackColor = Color.Yellow;
            buttonKaydet.Location = new Point(19, 17);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(41, 34);
            buttonKaydet.TabIndex = 6;
            buttonKaydet.Text = "KAYDET";
            buttonKaydet.UseVisualStyleBackColor = false;
            buttonKaydet.Click += button5_Click;
            // 
            // btnGeriAl
            // 
            btnGeriAl.BackColor = Color.Red;
            btnGeriAl.Location = new Point(79, 23);
            btnGeriAl.Name = "btnGeriAl";
            btnGeriAl.Size = new Size(16, 23);
            btnGeriAl.TabIndex = 7;
            btnGeriAl.Text = "GERİ AL";
            btnGeriAl.UseVisualStyleBackColor = false;
            btnGeriAl.Click += btnGeriAl_Click;
            // 
            // btnIleriAl
            // 
            btnIleriAl.BackColor = Color.LimeGreen;
            btnIleriAl.Location = new Point(136, 23);
            btnIleriAl.Name = "btnIleriAl";
            btnIleriAl.Size = new Size(27, 28);
            btnIleriAl.TabIndex = 8;
            btnIleriAl.Text = "İLERİ AL";
            btnIleriAl.UseVisualStyleBackColor = false;
            btnIleriAl.Click += btnIleriAl_Click;
            // 
            // cmbSekil
            // 
            cmbSekil.BackColor = Color.White;
            cmbSekil.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbSekil.FormattingEnabled = true;
            cmbSekil.Items.AddRange(new object[] { "Serbest Çizim", "Dikdörtgen", "Daire", "Çizgi" });
            cmbSekil.Location = new Point(9, 192);
            cmbSekil.Name = "cmbSekil";
            cmbSekil.Size = new Size(175, 26);
            cmbSekil.TabIndex = 9;
            cmbSekil.Text = "ÇİZİM MODU...";
            cmbSekil.SelectedIndexChanged += cmbSekil_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 47);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 47);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 47);
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 224);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 45);
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // btnFontSec
            // 
            btnFontSec.BackColor = Color.FromArgb(255, 192, 255);
            btnFontSec.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFontSec.Location = new Point(101, 273);
            btnFontSec.Name = "btnFontSec";
            btnFontSec.Size = new Size(83, 41);
            btnFontSec.TabIndex = 14;
            btnFontSec.Text = "FONT";
            btnFontSec.UseVisualStyleBackColor = false;
            btnFontSec.Click += btnFontSec_Click;
            // 
            // btnYaziModu
            // 
            btnYaziModu.BackColor = Color.FromArgb(255, 192, 255);
            btnYaziModu.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYaziModu.Location = new Point(9, 273);
            btnYaziModu.Name = "btnYaziModu";
            btnYaziModu.Size = new Size(83, 41);
            btnYaziModu.TabIndex = 15;
            btnYaziModu.Text = "MOD";
            btnYaziModu.UseVisualStyleBackColor = false;
            btnYaziModu.Click += btnYaziModu_Click;
            // 
            // txtYazi
            // 
            txtYazi.BackColor = Color.MistyRose;
            txtYazi.Location = new Point(9, 320);
            txtYazi.Multiline = true;
            txtYazi.Name = "txtYazi";
            txtYazi.Size = new Size(175, 31);
            txtYazi.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1095, 558);
            Controls.Add(pictureBox3);
            Controls.Add(buttonKaydet);
            Controls.Add(cmbSekil);
            Controls.Add(txtYazi);
            Controls.Add(btnYaziModu);
            Controls.Add(btnFontSec);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnIleriAl);
            Controls.Add(btnGeriAl);
            Controls.Add(buttonArkaPlan);
            Controls.Add(btnTumunuSil);
            Controls.Add(buttonRenkSec);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(buttonSilgi);
            Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSilgi;
        private TrackBar trackBar1;
        private Label label1;
        private Button buttonRenkSec;
        private Button btnTumunuSil;
        private Button buttonArkaPlan;
        private Button buttonKaydet;
        private Button btnGeriAl;
        private Button btnIleriAl;
        private ComboBox cmbSekil;
        private Button buttonYaziEkle;
        private FontDialog fontDialog1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Button btnFontSec;
        private Button btnYaziModu;
        private TextBox txtYazi;
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace örnek12
{
    public partial class Form1 : Form
    {
        bool basiliMi = false;
        bool silgiModu = false;
        Color secilenRenk = Color.Black;
        int fircaBoyutu = 5;
        Bitmap canvas;//Bitmap sınıfı, görüntü verilerini (pikselleri) bellekte saklamak için kullanılır.
        Graphics g; // Bir Bitmap veya başka bir çizim yüzeyi üzerine çizim yapmak için kullanılan metotları sağlar (çizgiler, şekiller, metinler vb. çizmek için).
        string cizimModu = "Serbest Çizim";
        Point baslangicNoktasi;//Point Şekil çizimine başlandığı (fareye ilk tıklandığı) noktanın X ve Y koordinatlarını saklar.
        bool sekilCiziliyor = false;//Şu anda bir şekil çizme işleminin devam edip etmediğini gösterir.
        List<Bitmap> undoList = new List<Bitmap>();//Bu satırda, Bitmap nesnelerini saklayan bir liste oluşturulur. Bu liste, "Geri Al" (Undo) işlevselliği için çizim geçmişini tutar.
                                                   //Her çizim adımından sonra canvas'ın bir kopyası bu listeye eklenir.
        List<Bitmap> redoList = new List<Bitmap>();//Bitmap nesnelerini saklayan bir listedir. "İleri Al" (Redo) işlevselliği için kullanılır.
                                                   //Bir geri alma işleminden sonraki durumlar bu listede saklanır.
        bool yaziModu = false;
        string yazilacakMetin = " ";
        Font yazıFont = new Font("Arial", 20);
        Brush yazıRengi;




        public Form1()
        {
            InitializeComponent();
            canvas = new Bitmap(this.ClientSize.Width, this.ClientSize.Height); //Formun boyutuna uygun bir tuval (canvas) oluşturur
            g = Graphics.FromImage(canvas); //çizim yapmak için bir Graphics nesnesi oluşturur ve g değişkenine atar. 
            this.BackColor = Color.White;
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 30;
            trackBar1.Value = 5;
            label1.Text = "5";
            this.DoubleBuffered = true;//Bu, çizim işlemlerinin daha akıcı görünmesini sağlar, özellikle karmaşık veya sık sık güncellenen çizimlerde titremeyi azaltır.

            // Mouse event'lerini bağlıyoruz
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
            this.Paint += Form1_Paint;
        }
        private void KaydetGeriAlAdimi()
        {
            if (canvas != null)
            {
                undoList.Add((Bitmap)canvas.Clone());  // Canvas'ın mevcut halini kaydediyoruz
                redoList.Clear();  // Yeni bir işlem yapılınca ileri al sıfırlanır
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e) //Kullanıcı bir fare düğmesine bastığında (sol, sağ veya orta düğme) bu olay tetiklenir.
        {
            if (yaziModu)
            {
                if (!string.IsNullOrWhiteSpace(txtYazi.Text))//metin kutusunun boş olup olmadığını kontrol eder.
                {
                    yazilacakMetin = txtYazi.Text;

                    using (Graphics g = Graphics.FromImage(canvas))
                    {
                        yazıRengi = new SolidBrush(secilenRenk); // Yazı rengini güncelle
                        g.DrawString(yazilacakMetin, yazıFont, yazıRengi, e.Location);//farenin tıklandığı yere yazılan metin yapıştırılır
                    }

                    KaydetGeriAlAdimi();
                    this.Invalidate(); // Ekranı yenile
                }
                return; // Yazı modundaysa diğer çizim işlemlerini yapma.Yazı modunda çizim yapılmayacağı için metottan çıkar.
            }
                basiliMi = true;//Fare tuşunun basılı olduğunu işaretler.
                sekilCiziliyor = true;//Bir şekil çizme işleminin başladığını işaretler.
                baslangicNoktasi = e.Location;
            

            KaydetGeriAlAdimi();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)//Kullanıcı bir fare düğmesini bıraktığında bu olay tetiklenir.
        {
            basiliMi = false;

            if (sekilCiziliyor && cizimModu != "Serbest Çizim")
            {
                Point bitisNoktasi = e.Location;
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    Pen kalem = new Pen(secilenRenk, fircaBoyutu);//Seçilen renk ve fırça boyutuyla yeni bir Pen (çizgi çizmek için kullanılan araç) oluşturur.
                    if (cizimModu == "Dikdörtgen")
                        g.DrawRectangle(kalem, Rectangle.FromLTRB(baslangicNoktasi.X, baslangicNoktasi.Y, bitisNoktasi.X, bitisNoktasi.Y));
                    else if (cizimModu == "Daire")
                        g.DrawEllipse(kalem, Rectangle.FromLTRB(baslangicNoktasi.X, baslangicNoktasi.Y, bitisNoktasi.X, bitisNoktasi.Y));
                    else if (cizimModu == "Çizgi")
                        g.DrawLine(kalem, baslangicNoktasi, bitisNoktasi);

                    kalem.Dispose();//Pen nesnesinin kullandığı kaynakları serbest bırakır.
                }

                KaydetGeriAlAdimi();
                this.Invalidate();
            }

            sekilCiziliyor = false;
        }




        private void Form1_MouseMove(object sender, MouseEventArgs e)//Kullanıcı fareyi bir nesnenin veya pencerenin üzerinde hareket ettirdiğinde bu olay tetiklenir.
        {
            if (basiliMi && cizimModu == "Serbest Çizim")
            {
                using (Graphics g = Graphics.FromImage(canvas))
                {
                    Color aktifRenk = silgiModu ? this.BackColor : secilenRenk;//Eğer silgi modu aktifse, aktif renk formun arka plan rengi olur.
                                                                               //Aksi takdirde, seçilen çizim rengi kullanılır.
                    using (SolidBrush firca = new SolidBrush(aktifRenk))
                    {
                        g.FillEllipse(firca, e.X - fircaBoyutu / 2, e.Y - fircaBoyutu / 2, fircaBoyutu, fircaBoyutu); //bu satır minik daireler çizerek sanki düz bi çizgi varmış gibi görünmesini sağlar 
                    }
                }

                this.Invalidate();
            }
        }
        //Geçici Graphics nesneleri oluşturmamızın temel nedenleri, kaynakların güvenli ve otomatik yönetimi ile her çizim anında doğru ve güncel çizim yüzeyine erişimi sağlamaktır.
        //Bu, daha sağlam, güvenilir ve performanslı bir uygulama geliştirmemize yardımcı olur.



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, Point.Empty);//Bu metot, canvas üzerinde yapılan tüm çizimleri formun üzerine aktarır.
                                                      //Invalidate() metodu çağrıldığında, bu metot çalışır ve canvas'ın güncel içeriği ekrana yansıtılır.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            silgiModu = !silgiModu; //  silgiModu false ise true yapar, true ise false yapar     
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            fircaBoyutu = trackBar1.Value; // Fırça boyutunu ayarla
            label1.Text = fircaBoyutu.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog renkDialog = new ColorDialog(); // Renk seçici
            if (renkDialog.ShowDialog() == DialogResult.OK)
            {
                secilenRenk = renkDialog.Color; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(canvas)) // Canvas'ı temizle
            {
                g.Clear(this.BackColor); // Arka plan rengini temizle
            }
            this.Invalidate(); 
        }


        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Resmi|*.png|JPEG Resmi|*.jpg";
            sfd.Title = "Çalışmayı Kaydet";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                canvas.Save(sfd.FileName); 

            }
        }

        private void buttonArkaPlan_Click(object sender, EventArgs e)
        {
            ColorDialog renkDialog = new ColorDialog();
            if (renkDialog.ShowDialog() == DialogResult.OK)
            {
                Color yeniArkaPlanRenk = renkDialog.Color;
                this.BackColor = yeniArkaPlanRenk;
                Bitmap eskiCanvas = (Bitmap)canvas.Clone(); // Eski çizimleri sakla (arka plan hariç)
                Bitmap yeniCanvas = new Bitmap(canvas.Width, canvas.Height); // Yeni boş canvas oluştur ve arka planı boya
                using (Graphics gYeni = Graphics.FromImage(yeniCanvas))
                {
                    gYeni.Clear(yeniArkaPlanRenk);          // Yeni arka planı boya
                    gYeni.DrawImage(eskiCanvas, 0, 0);      // Eski çizimleri geçir
                }
                canvas = yeniCanvas;// Güncel canvas ve grafik objesini ata
                g = Graphics.FromImage(canvas);

                KaydetGeriAlAdimi();  // Geri al listesine ekle
                this.Invalidate();  
            }
        }


        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            if (undoList.Count > 0)
            {
                redoList.Add((Bitmap)canvas.Clone());  // Şu anki durumu redoList'e ekle
                canvas = (Bitmap)undoList[undoList.Count - 1].Clone();  // Undo'dan son durumu al
                undoList.RemoveAt(undoList.Count - 1);  // Undo'dan son durumu çıkar
                this.Invalidate();
            }
        }

        private void btnIleriAl_Click(object sender, EventArgs e)
        {
            if (redoList.Count > 0)
            {
                undoList.Add((Bitmap)canvas.Clone());  // Şu anki durumu undoList'e ekle
                canvas = (Bitmap)redoList[redoList.Count - 1].Clone();  // Redo'dan son durumu al
                redoList.RemoveAt(redoList.Count - 1);  // Redo'dan son durumu çıkar
                this.Invalidate();
            }
        }

        private void cmbSekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cizimModu = cmbSekil.SelectedItem.ToString();//combobox ta Seçilen öğenin metnini alır ve cizimModu değişkenine atar.
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            btnGeriAl_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            btnIleriAl_Click((object)sender, e);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button5_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void btnYaziModu_Click(object sender, EventArgs e)
        {
            yaziModu = !yaziModu;//yazı modunu açar veya kapatır.
            btnYaziModu.Text = yaziModu ? "Yazı Modu" : "Çizim Modu";
        }

        private void btnFontSec_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = yazıFont;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                yazıFont = fontDialog.Font;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SecmenSapka
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

        }

        protected List<string> Soru = new List<string>();
        protected List<string> Asıkkı = new List<string>();
        protected List<string> Bsıkkı = new List<string>();
        protected List<string> Csıkkı = new List<string>();
        protected List<string> Dsıkkı = new List<string>();
        protected int soruSayac = 0;
        protected int slytherinSayac = 0;
        protected int grifindorSayac = 0;
        protected int hufflepuffSayac = 0;
        protected int ravenclawSayac = 0;
        protected int RndSayi = 0;
        protected int Kontrol = 0;
        
        readonly Database db = new Database();
        private readonly Random rastgele = new Random();
        readonly SoundPlayer sound = new SoundPlayer();
        readonly SoundPlayer fonPlayer = new SoundPlayer();



        private void SoruForm_Load(object sender, EventArgs e)
        {
            fonPlayer.SoundLocation = "harry-potter-theme-song_2.wav";
            fonPlayer.Play();
            Asıkkı_Rdbtn.Visible = false;
            Bsıkkı_Rdbtn.Visible = false;
            Csıkkı_Rdbtn.Visible = false;
            Dsıkkı_Rdbtn.Visible = false;
            İleri_Btn.Visible = false;
            Sınıf_Btn.Visible = false;
            Gizle();
            Soru_Lbl.Text = "Hoş geldiniz.Sizi en uygun Hogwarts sınıfına yerleştirmek için sınava tabi tutacağız.Buna Hazır mısınız?";
        }

        //programı başlatıyor
        private void Hazır_Btn_Click(object sender, EventArgs e)
        {
            Soruekme();
            Goster();
            Asıkkı_Rdbtn.Visible = true;
            Bsıkkı_Rdbtn.Visible = true;
            Csıkkı_Rdbtn.Visible = true;
            Dsıkkı_Rdbtn.Visible = true;
            İleri_Btn.Visible = true;
            Hazır_Btn.Visible = false;
            Sınıf_Btn.Visible = false;
            SecmenSapkaSüre_timer.Start();
            SoruDegis();
        }

        //diger soruya gecis yapıyoruz
        private void İleri_Btn_Click(object sender, EventArgs e)
        {
            if (Asıkkı_Rdbtn.Checked == false && Bsıkkı_Rdbtn.Checked == false && Csıkkı_Rdbtn.Checked == false && Dsıkkı_Rdbtn.Checked == false)
            {
                MessageBox.Show("Lütfen bir şık seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (Asıkkı_Rdbtn.Checked == true)
                {
                    grifindorSayac++;
                }
                else if (Bsıkkı_Rdbtn.Checked == true)
                {
                    slytherinSayac++;
                }
                else if (Csıkkı_Rdbtn.Checked == true)
                {
                    hufflepuffSayac++;
                }
                else if (Dsıkkı_Rdbtn.Checked == true)
                {
                    ravenclawSayac++;
                }
                SoruDegis();
            }
        }

        //hangi sınıfa mevcut oldugumuza karar veriyor
        private void Sınıf_Btn_Click(object sender, EventArgs e)
        {
            Soru_Lbl.Visible = false;
            MessageBox.Show("G=" + grifindorSayac + "S=" + slytherinSayac + "H=" + hufflepuffSayac + "R=" + ravenclawSayac + " SoruSayaç" + soruSayac);
            if ((grifindorSayac >= slytherinSayac) && (grifindorSayac >= hufflepuffSayac) && (grifindorSayac >= ravenclawSayac))
            {
                YapayKonus(1, 1, true, "Gryffindor");
                sound.SoundLocation = "Gryffindor.wav";
                sound.Play();
            }
            else if ((slytherinSayac > grifindorSayac) && (slytherinSayac >= hufflepuffSayac) && (slytherinSayac >= ravenclawSayac))
            {
                YapayKonus(1, 1, true, "Slytherin");
                sound.SoundLocation = "Slytherin.wav";
                sound.Play();
            }
            else if ((hufflepuffSayac > slytherinSayac) && (hufflepuffSayac > grifindorSayac) && (hufflepuffSayac >= ravenclawSayac))
            {
                YapayKonus(1, 1, true, "Hufflepuff");
                sound.SoundLocation = "Hfflepuff .wav";
                sound.Play();
            }
            else if ((ravenclawSayac > slytherinSayac) && (ravenclawSayac > grifindorSayac) && (ravenclawSayac > hufflepuffSayac))
            {
                YapayKonus(1, 1, true, "Ravenclaw");
                sound.SoundLocation = "Ravenclaw.wav";
                sound.Play();
            }
            else
            {
                MessageBox.Show("hi");
            }
        }


        public void SoruDegis()
        {
            if (soruSayac == 13)
            {
                sound.SoundLocation = "finish.wav";
                sound.Play();
                Asıkkı_Rdbtn.Visible = false;
                Bsıkkı_Rdbtn.Visible = false;
                Csıkkı_Rdbtn.Visible = false;
                Dsıkkı_Rdbtn.Visible = false;
                Soru_Lbl.Visible = false;
                Sınıf_Btn.Visible = true;
                İleri_Btn.Visible = false;
                Hazır_Btn.Visible = false;
            }
            else
            {
                Soru_Lbl.Text     = Soru[soruSayac].ToString();
                Asıkkı_Rdbtn.Text = Asıkkı[soruSayac].ToString();
                Bsıkkı_Rdbtn.Text = Bsıkkı[soruSayac].ToString();
                Csıkkı_Rdbtn.Text = Csıkkı[soruSayac].ToString();
                Dsıkkı_Rdbtn.Text = Dsıkkı[soruSayac].ToString();
                YapayKonus(soruSayac,Kontrol,false,"");
                soruSayac++;
                Kontrol++;
                Asıkkı_Rdbtn.Checked = false;
                Bsıkkı_Rdbtn.Checked = false;
                Csıkkı_Rdbtn.Checked = false;
                Dsıkkı_Rdbtn.Checked = false;
            }
        }

        public void Soruekme()
        {
            if (db.baglanti.State == ConnectionState.Open)
            {
                db.baglanti.Close();
            }
            try
            {
                db.baglanti.Open();
                SqlCommand SoruCek = new SqlCommand("SELECT TOP 13 * FROM Soru ORDER BY NEWID()", db.baglanti);
                SqlDataReader SoruOku = SoruCek.ExecuteReader();

                while (SoruOku.Read())
                {
                    Soru.Add(SoruOku[1].ToString());
                    Asıkkı.Add(SoruOku[2].ToString());
                    Bsıkkı.Add(SoruOku[3].ToString());
                    Csıkkı.Add(SoruOku[4].ToString());
                    Dsıkkı.Add(SoruOku[5].ToString());
                }
                SoruOku.Close();
                SoruCek.Dispose();
            }

            catch (Exception hata)
            {
                MessageBox.Show("" + hata);
            }
        }
         
        //secmen sapka goruntu
        protected void YapayKonus(int sayi ,int kontrol,bool izin,string tur)
        {
            RndSayi = rastgele.Next(0, 5);

            if(sayi==0 && kontrol==0)
            {
                RichMetinKutusu.Text = "HOŞGELDİN BAKALIM AKLIN BİZE NE SÖYLÜYECEK.";
                sound.SoundLocation = "1.wav";
                sound.Play();
            }

            if (soruSayac % 3 == 0 && kontrol == 3)
            {
                Goster();
                SecmenSapkaSüre_timer.Start();
                RichMetinKutusu.Text = "HMMMMM... Anlamaya başlıyorum sanırım.";
                sound.SoundLocation = "2.wav";
                sound.Play();
            }
            if(soruSayac %3==0 && kontrol>3)
            {
                Goster();
                SecmenSapkaSüre_timer.Start();
                if (RndSayi==1)
                {
                    RichMetinKutusu.Text = "İlginç cevaplar doğrusu, merak uyandırdın bende.";
                    sound.SoundLocation = "3.wav";
                    sound.Play();
                }
                else if(RndSayi==0)
                {
                    RichMetinKutusu.Text = "Merak konusu olan ne biliyor musun? Verdiğin cevaplar.";
                    sound.SoundLocation = "4.wav";
                    sound.Play();
                }
                else if(RndSayi==2)
                {
                    RichMetinKutusu.Text = "Çok tuhaf biri olduğunu itiraf etmem gerek doğrusu.";
                    sound.SoundLocation = "5.wav";
                    sound.Play();
                }
                else if(RndSayi==3)
                {
                    RichMetinKutusu.Text = "Haaah... İlginç senin gibi birisini daha önce gördüm galiba";
                    sound.SoundLocation = "6.wav";
                    sound.Play();
                }
                else
                {
                    RichMetinKutusu.Text = "Senin muazzam biri olduğunu düşünüyorum.Bakalım haklı mıyım?";
                    sound.SoundLocation = "7.wav";
                    sound.Play();
                }
            }
            if(izin== true)
            {
                Goster();
                MetinOkuma_timer.Start();
                if (tur == "Gryffindor") 
                {
                    RichMetinKutusu.Text = "Seni Gryffindor'a yollarım belki zamanla olursun aslanın teki.Yiğittir Gryffindor'da kalan çocuklar.Hepsinin yüreği, nah mangal kadar.";
                }
                else if (tur== "Slytherin")
                {
                    RichMetinKutusu.Text = "Düşersin belki de Slytherin'e sen.Bir başkadır sanki oraya giden.Amaçları için neler yapmazlar açıklasam bitmez sabaha kadar.";
                }
                else if(tur== "Hufflepuff")
                {
                    RichMetinKutusu.Text = "Belki de düşersin Hfflepuff'a Haksızlığı hemen kaldırıp rafa,Adalet uğruna savaş verirsin.Her yere mutluluk götürmek için.";
                }
                else if(tur== "Ravenclaw")
                {
                    RichMetinKutusu.Text = "Ravenclaw kısmetin belki.Oradikilerin hiç çıkmaz sesi, mantıktır onlarca önemli olan.Öyle kurtulurlar tüm sorunlardan.";
                }
            }
        }



        protected void Goster()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            RichMetinKutusu.Visible = true;
        }

        protected void Gizle()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            RichMetinKutusu.Visible = false;
        }



        protected int deneme;
        protected bool secim=true;
        private void SesAcmaKapama_Pcbx_Click(object sender, EventArgs e)
        {
            if (deneme % 2 == 0)
            {
                SesAcmaKapama_Pcbx.Image = Properties.Resources.mute;
                fonPlayer.Stop();
            }
            else
            {
                SesAcmaKapama_Pcbx.Image = Properties.Resources.volume;
                fonPlayer.Play();
            }
            deneme++;
        }

        private void SecmenSapkaSüre_timer_Tick(object sender, EventArgs e)
        {
            if (SecmenSapkaSüre_timer.Interval == 6000)
            {
                Gizle();
                SecmenSapkaSüre_timer.Stop();
                fonPlayer.Play();
            }
        }

        private void MetinOkuma_timer_Tick(object sender, EventArgs e)
        {
            if (MetinOkuma_timer.Interval == 10000)
            {
                Gizle();
                MetinOkuma_timer.Stop();
                fonPlayer.Play();
            }
        }
    }
}

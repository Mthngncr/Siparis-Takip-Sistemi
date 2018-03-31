using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdminSayfasi : Form
    {
        public static string isim3;
        public AdminSayfasi()
        {
            InitializeComponent();
            label1.Text = "Hoşgeldiniz " + " " + isim3;

        }

        private void musteri_ekle_Click(object sender, EventArgs e)
        {
           
            MusteriEkleme musteri_ekle = new MusteriEkleme();
            musteri_ekle.ShowDialog();
        }

        private void urun_bilgi_Click(object sender, EventArgs e)
        {
            UrunBilgileri urun_bilgi = new UrunBilgileri();
            urun_bilgi.ShowDialog();
        }

        private void urun_guncelle_Click(object sender, EventArgs e)
        {
            UrunGuncelleme urun_guncelle = new UrunGuncelleme();
            urun_guncelle.ShowDialog();
        }

        private void musteri_detayi_Click(object sender, EventArgs e)
        {
            MusteriDetayi musteri_detayi = new MusteriDetayi();
            musteri_detayi.ShowDialog();

        }

        private void urun_detayi_Click(object sender, EventArgs e)
        {
            UrunDetayi urun_detayi = new UrunDetayi();
            urun_detayi.ShowDialog();
        }

        private void Urun_Sil_Click(object sender, EventArgs e)
        {
            UrunSil urun_sil = new UrunSil();
            urun_sil.ShowDialog();
        }

        private void Musteri_Sil_Click(object sender, EventArgs e)
        {
            MusteriSil silme_islemi = new MusteriSil();
            silme_islemi.ShowDialog();
        }
    }
}

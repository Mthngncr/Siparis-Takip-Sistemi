using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    public partial class SiparisEkrani : Form
    {

        public SiparisEkrani()
        {
            InitializeComponent();
            goruntule_musteri = database.Musteri.Include(z => z.Siparis).Where(r => r.Ad == isim2).FirstOrDefault();
            if (goruntule_musteri.Admin == 0)
            {
                Admin_Giris.Visible = false;
            }
            else
            {
                Admin_Giris.Visible = true;
            }
        }
        Urun goruntule_urun = new Urun();
        Siparis goruntule_siparis = new Siparis();
        Musteri goruntule_musteri = new Musteri();
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        public static string isim2;
        double toplam = 0;

        private void Musteri_Guncelleme_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme musteriguncel = new MusteriGuncelleme();
            musteriguncel.ShowDialog();
        }
        private void Admin_Giris_Click(object sender, EventArgs e)
        {
            AdminSayfasi admin = new AdminSayfasi();
            admin.ShowDialog();
        }

        private void Siparis_Ekle_Click(object sender, EventArgs e)
        {
            goruntule_musteri = database.Musteri.Include(z => z.Siparis).Where(r => r.Ad == isim2).FirstOrDefault();
            goruntule_urun = database.Urun.Include(z => z.Siparis).Where(x => x.UrunAd==Siparisler_Combo.SelectedItem.ToString()).FirstOrDefault();
            label5.Text = "Fiyat:" + goruntule_urun.Fiyat.ToString("0.##") + " " + "TL";
            label6.Text = "Stok:" + goruntule_urun.Stok;

            if (goruntule_urun.Stok > 0)
            {

                if (goruntule_musteri.Bakiye >= goruntule_urun.Fiyat)
                {

                    toplam += goruntule_urun.Fiyat;
                    goruntule_siparis.MusteriId = goruntule_musteri.Id;
                    goruntule_siparis.UrunId = goruntule_urun.Id;
                    Siparisler_Listbox.Items.Add(Siparisler_Combo.SelectedItem);
                    goruntule_musteri.Bakiye -= goruntule_urun.Fiyat;
                    goruntule_urun.Stok -= 1;
                    label4.Text ="Toplam:"+ toplam.ToString("0.##") + " " + "TL";
                    Bakiye.Text = goruntule_musteri.Bakiye.ToString("0.##") + " " + "TL";
                    database.Siparis.Add(goruntule_siparis);
                    database.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Bakiyeniz Yetersizdir!!");
                }
            }
            else
            {
                MessageBox.Show("Ürün Stokta Yok!!");
            }
        }

        private void SiparisEkrani_Load(object sender, EventArgs e)
        {


            var goster = from a in database.Urun
                    select a.UrunAd;
            Siparisler_Combo.DataSource = goster.ToList() ;
            Bakiye.Text= goruntule_musteri.Bakiye.ToString("0.##") + " " + "TL";
        }

        private void Satin_Al_Click(object sender, EventArgs e)
        {
            if(Siparisler_Listbox.Items.Count<1)
            {
                MessageBox.Show("Seçilen Ürün Yok!!");
            }
            else
            {
                MessageBox.Show("Satın Alma Başarılı!!");
                this.Close();
            }
        }

      
    }
}

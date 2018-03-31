using EFDemo.DB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    public partial class SiparisEkrani : Form
    {
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        public static string isim2;
        Urun ekle_urun = new Urun();
        Siparis ekle_siparis = new Siparis();
        Musteri ekle_musteri = new Musteri();
        double toplam = 0;
        public SiparisEkrani()
        {
            InitializeComponent();
            ekle_musteri = database.Musteri.Include(z => z.Siparis).Where(t => t.Ad == isim2).FirstOrDefault();
            if (ekle_musteri.Admin == 0)
            {
                admin_girisi.Visible = false;
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun_Combo.Text = "";
        }
        private void SiparisEkrani_Load(object sender, EventArgs e)
        {
            ekle_musteri = database.Musteri.Include(z => z.Siparis).Where(t => t.Ad == isim2).FirstOrDefault();
            var goster = from k in database.Urun
                         select k;
            Urun_Combo.DataSource = goster.ToList();
            Urun_Combo.ValueMember = "ID";
            Urun_Combo.DisplayMember = "URUNAD";
            Bakiye.Text = ekle_musteri.Bakiye.ToString() + " " + "TL";
        }
        private void musteri_guncelle_Click(object sender, EventArgs e)
        {
            MusteriGuncelleme musteri_guncelle = new MusteriGuncelleme();
            musteri_guncelle.ShowDialog();
        }

        private void satin_al_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Başarıyla Alınmıştır!");
            this.Close();
        }
        private void sepete_ekle_Click(object sender, EventArgs e)
        {
            if (Urun_Combo.Text != null)
            {
                Urun_ListBox.Items.Add(Urun_Combo.Text);
                ekle_musteri = database.Musteri.Include(z => z.Siparis).Where(t => t.KullanıcıAdı == isim2).FirstOrDefault();
                ekle_urun = database.Urun.Include(g => g.Siparis).Where(h => h.UrunAd == Urun_Combo.Text).FirstOrDefault();
                toplam = toplam + ekle_urun.Fiyat;
                if (ekle_urun.Stok > 0)
                {
                    if (ekle_musteri.Bakiye >= 0)
                    {
                        if (ekle_musteri.Bakiye >= ekle_urun.Fiyat)
                        {
                            Toplam_Fiyat.Text = toplam + " " + "TL";
                            ekle_musteri.Bakiye = ekle_musteri.Bakiye - ekle_urun.Fiyat;
                            ekle_urun.Stok = ekle_urun.Stok - 1;
                            ekle_siparis.UrunId = ekle_urun.Id;
                            ekle_siparis.MusteriId = ekle_musteri.Id;
                            database.Siparis.Add(ekle_siparis);
                            database.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz Yetersiz!!");
                            Urun_ListBox.Items.Clear();
                        }
                    }
                }
                else
                {
                    Urun_ListBox.Items.Remove(ekle_urun.UrunAd);
                    MessageBox.Show("Ürün Stokta Yok!!");
                }
            }
        }
        private void admin_giris_Click(object sender, EventArgs e)
        {
            AdminSayfasi form1 = new AdminSayfasi();
            form1.ShowDialog();
        }
    }
}

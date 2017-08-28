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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
            Sifre.PasswordChar = '*';

        }
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        Musteri musteri_isim = new Musteri();
       
        private void giris_Click(object sender, EventArgs e)
        {

            var q = from a in database.Musteri where (a.KullanıcıAdı == Kullanici_Adi.Text && a.Password == Sifre.Text) select a;
            if (q.Any())
            {
                musteri_isim = database.Musteri.Include(z => z.Siparis).Where(d => d.KullanıcıAdı == Kullanici_Adi.Text).FirstOrDefault();
                AdminSayfasi.isim3 = musteri_isim.Ad;
                MusteriGuncelleme.isim = musteri_isim.Ad;
                SiparisEkrani.isim2 = musteri_isim.Ad;
                SiparisEkrani form5 = new SiparisEkrani();
                form5.ShowDialog();
                if(Beni_Hatirla_Check.Checked == false)
                {
                    Kullanici_Adi.Text = "";
                    Sifre.Text = "";
                }
            }
            else
            {
                if (Beni_Hatirla_Check.Checked == false)
                {
                    Kullanici_Adi.Text = "";
                    Sifre.Text = "";
                }
                MessageBox.Show("Kullanıcı Adıyla Şifre Uyumlu Değil!!");
            }
        }


    }
}
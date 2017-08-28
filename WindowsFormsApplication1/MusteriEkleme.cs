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

namespace WindowsFormsApplication1
{
    public partial class MusteriEkleme : Form
    {
        public MusteriEkleme()
        {
            InitializeComponent();
            Kullanici_Sifre.PasswordChar = '*';
        }
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        Musteri yeni_musteri = new Musteri();
        private void kaydet_Click(object sender, EventArgs e)
        {
            var goster = from a in database.Musteri
                    where a.KullanıcıAdı == Kullanici_User.Text
                    select a;
            if (goster.Any())
            {
                Kullanici_User.Text = "";
                MessageBox.Show("Farklı Bir Kullanıcı Adı Giriniz!");
            }
            else
            {
                yeni_musteri.Ad = Kullanici_Adi.Text;
                yeni_musteri.Soyad = Kullanici_Soyadi.Text;
                yeni_musteri.Yas = Int32.Parse(Kullanici_Yasi.Text);
                yeni_musteri.Mail = Kullanici_Maili.Text;
                yeni_musteri.KullanıcıAdı = Kullanici_User.Text;
                yeni_musteri.Password = Kullanici_Sifre.Text;
                database.Musteri.Add(yeni_musteri);
                database.SaveChanges();
                MessageBox.Show("Başarıyla Sisteme Eklendi!");
                this.Close();
            }
        }
    }
}

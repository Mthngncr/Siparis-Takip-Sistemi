using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WindowsFormsApplication1
{


    public partial class MusteriEkleme : Form
    {


        public MusteriEkleme()
        {
            InitializeComponent();
            Kullanici_Sifre.PasswordChar = '*';
            Sifre_Tekrar.PasswordChar = '*';
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
                if((Kullanici_Sifre.TextLength>=8 && Kullanici_Sifre.TextLength<=12)&&(Sifre_Tekrar.TextLength >= 8 && Sifre_Tekrar.TextLength <= 12))
                {
                    if (Kullanici_Sifre.Text == Sifre_Tekrar.Text)
                    {
                        string a =GirisSayfasi.ConvertStringtoMD5(Kullanici_Sifre.Text);

                        

                        yeni_musteri.Ad = Kullanici_Adi.Text;
                        yeni_musteri.Soyad = Kullanici_Soyadi.Text;
                        yeni_musteri.Yas = Int32.Parse(Kullanici_Yasi.Text);
                        yeni_musteri.Mail = Kullanici_Maili.Text;
                        yeni_musteri.KullanıcıAdı = Kullanici_User.Text;
                        yeni_musteri.Password = a;
                        database.Musteri.Add(yeni_musteri);
                        database.SaveChanges();
                        MessageBox.Show("Başarıyla Sisteme Eklendi!");


                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Eşleşmiyor!");
                        Kullanici_Sifre.Text = "";
                        Sifre_Tekrar.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Şifreyi 8-12 karakter arasında giriniz!!");
                    Kullanici_Sifre.Text = "";
                    Sifre_Tekrar.Text = "";
                }

            }
        }
    }
}

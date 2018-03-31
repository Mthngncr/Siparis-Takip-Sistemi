using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    public partial class MusteriGuncelleme : Form
    {
        public MusteriGuncelleme()
        {
            InitializeComponent();
            Kullanici_Eski_Sifre.PasswordChar = '*';
            Kullanici_Sifre.PasswordChar = '*';
            Kullanici_Sifre_Tekrar.PasswordChar = '*';
            label8.Text = "Hoşgeldiniz, " + " " + isim;

        }
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        Musteri guncel_musteri = new Musteri();
        public static string isim;
        private void kaydet_Click(object sender, EventArgs e)
        {
            guncel_musteri = database.Musteri.Include(z => z.Siparis).Where(t => t.Ad == isim).FirstOrDefault();
            if (guncel_musteri != null)
            {
                if(Ad_Check.Checked==true)
                {
                    guncel_musteri.Ad = guncel_musteri.Ad;
                }
                else
                {
                    guncel_musteri.Ad = Kullanici_Adi.Text;
                }
                if (Soyad_Check.Checked == true)
                {
                    guncel_musteri.Soyad = guncel_musteri.Soyad;

                }
                else
                {
                    guncel_musteri.Soyad = Kullanici_Soyadi.Text;
                }
                if (Yas_Check.Checked == true)
                {
                    guncel_musteri.Yas = guncel_musteri.Yas;

                }
                else
                {
                    guncel_musteri.Yas = Int32.Parse(Kullanici_Yasi.Text);
                }
                if (Mail__Check.Checked == true)
                {

                    guncel_musteri.Mail = guncel_musteri.Mail;
                }
                else
                {
                    guncel_musteri.Mail = Kullanici_Maili.Text;
                }
                if (Sifre__Check.Checked == true)
                {

                    guncel_musteri.Password = guncel_musteri.Password;
                }
                else
                {
                    if ((Kullanici_Sifre.TextLength >= 8 && Kullanici_Sifre.TextLength <= 12) && (Kullanici_Eski_Sifre.TextLength >= 8 && Kullanici_Eski_Sifre.TextLength <= 12) && (Kullanici_Sifre_Tekrar.TextLength >= 8 && Kullanici_Sifre_Tekrar.TextLength <= 12))
                    {
                        if (guncel_musteri.Password == GirisSayfasi.ConvertStringtoMD5(Kullanici_Eski_Sifre.Text))
                        {
                            if (Kullanici_Sifre.Text == Kullanici_Sifre_Tekrar.Text)
                            {
                                guncel_musteri.Password = GirisSayfasi.ConvertStringtoMD5( Kullanici_Sifre_Tekrar.Text);
                            }
                            else
                            {
                                MessageBox.Show("Şifreler Eşleşmiyor!!");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz Şifre Hatalı!");
                            Kullanici_Eski_Sifre.Text = "";
                            this.Close();


                        }
                    }
                    else
                    {
                        MessageBox.Show("Girdiğiniz şifre 8-12 karakter arasında değildir!");
                    }
                   
                }
                if (Bakiye_Check.Checked == true)
                {
                    guncel_musteri.Bakiye = guncel_musteri.Bakiye;

                }
                else
                {
                    guncel_musteri.Bakiye = Int32.Parse(Kullanici_Bakiye.Text);
                }
                guncel_musteri.KullanıcıAdı = guncel_musteri.KullanıcıAdı;
                database.SaveChanges();
                MessageBox.Show("Müşteri Başarıyla Güncellendi!");

            }
            else
            {
                Kullanici_Adi.Text = "";
                MessageBox.Show("Müşteri Güncellemede Hata Oluştu!");
            }
        }

        private void Ad_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Ad_Check.Checked == false)
            {
                Kullanici_Adi.Visible = true;
                label1.Visible = true;
            }else
            {
                Kullanici_Adi.Visible = false;
                label1.Visible = false;
            }
        }

        private void Soyad_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Soyad_Check.Checked== false)
            {
                Kullanici_Soyadi.Visible = true;
                label2.Visible = true;
            }
            else
            {
                Kullanici_Soyadi.Visible = false;
                label2.Visible = false;
            }
        }

        private void Yas_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Yas_Check.Checked == false)
            {
                Kullanici_Yasi.Visible = true;
                label3.Visible = true;
            }
            else
            {
                Kullanici_Yasi.Visible = false;
                label3.Visible = false;
            }

        }

        private void Mail__Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Mail__Check.Checked == false)
            {
                Kullanici_Maili.Visible = true;
                label4.Visible = true;
            }
            else
            {
                Kullanici_Maili.Visible = false;
                label4.Visible = false;
            }

        }

        private void Sifre__Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Sifre__Check.Checked == false)
            {
                Kullanici_Eski_Sifre.Visible = true;
                label6.Visible = true;
                Kullanici_Sifre.Visible = true;
                label5.Visible = true;
                Kullanici_Sifre_Tekrar.Visible = true;
                label10.Visible = true;
            }
            else
            {
                Kullanici_Eski_Sifre.Visible = false;
                label6.Visible = false;
                Kullanici_Sifre.Visible = false;
                label5.Visible = false;
                Kullanici_Sifre_Tekrar.Visible = false;
                label10.Visible = false;
            }
        }

        private void Bakiye_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Bakiye_Check.Checked == false)
            {
                Kullanici_Bakiye.Visible = true;
                label7.Visible = true;
            }
            else
            {
                Kullanici_Bakiye.Visible = false;
                label7.Visible = false;
            }
        }


    }
}
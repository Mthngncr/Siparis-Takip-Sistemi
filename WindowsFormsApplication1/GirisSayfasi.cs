using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using System.Security.Cryptography;

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
        public static string ConvertStringtoMD5(string strword)
        {

            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strword);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }
        private void giris_Click(object sender, EventArgs e)
        {
            string md5a = ConvertStringtoMD5(Sifre.Text);
            var q = from a in database.Musteri where (a.KullanıcıAdı == Kullanici_Adi.Text && a.Password ==md5a) select a;
            if(Sifre.TextLength>=8 && Sifre.TextLength<=12)
            {
                if (q.Any())
                {
                    musteri_isim = database.Musteri.Include(z => z.Siparis).Where(d => d.KullanıcıAdı == Kullanici_Adi.Text).FirstOrDefault();
                    AdminSayfasi.isim3 = musteri_isim.Ad;
                    MusteriGuncelleme.isim = musteri_isim.Ad;
                    SiparisEkrani.isim2 = musteri_isim.Ad;
                    SiparisEkrani form5 = new SiparisEkrani();
                    form5.ShowDialog();
                    if (Beni_Hatirla_Check.Checked == false)
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
            else
            {
                MessageBox.Show("Girdiğiniz şifre 8-12 karakter arasında değildir!");
            }

        }


    }
}
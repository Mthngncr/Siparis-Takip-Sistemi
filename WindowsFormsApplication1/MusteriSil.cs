using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    public partial class MusteriSil : Form
    {
        public MusteriSil()
        {
            InitializeComponent();

            kullanici_adi.GotFocus += new EventHandler(textBox_GotFocus);
        }
        private void textBox_GotFocus(object sender, EventArgs e)
        {
            kullanici_adi.Text = "";
        }

        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        Musteri sil_musteri = new Musteri();

        private void Sil_Click(object sender, EventArgs e)
        {
            sil_musteri = database.Musteri.Include(z => z.Siparis).Where(x => x.KullanıcıAdı == kullanici_adi.Text).FirstOrDefault();
            if(sil_musteri!=null)
            {
                DialogResult cikti = MessageBox.Show(sil_musteri.Ad+" "+"adlı kişiyi silmek istediğinize emin misiniz?", "Müşteri Silme Onayı", MessageBoxButtons.YesNoCancel);
                if (cikti == DialogResult.Yes)
                {
                    database.Musteri.Remove(sil_musteri);
                    database.SaveChanges();
                }               

            }
            else
            {
                MessageBox.Show("Aradığınız Kullanıcı Adında Bir Kayıt Bulunmamaktadır!!");
                kullanici_adi.Text = "";
            }

        }
    }
}

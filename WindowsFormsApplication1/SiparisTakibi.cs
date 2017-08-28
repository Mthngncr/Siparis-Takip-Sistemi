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
    public partial class SiparisTakibi : Form
    {
        public SiparisTakibi()
        {
            InitializeComponent();
        }
        Musteri goruntule_musteri = new Musteri();
        Siparis goruntule_siparis = new Siparis();
        Urun goruntule_urun = new Urun();
        EFDemo.DB.EFDemoDBContext database=new EFDemo.DB.EFDemoDBContext();
        private void goster_Click(object sender, EventArgs e)
        {
            goruntule_musteri = database.Musteri.Include(z => z.Siparis).Where(t => t.KullanıcıAdı == Kullanici_Adi.Text).FirstOrDefault();
            goruntule_siparis = database.Siparis.Where(t => t.MusteriId == goruntule_musteri.Id ).FirstOrDefault();
            if (goruntule_siparis != null)
            {
                if (goruntule_musteri.Id==goruntule_siparis.MusteriId)
                {
                    var goster = from k in database.Urun join t in database.Siparis on k.Id equals t.UrunId
                            select k.UrunAd;

                    Siparisler_Combo.DataSource = goster.ToList();
                }
                else
                {
                    Kullanici_Adi.Text = "";
                    MessageBox.Show("Girdiğiniz Kullanıcı Adı Kullanılmamaktadır!");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcının Siparişi Yok!");
            }
        }
    }
}

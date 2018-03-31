using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
namespace WindowsFormsApplication1
{
    public partial class MusteriDetayi : Form
    {
        public MusteriDetayi()
        {
            InitializeComponent();

            Musteri_Detay_Grid.Columns.AddRange(yenisiparis);
        }
      
        Musteri goruntule_musteri = new Musteri();
        Siparis goruntule_siparis = new Siparis();
        Urun goruntule_urun = new Urun();
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();

        DataGridViewComboBoxColumn yenisiparis = new DataGridViewComboBoxColumn();
        private void goster_Click(object sender, EventArgs e)
        {

            var goster = (from q in database.Musteri where q.Ad == Musteri_Adi.Text select new { q.Ad, q.Soyad, q.Mail, q.Bakiye,}).ToList();
            yenisiparis.HeaderText = "Siparis";
            if (goster.Any())
            {
                Musteri_Detay_Grid.DataSource = goster;
            }
            else
            {
                Musteri_Adi.Text = "";
                MessageBox.Show("Aradığınız Kullanıcı Sistemde Kayıtlı Değil!!");
            }
            goruntule_musteri = database.Musteri.Include(z => z.Siparis).Where(t => t.Ad == Musteri_Adi.Text).FirstOrDefault();
            if(goruntule_musteri !=null)
            {
                goruntule_siparis = database.Siparis.Where(t => t.MusteriId == goruntule_musteri.Id).FirstOrDefault();

                if (goruntule_siparis != null)
                {
                    var goster1 = from k in database.Urun
                                  join t in database.Siparis on k.Id equals t.UrunId
                                  select k.UrunAd;
                    yenisiparis.DataSource = goster1.ToList();
                }
                else
                {
                    yenisiparis.DataSource = null;
                    MessageBox.Show("Kullanıcının Siparişi Yok!");
                }

            }
            
        }
    }
}

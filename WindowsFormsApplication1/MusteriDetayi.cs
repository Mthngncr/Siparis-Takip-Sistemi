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
    public partial class MusteriDetayi : Form
    {
        public MusteriDetayi()
        {
            InitializeComponent();
        }
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        private void goster_Click(object sender, EventArgs e)
        {
            var gosteri = (from q in database.Musteri where q.Ad== Musteri_Adi.Text  select new { q.Ad, q.Soyad,q.KullanıcıAdı }).ToList();
            Musteri_Detay_Grid.DataSource = gosteri;
            /*var goster = from k in database.Musteri
                    where k.Ad == Musteri_Adi.Text
                    select k;
            if(goster.Any())
            {
                Musteri_Detay_Grid.DataSource = goster.ToList();
            }
            else
            {
                MessageBox.Show("Aradığınız Kullanıcı Sistemde Kayıtlı Değil!!");
            }*/
        }
    }
}

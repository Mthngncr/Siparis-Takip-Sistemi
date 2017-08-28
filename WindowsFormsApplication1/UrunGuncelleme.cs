using EFDemo.DB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UrunGuncelleme : Form
    {
        public UrunGuncelleme()
        {
            InitializeComponent();
        }
        Urun guncel_urun = new Urun();
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        private void guncelle_Click(object sender, EventArgs e)
        {
            guncel_urun = database.Urun.Include(z => z.Siparis).Where(t => t.UrunAd == Urun_Adi.Text).FirstOrDefault();
            if (guncel_urun!=null)
            {
                guncel_urun.Fiyat = float.Parse(Urun_Fiyat.Text);
                guncel_urun.Stok = Int32.Parse(Urun_Stok.Text);
                database.SaveChanges();
                MessageBox.Show("Ürün Başarıyla Güncellendi!");
                this.Close();
            }
            else
            {
                Urun_Adi.Text = "";
                Urun_Fiyat.Text = "";
                Urun_Stok.Text = "";
                MessageBox.Show("Aranan Ürün Bulunamadı!");
            }
        }
    }
}

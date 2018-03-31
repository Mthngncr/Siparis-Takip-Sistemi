using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

namespace WindowsFormsApplication1
{
    public partial class UrunSil : Form
    {
        public UrunSil()
        {
            InitializeComponent();


            urun_adi.GotFocus += new EventHandler(textBox_GotFocus);
        }
        private void textBox_GotFocus(object sender, EventArgs e)
        {
            urun_adi.Text = "";
        }

        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        Urun sil_urun = new Urun();

        private void urun_sil_Click(object sender, EventArgs e)
        {
            sil_urun = database.Urun.Include(z => z.Siparis).Where(x => x.UrunAd == urun_adi.Text).FirstOrDefault();
            if (sil_urun != null)
            {
                DialogResult cikti = MessageBox.Show(sil_urun.UrunAd + " " + "adlı ürünü silmek istediğinize emin misiniz?", "Ürün Silme Onayı", MessageBoxButtons.YesNoCancel);
                if (cikti == DialogResult.Yes)
                {
                    database.Urun.Remove(sil_urun);
                    database.SaveChanges();
                }

            }
            else
            {
                MessageBox.Show("Aradığınız Ürün Adında Bir Kayıt Bulunmamaktadır!!");
                urun_adi.Text = "";
            }

        }
    }
}

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
    public partial class UrunBilgileri : Form
    {
        public UrunBilgileri()
        {
            InitializeComponent();
        }
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        Urun yeni_urun = new Urun();
        private void kaydet_Click(object sender, EventArgs e)
        {
            yeni_urun.UrunAd = Urun_Adi.Text;
            yeni_urun.Fiyat =float.Parse(Urun_Fiyat.Text);
            yeni_urun.Stok = Int32.Parse(Urun_Stok.Text);
            database.Urun.Add(yeni_urun);
            database.SaveChanges();
            MessageBox.Show("Başarıyla Sisteme Eklendi!");
            this.Close();
        }
    }
}

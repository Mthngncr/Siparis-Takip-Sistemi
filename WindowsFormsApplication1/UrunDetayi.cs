using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UrunDetayi : Form
    {
        public UrunDetayi()
        {
            InitializeComponent();
            Urun_Adi.GotFocus += new EventHandler(textBox_GotFocus);
        }
        private void textBox_GotFocus(object sender, EventArgs e)
        {
            Urun_Adi.Text = "";
        }
        EFDemo.DB.EFDemoDBContext database = new EFDemo.DB.EFDemoDBContext();
        private void goster_Click(object sender, EventArgs e)
        {
            var goster = (from q in database.Urun where q.UrunAd == Urun_Adi.Text select new { q.UrunAd, q.Stok, q.Fiyat}).ToList();

            if (goster.Any())
            {
                Urun_Detayi_Grid.DataSource = goster.ToList();
            }
            else
            {
                MessageBox.Show("Aradığınız Ürün Sistemde Kayıtlı Değil!!");
            }
        }
    }
}

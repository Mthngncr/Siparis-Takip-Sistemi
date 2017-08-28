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
            var goster = from a in database.Urun
                    where a.UrunAd == Urun_Adi.Text
                    select a;
            if(goster.Any())
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

﻿using EFDemo.DB.Entities;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
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
            guncel_urun = database.Urun.Include(z => z.Siparis).Where(t => t.UrunAd == combo_urun.SelectedItem.ToString()).FirstOrDefault();
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
                Urun_Fiyat.Text = "";
                Urun_Stok.Text = "";
                MessageBox.Show("Aranan Ürün Bulunamadı!");
            }
        }

        private void UrunGuncelleme_Load(object sender, EventArgs e)
        {
            var goster = from a in database.Urun
                         select a.UrunAd;
            combo_urun.DataSource = goster.ToList();
        }

        private void goster_Click(object sender, EventArgs e)
        {
            guncel_urun = database.Urun.Include(z => z.Siparis).Where(t => t.UrunAd == combo_urun.SelectedItem.ToString()).FirstOrDefault();
            Urun_Fiyat.Text = guncel_urun.Fiyat.ToString("0.##");
            Urun_Stok.Text = guncel_urun.Stok.ToString();
        }
    }
}

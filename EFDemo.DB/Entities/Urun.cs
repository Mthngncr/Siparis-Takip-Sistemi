using System.Collections.Generic;

namespace EFDemo.DB.Entities
{
    public class Urun
    {
        public Urun()
        {
            Siparis = new List<Siparis>();
        }
        public long Id { get; set; }
        public string UrunAd { get; set; }
        public double Fiyat { get; set; }
        public int Stok { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

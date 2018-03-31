using System.Collections.Generic;

namespace EFDemo.DB.Entities
{
    public class Musteri
    {
        public Musteri()
        {
            Siparis = new List<Siparis>();
        }
        public long Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string Mail { get; set; }
        public int Admin { get; set; }
        public string KullanıcıAdı { get; set; }
        public string Password { get; set; }
        public double Bakiye { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}

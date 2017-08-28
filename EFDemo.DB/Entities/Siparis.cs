using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.DB.Entities
{
    public class Siparis
    {
        public long Id { get; set; }
        public long MusteriId { get; set; }
        public long UrunId { get; set; }

        public virtual Musteri Musteri { get; set; }
        public virtual Urun Urun { get; set; }

    }
}

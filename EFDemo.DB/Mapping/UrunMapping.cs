using EFDemo.DB.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFDemo.DB.Mapping
{
    public class UrunMapping : EntityTypeConfiguration<Urun>
    {
        public UrunMapping()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Id).HasColumnName("ID");

            this.ToTable("URUN");

            this.Property(t => t.UrunAd).HasColumnName("URUNAD").HasMaxLength(50).IsRequired();
            this.Property(t => t.Stok).HasColumnName("STOK").IsRequired();
            this.Property(t => t.Fiyat).HasColumnName("FIYAT").IsRequired();


        }
    }
}

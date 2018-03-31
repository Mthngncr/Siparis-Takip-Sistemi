using EFDemo.DB.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFDemo.DB.Mapping
{
    public class SiparisMapping : EntityTypeConfiguration<Siparis>
    {
        public SiparisMapping()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Id).HasColumnName("ID");

            this.ToTable("SIPARIS");

            this.Property(t => t.MusteriId).HasColumnName("MUSTERI_ID").IsRequired();
            this.Property(t => t.UrunId).HasColumnName("URUN_ID").IsRequired();

            this.HasRequired(t => t.Musteri)
                .WithMany(t => t.Siparis)
                .HasForeignKey(d => d.MusteriId);
            this.HasRequired(t => t.Urun)
                .WithMany(t => t.Siparis)
                .HasForeignKey(d => d.UrunId);
        }
    }
}

using EFDemo.DB.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFDemo.DB.Mapping
{
    public class MusteriMapping : EntityTypeConfiguration<Musteri>
    {
        public MusteriMapping()
        {
            this.HasKey(t => t.Id);
            this.Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Id).HasColumnName("ID");

            this.ToTable("MUSTERI");

            this.Property(t => t.KullanıcıAdı).HasColumnName("AD").HasMaxLength(50).IsRequired();
            this.Property(t => t.Soyad).HasColumnName("SOYAD").HasMaxLength(50).IsRequired();
            this.Property(t => t.Yas).HasColumnName("YAS").IsRequired();
            this.Property(t => t.Mail).HasColumnName("MAIL").HasMaxLength(50).IsRequired();
            this.Property(t => t.KullanıcıAdı).HasColumnName("KULLANICIADI").HasMaxLength(50).IsRequired();
            this.Property(t => t.Password).HasColumnName("PASSWORD").HasMaxLength(50).IsRequired();
            this.Property(t => t.Admin).HasColumnName("ADMIN").IsOptional();
            this.Property(t => t.Bakiye).HasColumnName("BAKIYE").IsOptional();

        }
    }
}

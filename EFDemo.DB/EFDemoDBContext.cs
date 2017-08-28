using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EFDemo.DB.Entities;
using EFDemo.DB.Mapping;
using System.Configuration;
using System.Diagnostics;

namespace EFDemo.DB
{
    class GeneratedSqlLogger
    {
        public void Log(string message)
        {
            //System.Diagnostics.Debug.Write(message);
            Trace.Write(message);
        }
    }

    public class EFDemoDBContext : DbContext
    {
        static string connectionString = string.Empty;
       
    

        static EFDemoDBContext()
        {
            Database.SetInitializer<EFDemoDBContext>(null);

            connectionString = ConfigurationManager.ConnectionStrings["cnnsString"].ConnectionString;

            

        }
        public EFDemoDBContext()
            : base(connectionString)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 30;
            var sqlLogger = new GeneratedSqlLogger();
            this.Database.Log = s => sqlLogger.Log(s);
        }

        public override DbSet<TEntity> Set<TEntity>()
        {
            return base.Set<TEntity>();
        }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<Urun> Urun { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MusteriMapping());
            modelBuilder.Configurations.Add(new SiparisMapping());
            modelBuilder.Configurations.Add(new UrunMapping());
        }
    }
}

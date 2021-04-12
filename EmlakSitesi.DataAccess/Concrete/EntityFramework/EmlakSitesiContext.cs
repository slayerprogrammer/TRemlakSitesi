using EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.EmlakHaberleri;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.GunlukKiralik;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.Kiralik;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.Projeler;
using EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.Satilik;
using EmlakSitesi.Entities;
using EmlakSitesi.Entities.EmlakHaberleri;
using EmlakSitesi.Entities.GunlukKiralik;
using EmlakSitesi.Entities.Kiralik;
using EmlakSitesi.Entities.Projeler;
using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework
{
    public class EmlakSitesiContext : DbContext
    {
        public EmlakSitesiContext()
        {
            Database.SetInitializer<EmlakSitesiContext>(null);
        }
        public DbSet<Uye> Uye { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<IlanBilgileri> IlanBilgileri { get; set; }

        public DbSet<SatilikDaire> SatilikDaire { get; set; }
        public DbSet<SatilikRezidans> SatilikRezidans { get; set; }
        public DbSet<SatilikVilla> SatilikVilla { get; set; }
        public DbSet<SatilikYazlik> SatilikYazlik { get; set; }

        public DbSet<KiralikDaire> KiralikDaire { get; set; }
        public DbSet<KiralikRezidans> KiralikRezidans { get; set; }
        public DbSet<KiralikVilla> KiralikVilla { get; set; }
        public DbSet<KiralikYazlik> KiralikYazlik { get; set; }

        public DbSet<GunlukKiralikDaire> GunlukKiralikDaire { get; set; }
        public DbSet<GunlukKiralikRezidans> GunlukKiralikRezidans { get; set; }
        public DbSet<GunlukKiralikVilla> GunlukKiralikVilla { get; set; }

        public DbSet<ProjeKonut> ProjeKonut { get; set; }
        public DbSet<ProjeEmlakKonut> ProjeEmlakKonut { get; set; }
        public DbSet<ProjeToki> ProjeToki { get; set; }

        public DbSet<EmlakHaber> EmlakHaber { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UyeMap());
            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new IlanBilgileriMap());

            modelBuilder.Configurations.Add(new SatilikDaireMap());
            modelBuilder.Configurations.Add(new SatilikRezidansMap());
            modelBuilder.Configurations.Add(new SatilikVillaMap());
            modelBuilder.Configurations.Add(new SatilikYazlikMap());

            modelBuilder.Configurations.Add(new KiralikDaireMap());
            modelBuilder.Configurations.Add(new KiralikRezidansMap());
            modelBuilder.Configurations.Add(new KiralikVillaMap());
            modelBuilder.Configurations.Add(new KiralikYazlikMap());

            modelBuilder.Configurations.Add(new GunlukKiralikDaireMap());
            modelBuilder.Configurations.Add(new GunlukKiralikRezidansMap());
            modelBuilder.Configurations.Add(new GunlukKiralikVillaMap());

            modelBuilder.Configurations.Add(new ProjeKonutMap());
            modelBuilder.Configurations.Add(new ProjeEmlakKonutMap());
            modelBuilder.Configurations.Add(new ProjeTokiMap());

            modelBuilder.Configurations.Add(new EmlakHaberMap());
        }
    }
}

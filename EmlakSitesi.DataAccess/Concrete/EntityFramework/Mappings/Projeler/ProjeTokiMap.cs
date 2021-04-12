using EmlakSitesi.Entities.Projeler;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.Projeler
{
    public class ProjeTokiMap : EntityTypeConfiguration<ProjeToki>
    {
        public ProjeTokiMap()
        {
            ToTable(@"ProjelerToki", @"dbo");
            HasKey(x => x.projelertoki_ID);

            Property(x => x.Baslik).HasColumnName("Baslik");
            Property(x => x.Aciklama).HasColumnName("Aciklama");
            Property(x => x.ProjeBaslangicTarihi).HasColumnName("ProjeBaslangicTarihi");
            Property(x => x.TeslimTarihi).HasColumnName("TeslimTarihi");
            Property(x => x.Resim).HasColumnName("Resim");
            Property(x => x.DaireSayisi).HasColumnName("DaireSayisi");
            Property(x => x.ProjeTamamlanmaOrani).HasColumnName("ProjeTamamlanmaOrani");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
        }
    }
}

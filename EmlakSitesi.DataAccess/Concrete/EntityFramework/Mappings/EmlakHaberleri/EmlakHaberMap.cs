using EmlakSitesi.Entities.EmlakHaberleri;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.EmlakHaberleri
{
    public class EmlakHaberMap : EntityTypeConfiguration<EmlakHaber>
    {
        public EmlakHaberMap()
        {
            ToTable(@"EmlakHaberleri", @"dbo");
            HasKey(x => x.emlakhaberleri_ID);

            Property(x => x.Aciklama).HasColumnName("Aciklama");
            Property(x => x.Baslik).HasColumnName("Baslik");
            Property(x => x.Resim).HasColumnName("Resim");
            Property(x => x.Tarih).HasColumnName("Tarih");
        }
    }
}

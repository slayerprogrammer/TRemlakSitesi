﻿using EmlakSitesi.Entities.Kiralik;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings.Kiralik
{
    public class KiralikDaireMap : EntityTypeConfiguration<KiralikDaire>
    {
        public KiralikDaireMap()
        {
            ToTable(@"KiralikDaireler", @"dbo");
            HasKey(x => x.kiralikdaireler_ID);

            Property(x => x.Aciklama).HasColumnName("Aciklama");
            Property(x => x.BanyoSayisi).HasColumnName("BanyoSayisi");
            Property(x => x.Baslik).HasColumnName("Baslik");
            Property(x => x.Fiyat).HasColumnName("Fiyat");
            Property(x => x.Metrekare).HasColumnName("Metrekare");
            Property(x => x.Resim).HasColumnName("Resim");
            Property(x => x.YatakSayisi).HasColumnName("YatakSayisi");
        }
    }
}

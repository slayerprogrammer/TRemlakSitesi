using EmlakSitesi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings
{
    public class UyeMap : EntityTypeConfiguration<Uye>
    {
        public UyeMap()
        {
            ToTable(@"Uyeler", @"dbo");
            HasKey(x => x.uyeID);

            Property(x => x.AdSoyad).HasColumnName("AdSoyad");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Sifre).HasColumnName("Sifre");
            Property(x => x.SifreTekrar).HasColumnName("SifreTekrar");
        }
    }
}

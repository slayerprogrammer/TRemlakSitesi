using EmlakSitesi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AdminMap : EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            ToTable(@"Adminler", @"dbo");
            HasKey(x => x.adminID);

            Property(x => x.AdSoyad).HasColumnName("AdSoyad");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.Sifre).HasColumnName("Sifre");
        }
    }
}

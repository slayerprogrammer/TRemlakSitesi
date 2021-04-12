using DevFramework.Core.DataAccess.EntityFramework;
using EmlakSitesi.DataAccess.Abstract.Satilik;
using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Satilik
{
    public class EfSatilikVillaDal : EfEntityRepositoryBase<SatilikVilla, EmlakSitesiContext>, ISatilikVillaDal
    {
        public void TumunuGetir()
        {
            List<SatilikVilla> satilikVillas = new List<SatilikVilla>();
        }
    }
}

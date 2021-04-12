using DevFramework.Core.DataAccess.EntityFramework;
using EmlakSitesi.DataAccess.Abstract.EmlakHaberleri;
using EmlakSitesi.Entities.EmlakHaberleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.EmlakHaberleri
{
    public class EfEmlakHaberDal : EfEntityRepositoryBase<EmlakHaber, EmlakSitesiContext>, IEmlakHaberDal
    {

    }
}

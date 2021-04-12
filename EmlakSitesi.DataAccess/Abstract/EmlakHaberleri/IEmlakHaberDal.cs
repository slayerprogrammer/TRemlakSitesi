using DevFramework.Core.DataAccess;
using EmlakSitesi.Entities.EmlakHaberleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Abstract.EmlakHaberleri
{
    public interface IEmlakHaberDal : IEntityRepository<EmlakHaber>
    {

    }
}

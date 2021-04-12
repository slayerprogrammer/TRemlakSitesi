using DevFramework.Core.DataAccess.EntityFramework;
using EmlakSitesi.DataAccess.Abstract.Kiralik;
using EmlakSitesi.Entities.Kiralik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Kiralik
{
    public class EfKiralikDaireDal : EfEntityRepositoryBase<KiralikDaire, EmlakSitesiContext>, IKiralikDaireDal
    {

    }
}

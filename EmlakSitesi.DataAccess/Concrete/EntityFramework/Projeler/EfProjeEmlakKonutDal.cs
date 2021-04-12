using DevFramework.Core.DataAccess.EntityFramework;
using EmlakSitesi.DataAccess.Abstract.Projeler;
using EmlakSitesi.Entities.Projeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework.Projeler
{
    public class EfProjeEmlakKonutDal : EfEntityRepositoryBase<ProjeEmlakKonut, EmlakSitesiContext>, IProjeEmlakKonutDal
    {

    }
}

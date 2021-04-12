using DevFramework.Core.DataAccess.EntityFramework;
using EmlakSitesi.DataAccess.Abstract;
using EmlakSitesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.DataAccess.Concrete.EntityFramework
{
    public class EfUyeDal : EfEntityRepositoryBase<Uye, EmlakSitesiContext>, IUyeDal
    {

    }
}

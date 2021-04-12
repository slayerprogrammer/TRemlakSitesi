using EmlakSitesi.Entities.EmlakHaberleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.EmlakHaberleri
{
    public interface IEmlakHaberService
    {
        List<EmlakHaber> TumunuGetir();
    }
}

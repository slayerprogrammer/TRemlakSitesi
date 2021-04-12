using EmlakSitesi.Entities.Kiralik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.Kiralik
{
    public interface IKiralikYazlikService
    {
        List<KiralikYazlik> TumunuGetir();
    }
}

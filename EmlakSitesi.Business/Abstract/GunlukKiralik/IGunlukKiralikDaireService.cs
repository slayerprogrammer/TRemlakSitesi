using EmlakSitesi.Entities.GunlukKiralik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.GunlukKiralik
{
    public interface IGunlukKiralikDaireService
    {
        List<GunlukKiralikDaire> TumunuGetir();
    }
}

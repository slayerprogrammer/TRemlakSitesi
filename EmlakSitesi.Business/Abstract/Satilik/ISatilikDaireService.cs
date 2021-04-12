using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.Satilik
{
    public interface ISatilikDaireService
    {
        List<SatilikDaire> TumunuGetir();
        SatilikDaire IDyeGoreGetir(int id);
        SatilikDaire Ekle(SatilikDaire satilikDaire);
        SatilikDaire Guncelle(SatilikDaire satilikDaire);
    }
}

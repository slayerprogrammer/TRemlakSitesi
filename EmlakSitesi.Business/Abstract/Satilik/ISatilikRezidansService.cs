using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.Satilik
{
    public interface ISatilikRezidansService
    {
        List<SatilikRezidans> TumunuGetir();
        SatilikRezidans IDyeGoreGetir(int id);
        SatilikRezidans Ekle(SatilikRezidans satilikRezidans);
        SatilikRezidans Guncelle(SatilikRezidans satilikRezidans);
    }
}

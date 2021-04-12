using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.Satilik
{
    public interface ISatilikYazlikService
    {
        List<SatilikYazlik> TumunuGetir();
        SatilikYazlik IDyeGoreGetir(int id);
        SatilikYazlik Ekle(SatilikYazlik satilikYazlik);
        SatilikYazlik Guncelle(SatilikYazlik satilikYazlik);
    }
}

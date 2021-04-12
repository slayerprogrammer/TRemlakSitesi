using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.Satilik
{
    public interface ISatilikVillaService
    {
        List<SatilikVilla> TumunuGetir();
        SatilikVilla IDyeGoreGetir(int id);
        SatilikVilla Ekle(SatilikVilla satilikVilla);
        SatilikVilla Guncelle(SatilikVilla satilikVilla);
    }
}

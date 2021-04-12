using EmlakSitesi.Business.Abstract.Kiralik;
using EmlakSitesi.DataAccess.Abstract.Kiralik;
using EmlakSitesi.Entities.Kiralik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Concrete.Kiralik
{
    public class KiralikVillaManager : IKiralikVillaService
    {
        IKiralikVillaDal _kiralikVillaDal;
        public KiralikVillaManager(IKiralikVillaDal kiralikVillaDal)
        {
            _kiralikVillaDal = kiralikVillaDal;
        }
        public List<KiralikVilla> TumunuGetir()
        {
            return _kiralikVillaDal.GetList().Select(v => new KiralikVilla
            {
                Aciklama = v.Aciklama,
                BanyoSayisi = v.BanyoSayisi,
                Baslik = v.Baslik,
                Fiyat = v.Fiyat,
                kiralikvillalar_ID = v.kiralikvillalar_ID,
                Metrekare = v.Metrekare,
                Resim = v.Resim,
                YatakSayisi = v.YatakSayisi
            }).ToList();
        }
    }
}

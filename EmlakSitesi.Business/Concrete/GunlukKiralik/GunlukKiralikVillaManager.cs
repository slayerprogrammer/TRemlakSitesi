using EmlakSitesi.Business.Abstract.GunlukKiralik;
using EmlakSitesi.DataAccess.Abstract.GunlukKiralik;
using EmlakSitesi.Entities.GunlukKiralik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Concrete.GunlukKiralik
{
    public class GunlukKiralikVillaManager : IGunlukKiralikVillaService
    {
        IGunlukKiralikVillaDal _gunlukKiralikVillaDal;
        public GunlukKiralikVillaManager(IGunlukKiralikVillaDal gunlukKiralikVillaDal)
        {
            _gunlukKiralikVillaDal = gunlukKiralikVillaDal;
        }

        public List<GunlukKiralikVilla> TumunuGetir()
        {
            return _gunlukKiralikVillaDal.GetList().Select(a => new GunlukKiralikVilla
            {
                Aciklama = a.Aciklama,
                BanyoSayisi = a.BanyoSayisi,
                Baslik = a.Baslik,
                Fiyat = a.Fiyat,
                gunlukkiralikvillalar_ID = a.gunlukkiralikvillalar_ID,
                Metrekare = a.Metrekare,
                Resim = a.Resim,
                YatakSayisi = a.YatakSayisi
            }).ToList();
        }
    }
}

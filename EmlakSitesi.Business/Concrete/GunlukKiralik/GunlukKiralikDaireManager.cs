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
    public class GunlukKiralikDaireManager : IGunlukKiralikDaireService
    {
        IGunlukKiralikDaireDal _gunlukKiralikDaireDal;
        public GunlukKiralikDaireManager(IGunlukKiralikDaireDal gunlukKiralikDaireDal)
        {
            _gunlukKiralikDaireDal = gunlukKiralikDaireDal;
        }
        public List<GunlukKiralikDaire> TumunuGetir()
        {
            return _gunlukKiralikDaireDal.GetList().Select(v => new GunlukKiralikDaire
            {
                Aciklama = v.Aciklama,
                BanyoSayisi = v.BanyoSayisi,
                Baslik = v.Baslik,
                Fiyat = v.Fiyat,
                gunlukkiralikdaireler_ID = v.gunlukkiralikdaireler_ID,
                Metrekare = v.Metrekare,
                Resim = v.Resim,
                YatakSayisi = v.YatakSayisi
            }).ToList();
        }
    }
}

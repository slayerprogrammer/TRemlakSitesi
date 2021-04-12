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
    public class GunlukKiralikRezidansManager : IGunlukKiralikRezidansService
    {
        IGunlukKiralikRezidansDal _gunlukKiralikRezidansDal;
        public GunlukKiralikRezidansManager(IGunlukKiralikRezidansDal gunlukKiralikRezidansDal)
        {
            _gunlukKiralikRezidansDal = gunlukKiralikRezidansDal;
        }

        public List<GunlukKiralikRezidans> TumunuGetir()
        {
            return _gunlukKiralikRezidansDal.GetList().Select(k => new GunlukKiralikRezidans
            {
                Aciklama = k.Aciklama,
                BanyoSayisi = k.BanyoSayisi,
                Baslik = k.Baslik,
                Fiyat = k.Fiyat,
                gunlukkiralikrezidanslar_ID = k.gunlukkiralikrezidanslar_ID,
                Metrekare = k.Metrekare,
                Resim = k.Resim,
                YatakSayisi = k.YatakSayisi
            }).ToList();
        }
    }
}

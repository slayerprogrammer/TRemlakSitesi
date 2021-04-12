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
    public class KiralikRezidansManager : IKiralikRezidansService
    {
        IKiralikRezidansDal _kiralikRezidansDal;
        public KiralikRezidansManager(IKiralikRezidansDal kiralikRezidansDal)
        {
            _kiralikRezidansDal = kiralikRezidansDal;
        }
        public List<KiralikRezidans> TumunuGetir()
        {
            return _kiralikRezidansDal.GetList().Select(a => new KiralikRezidans
            {
                Aciklama = a.Aciklama,
                BanyoSayisi = a.BanyoSayisi,
                Baslik = a.Baslik,
                Fiyat = a.Fiyat,
                kiralikrezidanslar_ID = a.kiralikrezidanslar_ID,
                Metrekare = a.Metrekare,
                Resim = a.Resim,
                YatakSayisi = a.YatakSayisi
            }).ToList();
        }
    }
}

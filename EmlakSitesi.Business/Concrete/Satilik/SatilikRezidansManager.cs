using EmlakSitesi.Business.Abstract.Satilik;
using EmlakSitesi.DataAccess.Abstract.Satilik;
using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Concrete.Satilik
{
    public class SatilikRezidansManager : ISatilikRezidansService
    {
        ISatilikRezidansDal _satilikRezidansDal;
        public SatilikRezidansManager(ISatilikRezidansDal satilikRezidansDal)
        {
            _satilikRezidansDal = satilikRezidansDal;
        }
        public SatilikRezidans Ekle(SatilikRezidans satilikRezidans)
        {
            return _satilikRezidansDal.Add(satilikRezidans);
        }

        public SatilikRezidans Guncelle(SatilikRezidans satilikRezidans)
        {
            return _satilikRezidansDal.Update(satilikRezidans);
        }

        public SatilikRezidans IDyeGoreGetir(int id)
        {
            return _satilikRezidansDal.Get(s => s.satilikrezidanslar_ID == id);
        }

        public List<SatilikRezidans> TumunuGetir()
        {
            return _satilikRezidansDal.GetList().Select(s => new SatilikRezidans
            {
                Aciklama = s.Aciklama,
                BanyoSayisi = s.BanyoSayisi,
                Baslik = s.Baslik,
                Fiyat = s.Fiyat,
                Metrekare = s.Metrekare,
                Resim = s.Resim,
                satilikrezidanslar_ID = s.satilikrezidanslar_ID,
                YatakSayisi = s.YatakSayisi
            }).ToList();
        }
    }
}

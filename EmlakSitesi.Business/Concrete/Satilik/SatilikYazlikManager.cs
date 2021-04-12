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
    public class SatilikYazlikManager : ISatilikYazlikService
    {
        ISatilikYazlikDal _satilikYazlikDal;
        public SatilikYazlikManager(ISatilikYazlikDal satilikYazlikDal)
        {
            _satilikYazlikDal = satilikYazlikDal;
        }
        public SatilikYazlik Ekle(SatilikYazlik satilikYazlik)
        {
            return _satilikYazlikDal.Add(satilikYazlik);
        }

        public SatilikYazlik Guncelle(SatilikYazlik satilikYazlik)
        {
            return _satilikYazlikDal.Update(satilikYazlik);
        }

        public SatilikYazlik IDyeGoreGetir(int id)
        {
            return _satilikYazlikDal.Get(s => s.satilikyazliklar_ID == id);
        }

        public List<SatilikYazlik> TumunuGetir()
        {
            return _satilikYazlikDal.GetList().Select(s => new SatilikYazlik
            {
                satilikyazliklar_ID = s.satilikyazliklar_ID,
                Aciklama = s.Aciklama,
                BanyoSayisi = s.BanyoSayisi,
                Baslik = s.Baslik,
                Fiyat = s.Fiyat,
                Metrekare = s.Metrekare,
                Resim = s.Resim,
                YatakSayisi = s.YatakSayisi
            }).ToList();
        }
    }
}

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
    public class KiralikYazlikManager : IKiralikYazlikService
    {
        IKiralikYazlikDal _kiralikYazlikDal;
        public KiralikYazlikManager(IKiralikYazlikDal kiralikYazlikDal)
        {
            _kiralikYazlikDal = kiralikYazlikDal;
        }
        public List<KiralikYazlik> TumunuGetir()
        {
            return _kiralikYazlikDal.GetList().Select(v => new KiralikYazlik
            {
                Aciklama = v.Aciklama,
                Baslik = v.Baslik,
                BanyoSayisi = v.BanyoSayisi,
                Fiyat = v.Fiyat,
                kiralikyazliklar_ID = v.kiralikyazliklar_ID,
                Metrekare = v.Metrekare,
                Resim = v.Resim,
                YatakSayisi = v.YatakSayisi
            }).ToList();
        }
    }
}

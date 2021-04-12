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
    public class KiralikDaireManager : IKiralikDaireService
    {
        IKiralikDaireDal _kiralikDaireDal;
        public KiralikDaireManager(IKiralikDaireDal kiralikDaireDal)
        {
            _kiralikDaireDal = kiralikDaireDal;
        }
        public List<KiralikDaire> TumunuGetir()
        {
            return _kiralikDaireDal.GetList().Select(a => new KiralikDaire
            {
                Aciklama = a.Aciklama,
                BanyoSayisi = a.BanyoSayisi,
                Baslik = a.Baslik,
                Fiyat = a.Fiyat,
                kiralikdaireler_ID = a.kiralikdaireler_ID,
                Metrekare = a.Metrekare,
                Resim = a.Resim,
                YatakSayisi = a.YatakSayisi
            }).ToList();
        }
    }
}

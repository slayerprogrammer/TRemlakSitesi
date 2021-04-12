using EmlakSitesi.Business.Abstract;
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
    public class SatilikDaireManager : ISatilikDaireService
    {
        ISatilikDaireDal _satilikDaireDal;
        public SatilikDaireManager(ISatilikDaireDal satilikDaireDal)
        {
            _satilikDaireDal = satilikDaireDal;
        }

        public SatilikDaire Ekle(SatilikDaire satilikDaire)
        {
            return _satilikDaireDal.Add(satilikDaire);
        }

        public SatilikDaire Guncelle(SatilikDaire satilikDaire)
        {
            return _satilikDaireDal.Update(satilikDaire);
        }

        public SatilikDaire IDyeGoreGetir(int id)
        {
            return _satilikDaireDal.Get(s => s.satilikdaireler_ID == id);
        }

        public List<SatilikDaire> TumunuGetir()
        {
            return _satilikDaireDal.GetList().Select(s => new SatilikDaire
            {
                Aciklama = s.Aciklama,
                BanyoSayisi = s.BanyoSayisi,
                Baslik = s.Baslik,
                Fiyat = s.Fiyat,
                Metrekare = s.Metrekare,
                Resim = s.Resim,
                satilikdaireler_ID = s.satilikdaireler_ID,
                YatakSayisi = s.YatakSayisi
            }).ToList();
        }
    }
}

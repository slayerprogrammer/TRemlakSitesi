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
    public class SatilikVillaManager : ISatilikVillaService
    {
        ISatilikVillaDal _satilikVillaDal;
        public SatilikVillaManager(ISatilikVillaDal satilikVillaDal)
        {
            _satilikVillaDal = satilikVillaDal;
        }

        public SatilikVilla Ekle(SatilikVilla satilikVilla)
        {
            return _satilikVillaDal.Add(satilikVilla);
        }

        public SatilikVilla Guncelle(SatilikVilla satilikVilla)
        {
            return _satilikVillaDal.Update(satilikVilla);
        }

        public SatilikVilla IDyeGoreGetir(int id)
        {
            return _satilikVillaDal.Get(s => s.satilikvillalar_ID == id);
        }

        public List<SatilikVilla> TumunuGetir()
        {
            return _satilikVillaDal.GetList().Select(s => new SatilikVilla
            {
                Aciklama = s.Aciklama,
                BanyoSayisi = s.BanyoSayisi,
                satilikvillalar_ID = s.satilikvillalar_ID,
                Resim = s.Resim,
                Baslik = s.Baslik,
                Fiyat = s.Fiyat,
                Metrekare = s.Metrekare,
                YatakSayisi = s.YatakSayisi
            }).ToList();
        }
    }
}

using EmlakSitesi.Business.Abstract.Projeler;
using EmlakSitesi.DataAccess.Abstract.Projeler;
using EmlakSitesi.Entities.Projeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Concrete.Projeler
{
    public class ProjeKonutManager : IProjeKonutService
    {
        IProjeKonutDal _projeKonutDal;
        public ProjeKonutManager(IProjeKonutDal projeKonutDal)
        {
            _projeKonutDal = projeKonutDal;
        }
        public List<ProjeKonut> TumunuGetir()
        {
            return _projeKonutDal.GetList().Select(a => new ProjeKonut
            {
                Aciklama = a.Aciklama,
                Baslik = a.Baslik,
                DaireSayisi = a.DaireSayisi,
                ProjeBaslangicTarihi = a.ProjeBaslangicTarihi,
                Fiyat = a.Fiyat,
                projelerkonut_ID = a.projelerkonut_ID,
                ProjeTamamlanmaOrani = a.ProjeTamamlanmaOrani,
                Resim = a.Resim,
                TeslimTarihi = a.TeslimTarihi
            }).ToList();
        }
    }
}

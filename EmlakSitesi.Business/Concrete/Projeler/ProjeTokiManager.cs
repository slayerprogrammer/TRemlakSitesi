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
    public class ProjeTokiManager : IProjeTokiService
    {
        IProjeTokiDal _projeTokiDal;
        public ProjeTokiManager(IProjeTokiDal projeTokiDal)
        {
            _projeTokiDal = projeTokiDal;
        }
        public List<ProjeToki> TumunuGetir()
        {
            return _projeTokiDal.GetList().Select(a => new ProjeToki
            {
                Aciklama = a.Aciklama,
                Baslik = a.Baslik,
                DaireSayisi = a.DaireSayisi,
                Fiyat = a.Fiyat,
                ProjeBaslangicTarihi = a.ProjeBaslangicTarihi,
                projelertoki_ID = a.projelertoki_ID,
                ProjeTamamlanmaOrani = a.ProjeTamamlanmaOrani,
                Resim = a.Resim,
                TeslimTarihi = a.TeslimTarihi
            }).ToList();
        }
    }
}

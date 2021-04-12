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
    public class ProjeEmlakKonutManager : IProjeEmlakKonutService
    {
        IProjeEmlakKonutDal _projeEmlakKonutDal;
        public ProjeEmlakKonutManager(IProjeEmlakKonutDal projeEmlakKonutDal)
        {
            _projeEmlakKonutDal = projeEmlakKonutDal;
        }
        public List<ProjeEmlakKonut> TumunuGetir()
        {
            return _projeEmlakKonutDal.GetList().Select(a => new ProjeEmlakKonut
            {
                Aciklama = a.Aciklama,
                Baslik = a.Baslik,
                DaireSayisi = a.DaireSayisi,
                Fiyat = a.Fiyat,
                projeleremlakkonut_ID = a.projeleremlakkonut_ID,
                ProjeBaslangicTarihi = a.ProjeBaslangicTarihi,
                Resim = a.Resim,
                ProjeTamamlanmaOrani = a.ProjeTamamlanmaOrani,
                TeslimTarihi = a.TeslimTarihi
            }).ToList();
        }
    }
}

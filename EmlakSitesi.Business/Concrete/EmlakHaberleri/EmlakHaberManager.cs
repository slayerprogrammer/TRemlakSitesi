using EmlakSitesi.Business.Abstract.EmlakHaberleri;
using EmlakSitesi.DataAccess.Abstract.EmlakHaberleri;
using EmlakSitesi.Entities.EmlakHaberleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Concrete.EmlakHaberleri
{
    public class EmlakHaberManager : IEmlakHaberService
    {
        IEmlakHaberDal _emlakHaberDal;
        public EmlakHaberManager(IEmlakHaberDal emlakHaberDal)
        {
            _emlakHaberDal = emlakHaberDal;
        }
        public List<EmlakHaber> TumunuGetir()
        {
            return _emlakHaberDal.GetList().Select(e => new EmlakHaber
            {
                Aciklama = e.Aciklama,
                Baslik = e.Baslik,
                emlakhaberleri_ID = e.emlakhaberleri_ID,
                Resim = e.Resim,
                Tarih = e.Tarih
            }).ToList();
        }
    }
}

using EmlakSitesi.Business.Abstract;
using EmlakSitesi.DataAccess.Abstract;
using EmlakSitesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Concrete
{
    public class IlanBilgileriManager : IIlanBilgileriService
    {
        IIlanBilgileriDal _ilanBilgileriDal;
        public IlanBilgileriManager(IIlanBilgileriDal ilanBilgisiDal)
        {
            _ilanBilgileriDal = ilanBilgisiDal;
        }

        public void TumunuGetir(IlanBilgileri ilanBilgileri)
        {

        }
    }
}

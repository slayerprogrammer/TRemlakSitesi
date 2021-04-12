using DevFramework.Core.Aspects.Postsharp.ValidationAspects;
using EmlakSitesi.Business.Abstract;
using EmlakSitesi.Business.ValidationRules.FluentValidation;
using EmlakSitesi.DataAccess.Abstract;
using EmlakSitesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Concrete
{
    public class UyeManager : IUyeService
    {
        IUyeDal _uyeDal;
        public UyeManager(IUyeDal uyeDal)
        {
            _uyeDal = uyeDal;
        }
        [FluentValidationAspect(typeof(UyeValidator))]
        public void Add(Uye uye)
        {
            EmailKontrolu(uye);
            _uyeDal.Add(uye);
        }
        private void EmailKontrolu(Uye uye)
        {
            if (_uyeDal.Get(m => m.Email == uye.Email) != null)
            {
                throw new Exception("Bu kullanıcı daha önce kayıt olmuştur");
            }
        }
    }
}

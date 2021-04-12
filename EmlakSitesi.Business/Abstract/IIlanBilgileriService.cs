using EmlakSitesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract
{
    public interface IIlanBilgileriService
    {
        void TumunuGetir(IlanBilgileri ilanBilgileri);
    }
}

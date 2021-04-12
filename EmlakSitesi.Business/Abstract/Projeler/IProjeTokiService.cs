using EmlakSitesi.Entities.Projeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Business.Abstract.Projeler
{
    public interface IProjeTokiService
    {
        List<ProjeToki> TumunuGetir();
    }
}

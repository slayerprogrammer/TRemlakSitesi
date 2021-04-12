using DevFramework.Core.Entities;
using EmlakSitesi.Entities.EmlakHaberleri;
using EmlakSitesi.Entities.Kiralik;
using EmlakSitesi.Entities.Projeler;
using EmlakSitesi.Entities.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmlakSitesi.Models.Anasayfa
{
    public class AnasayfaViewModel
    {
        public IEnumerable<ProjeKonut> projeKonut { get; set; }
        public IEnumerable<ProjeEmlakKonut> projeEmlakKonut { get; set; }
        public IEnumerable<ProjeToki> projeToki { get; set; }
        public IEnumerable<EmlakHaber> emlakHaber { get; set; }
        public IEnumerable<SatilikDaire> satilikDaire { get; set; }
        public IEnumerable<KiralikDaire> kiralikDaire { get; set; }
    }
}
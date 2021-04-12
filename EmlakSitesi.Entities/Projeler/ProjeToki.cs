using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Entities.Projeler
{
    public class ProjeToki : IEntity
    {
        public int projelertoki_ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string ProjeBaslangicTarihi { get; set; }
        public string TeslimTarihi { get; set; }
        public string Resim { get; set; }
        public string DaireSayisi { get; set; }
        public string ProjeTamamlanmaOrani { get; set; }
        public string Fiyat { get; set; }
    }
}

using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Entities.EmlakHaberleri
{
    public class EmlakHaber : IEntity
    {
        public int emlakhaberleri_ID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string Tarih { get; set; }
    }
}

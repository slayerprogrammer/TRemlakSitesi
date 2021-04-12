using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Entities
{
    public class IlanBilgileri : IEntity
    {
        public int ilanbilgileriID { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Fiyat { get; set; }
        public string YatakSayisi { get; set; }
        public string BanyoSayisi { get; set; }
        public string Metrekare { get; set; }
        public string Resim { get; set; }
    }
}

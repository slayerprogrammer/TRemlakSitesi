using DevFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakSitesi.Entities
{
    public class Admin : IEntity
    {
        public int adminID { get; set; }
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
    }
}

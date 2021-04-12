using EmlakSitesi.Business.Abstract.EmlakHaberleri;
using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using EmlakSitesi.Models.EmlakHaberleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakSitesi.Controllers
{
    public class EmlakHaberleriController : Controller
    {
        IEmlakHaberService _emlakHaberService;
        public EmlakHaberleriController(IEmlakHaberService emlakHaberService)
        {
            _emlakHaberService = emlakHaberService;
        }
        public ActionResult Index()
        {
            var getir = new EmlakHaberViewModel
            {
                emlakHaber = _emlakHaberService.TumunuGetir()
            };
            return View(getir);
        }
    }
}
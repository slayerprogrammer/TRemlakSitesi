using EmlakSitesi.Business.Abstract;
using EmlakSitesi.Business.Abstract.Satilik;
using EmlakSitesi.DataAccess.Abstract;
using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using EmlakSitesi.Entities.Satilik;
using EmlakSitesi.Models;
using EmlakSitesi.Models.Entity;
using EmlakSitesi.Models.Satilik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakSitesi.Controllers
{
    public class SatilikController : Controller
    {
        ISatilikDaireService _satilikDaireService;
        ISatilikRezidansService _satilikRezidansService;
        ISatilikVillaService _satilikVillaService;
        ISatilikYazlikService _satilikYazlikService;
        public SatilikController(ISatilikDaireService satilikDaireService, ISatilikRezidansService satilikRezidansService, ISatilikVillaService satilikVillaService, ISatilikYazlikService satilikYazlikService)
        {
            _satilikDaireService = satilikDaireService;
            _satilikRezidansService = satilikRezidansService;
            _satilikVillaService = satilikVillaService;
            _satilikYazlikService = satilikYazlikService;
        }
        public ActionResult Daire()
        {
            var getir = new SatilikDaireViewModel
            {
                satilikDaire = _satilikDaireService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Rezidans()
        {
            var getir = new SatilikRezidansViewModel
            {
                satilikRezidans = _satilikRezidansService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Villa()
        {
            var getir = new SatilikVillaViewModel
            {
                satilikVilla = _satilikVillaService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Yazlik()
        {
            var getir = new SatilikYazlikViewModel
            {
                satilikYazlik = _satilikYazlikService.TumunuGetir()
            };
            return View(getir);
        }
    }
}
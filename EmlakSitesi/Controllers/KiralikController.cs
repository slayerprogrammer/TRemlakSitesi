using EmlakSitesi.Business.Abstract.Kiralik;
using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using EmlakSitesi.Models.Kiralik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace EmlakSitesi.Controllers
{
    public class KiralikController : Controller
    {
        IKiralikDaireService _kiralikDaireService;
        IKiralikRezidansService _kiralikRezidansService;
        IKiralikVillaService _kiralikVillaService;
        IKiralikYazlikService _kiralikYazlikService;
        public KiralikController(IKiralikDaireService kiralikDaireService, IKiralikRezidansService kiralikRezidansService, IKiralikVillaService kiralikVillaService, IKiralikYazlikService kiralikYazlikService)
        {
            _kiralikDaireService = kiralikDaireService;
            _kiralikRezidansService = kiralikRezidansService;
            _kiralikVillaService = kiralikVillaService;
            _kiralikYazlikService = kiralikYazlikService;
        }
        public ActionResult Daire()
        {
            var getir = new KiralikDaireViewModel
            {
                kiralikDaire = _kiralikDaireService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Rezidans()
        {
            var getir = new KiralikRezidansViewModel
            {
                kiralikRezidans = _kiralikRezidansService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Villa()
        {
            var getir = new KiralikVillaViewModel
            {
                kiralikVilla = _kiralikVillaService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Yazlik()
        {
            var getir = new KiralikYazlikViewModel
            {
                kiralikYazlik = _kiralikYazlikService.TumunuGetir()
            };
            return View(getir);
        }
    }
}
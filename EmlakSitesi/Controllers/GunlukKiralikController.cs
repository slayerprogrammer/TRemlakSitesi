using EmlakSitesi.Business.Abstract.GunlukKiralik;
using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using EmlakSitesi.Models.GunlukKiralik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakSitesi.Controllers
{
    public class GunlukKiralikController : Controller
    {
        IGunlukKiralikDaireService _gunlukKiralikDaireService;
        IGunlukKiralikRezidansService _gunlukKiralikRezidansService;
        IGunlukKiralikVillaService _gunlukKiralikVillaService;
        public GunlukKiralikController(IGunlukKiralikDaireService gunlukKiralikDaireService, IGunlukKiralikRezidansService gunlukKiralikRezidansService, IGunlukKiralikVillaService gunlukKiralikVillaService)
        {
            _gunlukKiralikDaireService = gunlukKiralikDaireService;
            _gunlukKiralikRezidansService = gunlukKiralikRezidansService;
            _gunlukKiralikVillaService = gunlukKiralikVillaService;
        }
        public ActionResult Daire()
        {
            var getir = new GunlukKiralikDaireViewModel
            {
                gunlukKiralikDaire = _gunlukKiralikDaireService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Rezidans()
        {
            var getir = new GunlukKiralikRezidansViewModel
            {
                gunlukKiralikRezidans = _gunlukKiralikRezidansService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult Villa()
        {
            var getir = new GunlukKiralikVillaViewModel
            {
                gunlukKiralikVilla = _gunlukKiralikVillaService.TumunuGetir()
            };
            return View(getir);
        }
    }
}
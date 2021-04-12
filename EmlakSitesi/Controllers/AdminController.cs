using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakSitesi.Controllers
{
    public class AdminController : Controller
    {
        EmlakSitesiContext db = new EmlakSitesiContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Uyeler()
        {
            var getir = db.Uye.ToList();
            return View(getir);
        }
        public ActionResult Ilanlar()
        {
            return View();
        }
        public ActionResult SatilikIlanlar()
        {
            var getir = db.SatilikDaire.ToList();
            return View(getir);
        }
        public ActionResult KiralikIlanlar()
        {
            var getir = db.KiralikDaire.ToList();
            return View(getir);
        }
        public ActionResult GunlukKiralikIlanlar()
        {
            var getir = db.GunlukKiralikDaire.ToList();
            return View(getir);
        }
        public ActionResult KonutProjeleri()
        {
            var getir = db.ProjeKonut.ToList();
            return View(getir);
        }
        public ActionResult TokiProjeleri()
        {
            var getir = db.ProjeToki.ToList();
            return View(getir);
        }
        public ActionResult EmlakKonutProjeleri()
        {
            var getir = db.ProjeEmlakKonut.ToList();
            return View(getir);
        }
        public ActionResult EmlakHaberleri()
        {
            var getir = db.EmlakHaber.ToList();
            return View(getir);
        }
        public ActionResult Takvim()
        {
            return View();
        }
        public ActionResult Hesabim()
        {
            return View();
        }
    }
}
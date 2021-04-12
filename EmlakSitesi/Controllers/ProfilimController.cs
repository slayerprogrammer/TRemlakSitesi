﻿using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using EmlakSitesi.Models.Anasayfa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakSitesi.Controllers
{
    public class ProfilimController : Controller
    {
        EmlakSitesiContext db = new EmlakSitesiContext();
        AnasayfaViewModel model = new AnasayfaViewModel();
        public ActionResult Index()
        {
            model.projeKonut = db.ProjeKonut.ToList();
            model.projeEmlakKonut = db.ProjeEmlakKonut.ToList();
            model.projeToki = db.ProjeToki.ToList();
            model.emlakHaber = db.EmlakHaber.ToList();
            model.satilikDaire = db.SatilikDaire.ToList();
            model.kiralikDaire = db.KiralikDaire.ToList();
            return View(model);
        }
        public ActionResult IlanVer()
        {
            return View();
        }
        public ActionResult Mesajlar()
        {
            return View();
        }
        public ActionResult Favoriler()
        {
            return View();
        }
        public ActionResult Profil()
        {
            return View();
        }
    }
}
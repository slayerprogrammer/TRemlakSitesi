using EmlakSitesi.Business.Abstract.Projeler;
using EmlakSitesi.DataAccess.Concrete.EntityFramework;
using EmlakSitesi.Models.Projeler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakSitesi.Controllers
{
    public class ProjelerController : Controller
    {
        IProjeKonutService _projeKonutService;
        IProjeEmlakKonutService _projeEmlakKonutService;
        IProjeTokiService _projeTokiService;
        public ProjelerController(IProjeEmlakKonutService projeEmlakKonutService, IProjeKonutService projeKonutService, IProjeTokiService projeTokiService)
        {
            _projeEmlakKonutService = projeEmlakKonutService;
            _projeKonutService = projeKonutService;
            _projeTokiService = projeTokiService;
        }
        public ActionResult KonutProjeleri()
        {
            var getir = new ProjeKonutViewModel
            {
                projeKonut = _projeKonutService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult TokiProjeleri()
        {
            var getir = new ProjeTokiViewModel
            {
                projeToki = _projeTokiService.TumunuGetir()
            };
            return View(getir);
        }
        public ActionResult EmlakKonutProjeleri()
        {
            var getir = new ProjeEmlakKonutViewModel
            {
                projeEmlakKonut = _projeEmlakKonutService.TumunuGetir()
            };
            return View(getir);
        }
    }
}
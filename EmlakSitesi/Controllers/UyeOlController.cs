using EmlakSitesi.Business.Abstract;
using EmlakSitesi.Entities;
using EmlakSitesi.Filters;
using EmlakSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmlakSitesi.Controllers
{
    public class UyeOlController : Controller
    {
        IUyeService _uyeService;
        public UyeOlController(IUyeService uyeService)
        {
            _uyeService = uyeService;
        }
        public ActionResult Index()
        {
            return View(new UyeAddViewModel());
        }

        [HttpPost]
        [ExceptionHandler]
        public ActionResult Index(Uye uye)
        {
            _uyeService.Add(uye);
            return RedirectToAction("Index","GirisYap");
        }
    }
}
using EmlakSitesi.DataAccess.Abstract;
using EmlakSitesi.Entities;
using EmlakSitesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace EmlakSitesi.Controllers
{
    public class GirisYapController : Controller
    {
        IUyeDal _uyeDal;
        IAdminDal _adminDal;
        public GirisYapController(IUyeDal uyeDal,IAdminDal adminDal)
        {
            _uyeDal = uyeDal;
            _adminDal = adminDal;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Uye uye, Admin admin)
        {
            var kullanici = _uyeDal.Get(x => x.Email == uye.Email && x.Sifre == uye.Sifre);
            var adminkullanici = _adminDal.Get(x=>x.Email==admin.Email&& x.Sifre==admin.Sifre);
            if (kullanici != null)
            {
                FormsAuthentication.SetAuthCookie(kullanici.Email, false);
                return RedirectToAction("Index","Profilim");
            }
            if (adminkullanici != null)
            {
                //FormsAuthentication.SetAuthCookie(kullanici.Email, false);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }            
        }
        public ActionResult SifremiUnuttum()
        {
            return View();
        }
    }
}
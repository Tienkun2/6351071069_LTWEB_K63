using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private QLBANSACHEntities db = new QLBANSACHEntities();
        public ActionResult Index()
        {
            var Sach = db.SACHes.ToList();
            return View(Sach);
            
        }

        public ActionResult Search()
        {
            return View();
        }

        public PartialViewResult Category()
        {
            var category = from cd in db.CHUDEs select cd;
            return PartialView(category);
        }

        public PartialViewResult NhaXuatBan()
        {
            var nhaxuatban = from cd in db.NHAXUATBANs select cd;
            return PartialView(nhaxuatban);
        }

        public ActionResult SPtheochude(int id)
        {
            var sach = db.SACHes.Where(s => s.MaCD == id).ToList();
            return View(sach);
        }


        public ActionResult SPtheonhaxuatban(int id)
        {
            var sach = db.SACHes.Where(s => s.MaNXB == id).ToList();
            return View(sach);
        }

        public ActionResult Details (int id)
        {
            var sach = db.SACHes.FirstOrDefault(s => s.Masach == id);
            return View(sach);
        }
    }
}
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Controllers
{
    public class UtilitiesController : Controller
    {
        public HighSchool db = new HighSchool();
        // GET: Utilities
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Teachers()
        {
            var list = db.GiaoViens.ToList();
            return View(list);
        }
        public ActionResult Students()
        {
            var list = db.HocSinhs.ToList();
            return View(list);
        }
    }
}
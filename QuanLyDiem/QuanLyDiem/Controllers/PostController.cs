using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Controllers
{
    public class PostController : Controller
    {
        public HighSchool db = new HighSchool();
        // GET: Post
        public ActionResult Index()
        {
            return View();
        }

        // GET: Detail
        public ActionResult Detail(int id)
        {
            BaiViet bv = db.BaiViets.Find(id);
            return View(bv);
        }
    }
}
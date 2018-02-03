using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Controllers
{
    public class CategoryController : Controller
    {
        public HighSchool db = new HighSchool();
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        //GET : Category/Detail/DM1
        public ActionResult Detail(string id)
        {
            ViewBag.CategoryName = db.DanhMucs.Find(id).ten;
            List<BaiViet> posts = db.BaiViets.Where(x => x.DanhMuc.ma == id).Take(7).ToList();
            return View(posts);
        }
    }
}
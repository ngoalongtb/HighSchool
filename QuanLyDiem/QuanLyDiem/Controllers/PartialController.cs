﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Controllers
{
    public class PartialController : Controller
    {
        public HighSchool db = new HighSchool();
        // GET: Partial
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Menu()
        {
            List<DanhMuc> categories = db.DanhMucs.ToList();
            return View(categories);
        }
        public ActionResult News()
        {
            List<BaiViet> posts = db.BaiViets.OrderByDescending(x => x.do_uu_tien).Take(7).ToList();
            return View(posts);
        }
    }
}
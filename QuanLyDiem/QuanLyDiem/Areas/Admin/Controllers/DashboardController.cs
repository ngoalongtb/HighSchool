using Model.EF;
using QuanLyDiem.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        public HighSchool db = new HighSchool();
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            DashboardModel model = new DashboardModel();

            model.numberOfAccounts = db.TaiKhoans.Count();
            model.numberOfCategories = db.DanhMucs.Count();
            model.numberOfClasses = db.LopHocs.Count();
            model.numberOfPosts = db.BaiViets.Count();
            model.numberOfSemesters = db.KyHocs.Count();
            model.numberOfStudents = db.HocSinhs.Count();
            model.numberOfTeachers = db.GiaoViens.Count();
            model.numberOfSubjects = db.MonHocs.Count();

            return View(model);
        }
    }
}
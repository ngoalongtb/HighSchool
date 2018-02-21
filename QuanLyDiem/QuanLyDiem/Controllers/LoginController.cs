using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDiem.Controllers
{
    public class LoginController : Controller
    {
        public HighSchool db = new HighSchool();
        // GET: Login
        public ActionResult Index()
        {
            ViewBag.Message = TempData["Message"];
            return View();
        }
        //POST 

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var temp = db.TaiKhoans.Where(x => x.tai_khoan == username && x.mat_khau == password);
            if(temp.Count() == 1)
            {
                TaiKhoan loginAccount = temp.SingleOrDefault();
                loginAccount.mat_khau = "";
                Session.Add("LoginAccount", loginAccount);
                return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
            }else
            {
                TempData["Message"] = "Tài khoản hoặc mật khẩu không chính xác";
                return RedirectToAction("Index");
            }
        }
        public ActionResult Logout()
        {
            Session.Remove("LoginAccount");
            return Redirect("/");
        }
    }
}
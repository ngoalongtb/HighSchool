using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model.EF;

namespace QuanLyDiem.Areas.Admin.Controllers
{
    public class TeachersController : Controller
    {
        private HighSchool db = new HighSchool();

        // GET: Admin/Teachers
        public ActionResult Index()
        {
            var giaoViens = db.GiaoViens.Include(g => g.TaiKhoan);
            return View(giaoViens.ToList());
        }

        // GET: Admin/Teachers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoVien giaoVien = db.GiaoViens.Find(id);
            if (giaoVien == null)
            {
                return HttpNotFound();
            }
            return View(giaoVien);
        }

        // GET: Admin/Teachers/Create
        public ActionResult Create()
        {
            ViewBag.ma = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau");
            return View();
        }

        // POST: Admin/Teachers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,ten,ngay_sinh,url_anh,so_dien_thoai,email,ngay_vao_truong")] GiaoVien giaoVien)
        {
            if (ModelState.IsValid)
            {
                if(Request.Files.Count> 0 && Request.Files[0].FileName.Trim() != "")
                {
                    string[] _arr = Request.Files[0].FileName.Split('.');
                    string type = _arr[_arr.Length - 1];
                    giaoVien.url_anh = giaoVien.ma + "." + type;
                    Request.Files[0].SaveAs(Server.MapPath("~/Public/upload/teacher/") + giaoVien.url_anh);
                }
                db.GiaoViens.Add(giaoVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", giaoVien.ma);
            return View(giaoVien);
        }

        // GET: Admin/Teachers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoVien giaoVien = db.GiaoViens.Find(id);
            if (giaoVien == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", giaoVien.ma);
            return View(giaoVien);
        }

        // POST: Admin/Teachers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,ten,ngay_sinh,url_anh,so_dien_thoai,email,ngay_vao_truong")] GiaoVien giaoVien)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0 && Request.Files[0].FileName.Trim() != "")
                {
                    string[] _arr = Request.Files[0].FileName.Split('.');
                    string type = _arr[_arr.Length - 1];
                    giaoVien.url_anh = giaoVien.ma + "." + type;
                    Request.Files[0].SaveAs(Server.MapPath("~/Public/upload/teacher/") + giaoVien.url_anh);
                }

                db.Entry(giaoVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma = new SelectList(db.TaiKhoans, "tai_khoan", "mat_khau", giaoVien.ma);
            return View(giaoVien);
        }

        // GET: Admin/Teachers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GiaoVien giaoVien = db.GiaoViens.Find(id);
            if (giaoVien == null)
            {
                return HttpNotFound();
            }
            return View(giaoVien);
        }

        // POST: Admin/Teachers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            GiaoVien giaoVien = db.GiaoViens.Find(id);
            db.GiaoViens.Remove(giaoVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

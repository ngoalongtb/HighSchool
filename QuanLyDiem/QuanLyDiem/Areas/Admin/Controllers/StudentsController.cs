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
    public class StudentsController : Controller
    {
        private HighSchool db = new HighSchool();

        // GET: Admin/Students
        public ActionResult Index()
        {
            return View(db.HocSinhs.ToList());
        }

        // GET: Admin/Students/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinhs.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hocSinh);
        }

        // GET: Admin/Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,ten,ngay_sinh,ma_lop_on_dinh,so_dien_thoai,email,url_anh,ngay_nhap_hoc")] HocSinh hocSinh)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0 && Request.Files[0].FileName.Trim() != "")
                {
                    string[] _arr = Request.Files[0].FileName.Split('.');
                    string type = _arr[_arr.Length - 1];
                    hocSinh.url_anh = hocSinh.ma + "." + type;
                    Request.Files[0].SaveAs(Server.MapPath("~/Public/upload/student/") + hocSinh.url_anh);
                }

                db.HocSinhs.Add(hocSinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hocSinh);
        }

        // GET: Admin/Students/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinhs.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hocSinh);
        }

        // POST: Admin/Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,ten,ngay_sinh,ma_lop_on_dinh,so_dien_thoai,email,url_anh,ngay_nhap_hoc")] HocSinh hocSinh)
        {
            if (ModelState.IsValid)
            {
                if (Request.Files.Count > 0 && Request.Files[0].FileName.Trim() != "")
                {
                    string[] _arr = Request.Files[0].FileName.Split('.');
                    string type = _arr[_arr.Length - 1];
                    hocSinh.url_anh = hocSinh.ma + "." + type;
                    Request.Files[0].SaveAs(Server.MapPath("~/Public/upload/student/") + hocSinh.url_anh);
                }

                db.Entry(hocSinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hocSinh);
        }

        // GET: Admin/Students/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HocSinh hocSinh = db.HocSinhs.Find(id);
            if (hocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hocSinh);
        }

        // POST: Admin/Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            HocSinh hocSinh = db.HocSinhs.Find(id);
            db.HocSinhs.Remove(hocSinh);
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

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
    public class MainClassesController : Controller
    {
        private HighSchool db = new HighSchool();

        // GET: Admin/MainClasses
        public ActionResult Index()
        {
            var lopOnDinhs = db.LopOnDinhs.Include(l => l.GiaoVien);
            return View(lopOnDinhs.ToList());
        }

        // GET: Admin/MainClasses/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopOnDinh lopOnDinh = db.LopOnDinhs.Find(id);
            if (lopOnDinh == null)
            {
                return HttpNotFound();
            }
            return View(lopOnDinh);
        }

        // GET: Admin/MainClasses/Create
        public ActionResult Create()
        {
            ViewBag.ma_gv_chu_nhiem = new SelectList(db.GiaoViens, "ma", "ten");
            return View();
        }

        // POST: Admin/MainClasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,ten,ma_khoa,ma_gv_chu_nhiem")] LopOnDinh lopOnDinh)
        {
            if (ModelState.IsValid)
            {
                db.LopOnDinhs.Add(lopOnDinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_gv_chu_nhiem = new SelectList(db.GiaoViens, "ma", "ten", lopOnDinh.ma_gv_chu_nhiem);
            return View(lopOnDinh);
        }

        // GET: Admin/MainClasses/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopOnDinh lopOnDinh = db.LopOnDinhs.Find(id);
            if (lopOnDinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_gv_chu_nhiem = new SelectList(db.GiaoViens, "ma", "ten", lopOnDinh.ma_gv_chu_nhiem);
            return View(lopOnDinh);
        }

        // POST: Admin/MainClasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,ten,ma_khoa,ma_gv_chu_nhiem")] LopOnDinh lopOnDinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopOnDinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_gv_chu_nhiem = new SelectList(db.GiaoViens, "ma", "ten", lopOnDinh.ma_gv_chu_nhiem);
            return View(lopOnDinh);
        }

        // GET: Admin/MainClasses/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopOnDinh lopOnDinh = db.LopOnDinhs.Find(id);
            if (lopOnDinh == null)
            {
                return HttpNotFound();
            }
            return View(lopOnDinh);
        }

        // POST: Admin/MainClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LopOnDinh lopOnDinh = db.LopOnDinhs.Find(id);
            db.LopOnDinhs.Remove(lopOnDinh);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ListStudents(string id)
        {
            ViewBag.MainClass = db.LopOnDinhs.Find(id);
            List<HocSinh> students = db.HocSinhs.Where(x => x.LopOnDinh.ma == id).ToList();
            return View(students);
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

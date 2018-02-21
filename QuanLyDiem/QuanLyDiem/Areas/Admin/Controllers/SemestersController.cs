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
    public class SemestersController : Controller
    {
        private HighSchool db = new HighSchool();

        // GET: Admin/Semesters
        public ActionResult Index()
        {
            return View(db.KyHocs.ToList());
        }

        // GET: Admin/Semesters/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KyHoc kyHoc = db.KyHocs.Find(id);
            if (kyHoc == null)
            {
                return HttpNotFound();
            }
            return View(kyHoc);
        }

        // GET: Admin/Semesters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Semesters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,ky_hoc,bat_dau,ket_thuc")] KyHoc kyHoc)
        {
            if (ModelState.IsValid)
            {
                db.KyHocs.Add(kyHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kyHoc);
        }

        // GET: Admin/Semesters/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KyHoc kyHoc = db.KyHocs.Find(id);
            if (kyHoc == null)
            {
                return HttpNotFound();
            }
            return View(kyHoc);
        }

        // POST: Admin/Semesters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,ky_hoc,bat_dau,ket_thuc")] KyHoc kyHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kyHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kyHoc);
        }

        // GET: Admin/Semesters/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KyHoc kyHoc = db.KyHocs.Find(id);
            if (kyHoc == null)
            {
                return HttpNotFound();
            }
            return View(kyHoc);
        }

        // POST: Admin/Semesters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            KyHoc kyHoc = db.KyHocs.Find(id);
            db.KyHocs.Remove(kyHoc);
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

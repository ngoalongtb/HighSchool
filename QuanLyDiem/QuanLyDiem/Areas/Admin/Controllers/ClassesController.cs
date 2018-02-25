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
    public class ClassesController : Controller
    {
        private HighSchool db = new HighSchool();

        // GET: Admin/Classes
        public ActionResult Index()
        {
            var lopHocs = db.LopHocs.Include(l => l.GiaoVien).Include(l => l.KyHoc).Include(l => l.LopOnDinh).Include(l => l.MonHoc);
            return View(lopHocs.ToList());
        }

        // GET: Admin/Classes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc lopHoc = db.LopHocs.Find(id);
            if (lopHoc == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc);
        }

        // GET: Admin/Classes/Create
        public ActionResult Create()
        {
            ViewBag.ma_giao_vien = new SelectList(db.GiaoViens, "ma", "ten");
            ViewBag.ma_ky_hoc = new SelectList(db.KyHocs, "ma", "ky_hoc");
            ViewBag.ma_lop_on_dinh = new SelectList(db.LopOnDinhs, "ma", "ten");
            ViewBag.ma_mon_hoc = new SelectList(db.MonHocs, "ma", "ten");
            return View();
        }

        // POST: Admin/Classes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,ma_mon_hoc,ma_ky_hoc,ma_giao_vien,ma_lop_on_dinh")] LopHoc lopHoc)
        {
            if (ModelState.IsValid)
            {
                db.LopHocs.Add(lopHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ma_giao_vien = new SelectList(db.GiaoViens, "ma", "ten", lopHoc.ma_giao_vien);
            ViewBag.ma_ky_hoc = new SelectList(db.KyHocs, "ma", "ky_hoc", lopHoc.ma_ky_hoc);
            ViewBag.ma_lop_on_dinh = new SelectList(db.LopOnDinhs, "ma", "ten", lopHoc.ma_lop_on_dinh);
            ViewBag.ma_mon_hoc = new SelectList(db.MonHocs, "ma", "ten", lopHoc.ma_mon_hoc);



            return View(lopHoc);
        }

        // GET: Admin/Classes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc lopHoc = db.LopHocs.Find(id);
            if (lopHoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.ma_giao_vien = new SelectList(db.GiaoViens, "ma", "ten", lopHoc.ma_giao_vien);
            ViewBag.ma_ky_hoc = new SelectList(db.KyHocs, "ma", "ky_hoc", lopHoc.ma_ky_hoc);
            ViewBag.ma_lop_on_dinh = new SelectList(db.LopOnDinhs, "ma", "ten", lopHoc.ma_lop_on_dinh);
            ViewBag.ma_mon_hoc = new SelectList(db.MonHocs, "ma", "ten", lopHoc.ma_mon_hoc);
            return View(lopHoc);
        }

        // POST: Admin/Classes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,ma_mon_hoc,ma_ky_hoc,ma_giao_vien,ma_lop_on_dinh")] LopHoc lopHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lopHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ma_giao_vien = new SelectList(db.GiaoViens, "ma", "ten", lopHoc.ma_giao_vien);
            ViewBag.ma_ky_hoc = new SelectList(db.KyHocs, "ma", "ky_hoc", lopHoc.ma_ky_hoc);
            ViewBag.ma_lop_on_dinh = new SelectList(db.LopOnDinhs, "ma", "ten", lopHoc.ma_lop_on_dinh);
            ViewBag.ma_mon_hoc = new SelectList(db.MonHocs, "ma", "ten", lopHoc.ma_mon_hoc);
            return View(lopHoc);
        }

        // GET: Admin/Classes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LopHoc lopHoc = db.LopHocs.Find(id);
            if (lopHoc == null)
            {
                return HttpNotFound();
            }
            return View(lopHoc);
        }

        // POST: Admin/Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LopHoc lopHoc = db.LopHocs.Find(id);
            db.LopHocs.Remove(lopHoc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ScoreManager(string id)
        {
            List<LopHocHocSinh> model = db.LopHocHocSinhs.Where(x=>x.ma_lop == id).ToList();
            var _class = db.LopHocs.Find(id);
            ViewBag.ClassMessage = _class.MonHoc.ten + "   " + _class.LopOnDinh.ten;
            return View(model);
        }

        public ActionResult EnterScore()
        {
            string maHS = Request.Params["maHS"];
            string maLop = Request.Params["maLop"];
            LopHocHocSinh model = new LopHocHocSinh();
            model.ma_lop = maLop;
            model.ma_hoc_sinh = maHS;
            return View(model);
        }

        [HttpPost]
        public ActionResult EnterScore(LopHocHocSinh lopHocHocSinh)
        {
            var _lopHocHocSinh = db.LopHocHocSinhs.SingleOrDefault(x=>x.ma_lop == lopHocHocSinh.ma_lop && x.ma_hoc_sinh == lopHocHocSinh.ma_hoc_sinh);
            _lopHocHocSinh.diemThi = lopHocHocSinh.diemThi;
            _lopHocHocSinh.diemTrenLop = lopHocHocSinh.diemTrenLop;
            db.SaveChanges();
            return Redirect("~/Admin/Classes/ScoreManager/" + lopHocHocSinh.ma_lop);
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

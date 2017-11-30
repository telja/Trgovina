using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebTrgovina.Models.Domain;

namespace WebTrgovina.Controllers.Kosaras
{
    public class KosarasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Kosaras
        public ActionResult Index()
        {
            var kosare = db.Kosare.Include(k => k.Artikl);
            return View(kosare.ToList());
        }

        // GET: Kosaras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kosara kosara = db.Kosare.Find(id);
            if (kosara == null)
            {
                return HttpNotFound();
            }
            return View(kosara);
        }

        // GET: Kosaras/Create
        public ActionResult Create()
        {
            ViewBag.ArtiklId = new SelectList(db.Artikli, "Id", "Naziv");
            return View();
        }

        // POST: Kosaras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ApplicationUserId,ArtiklId,DatumNarudzbe")] Kosara kosara)
        {
            if (ModelState.IsValid)
            {
                db.Kosare.Add(kosara);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ArtiklId = new SelectList(db.Artikli, "Id", "Naziv", kosara.ArtiklId);
            return View(kosara);
        }

        // GET: Kosaras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kosara kosara = db.Kosare.Find(id);
            if (kosara == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtiklId = new SelectList(db.Artikli, "Id", "Naziv", kosara.ArtiklId);
            return View(kosara);
        }

        // POST: Kosaras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ApplicationUserId,ArtiklId,DatumNarudzbe")] Kosara kosara)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kosara).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ArtiklId = new SelectList(db.Artikli, "Id", "Naziv", kosara.ArtiklId);
            return View(kosara);
        }

        // GET: Kosaras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kosara kosara = db.Kosare.Find(id);
            if (kosara == null)
            {
                return HttpNotFound();
            }
            return View(kosara);
        }

        // POST: Kosaras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kosara kosara = db.Kosare.Find(id);
            db.Kosare.Remove(kosara);
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

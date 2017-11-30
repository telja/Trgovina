using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebTrgovina.Controllers.Reviews.Manager;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.ViewModels;

namespace WebTrgovina.Controllers.ControllerReview.Reviews
{
    public class ReviewsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Reviews
        public ActionResult Index()
        {
            var reviewsVM = ReviewManager.GetAllReviews();
            return View(reviewsVM.ToList());
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var reviewVM = ReviewManager.GetReviewById(id.Value);
            if (reviewVM == null)
            {
                return HttpNotFound();
            }
            return View(reviewVM);
        }

        // GET: Reviews/Create
        public ActionResult Create(int? artiklId)
        {
            var reviewVM = new ReviewVM();
            reviewVM.ArtiklVMId = artiklId.Value;
            return View(reviewVM);
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ocjena,Opis,ArtiklVMId,ApplicationUserId")] ReviewVM reviewVM)
        {
            if (ModelState.IsValid)
            {
                ReviewManager.CreateReview(reviewVM);
                return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Artikls", action = "Index" }));
            }

            ViewBag.ArtiklId = new SelectList(db.Artikli, "Id", "Naziv", reviewVM.ArtiklVMId);
            //return View(reviewVM);
            return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Artikls", action = "Index"}));
        }

        // GET: Reviews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var reviewVM = ReviewManager.GetReviewById(id.Value);
            if (reviewVM == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtiklId = new SelectList(db.Artikli, "Id", "Naziv", reviewVM.ArtiklVMId);
            return View(reviewVM);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ocjena,Opis,ArtiklId,ApplicationUserId")] ReviewVM reviewVM)
        {
            if (ModelState.IsValid)
            {
                ReviewManager.EditReview(reviewVM);
                return RedirectToAction("Index");
            }
            ViewBag.ArtiklId = new SelectList(db.Artikli, "Id", "Naziv", reviewVM.ArtiklVMId);
            return View(reviewVM);
        }

        // GET: Reviews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var reviewVM = ReviewManager.GetReviewById(id.Value);
            if (reviewVM == null)
            {
                return HttpNotFound();
            }
            return View(reviewVM);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReviewManager.DeleteReview(id);
            return RedirectToAction("Index");
        }

     
    }
}

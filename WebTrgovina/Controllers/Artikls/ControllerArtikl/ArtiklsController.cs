using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebTrgovina.Controllers.Artikls.Manager;
using WebTrgovina.Controllers.ControllerReview.Reviews;
using WebTrgovina.Models;
using WebTrgovina.Models.Domain;
using WebTrgovina.Models.ViewModels;
using WebTrgovina.Models.ViewModels.ArtiklViewModels;

namespace WebTrgovina.Controllers.Artikls.ControllerArtikl
{
    public class ArtiklsController : Controller
    {
       
        // GET: Artikls
        public ActionResult Index()
        {
            var artikliVM = ArtiklsManager.GetAllArtikls();
            return View(artikliVM);
        }

        // GET: Artikls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var artiklVM = ArtiklsManager.GetArtiklDetailsById(id.Value);
            if (artiklVM == null)
            {
                return HttpNotFound();
            }
            return View(artiklVM);
        }

        // GET: Artikls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artikls/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Naziv,Opis,Kolicina,DatumUnosa,Cjena")] ArtiklVM artiklVM)
        {
            if (ModelState.IsValid)
            {
                ArtiklsManager.CreateArtikl(artiklVM);
                return RedirectToAction("Index");
            }
            return View(artiklVM);
        }

        // GET: Artikls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtiklVM artiklVM = ArtiklsManager.GetArtiklById(id.Value);
            if (artiklVM == null)
            {
                return HttpNotFound();
            }
            return View(artiklVM);
        }

        // POST: Artikls/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Naziv,Opis,Kolicina,DatumUnosa,Cjena")] ArtiklVM artiklVM)
        {
            if (ModelState.IsValid)
            {
                ArtiklsManager.EditArtikl(artiklVM);
                return RedirectToAction("Index");
            }
            return View(artiklVM);
        }

        // GET: Artikls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ArtiklVM artiklVM = ArtiklsManager.GetArtiklById(id.Value);
            if (artiklVM == null)
            {
                return HttpNotFound();
            }
            return View(artiklVM);
        }

        // POST: Artikls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ArtiklsManager.DeleteArtikl(id);
            return RedirectToAction("Index");
        }
        public ActionResult AddReview(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            var reviewController = new ReviewsController();
            int ArtiklId = id.Value;

            return RedirectToAction("Create", new RouteValueDictionary(new { controller = "Reviews", action = "Create", artiklId = id.Value }));


        }

    }
}

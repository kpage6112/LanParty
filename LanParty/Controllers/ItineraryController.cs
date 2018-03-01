using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LanParty.Models;

namespace LanParty.Controllers
{
    public class ItineraryController : Controller
    {
        private LanPartyContext db = new LanPartyContext();

        // GET: Itineraries
        public ActionResult Index()
        {
            var itinerary = db.Itinerary.Include(i => i.LanParty);
            return View(itinerary.ToList());
        }

        // GET: Itineraries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itinerary.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // GET: Itineraries/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.LanPartyID = new SelectList(db.LanParty, "ID", "Location");
            return View();
        }

        // POST: Itineraries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "ID,LanPartyID")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                db.Itinerary.Add(itinerary);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LanPartyID = new SelectList(db.LanParty, "ID", "Location", itinerary.LanPartyID);
            return View(itinerary);
        }

        // GET: Itineraries/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itinerary.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            ViewBag.LanPartyID = new SelectList(db.LanParty, "ID", "Location", itinerary.LanPartyID);
            return View(itinerary);
        }

        // POST: Itineraries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID,LanPartyID")] Itinerary itinerary)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itinerary).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LanPartyID = new SelectList(db.LanParty, "ID", "Location", itinerary.LanPartyID);
            return View(itinerary);
        }

        // GET: Itineraries/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Itinerary itinerary = db.Itinerary.Find(id);
            if (itinerary == null)
            {
                return HttpNotFound();
            }
            return View(itinerary);
        }

        // POST: Itineraries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Itinerary itinerary = db.Itinerary.Find(id);
            db.Itinerary.Remove(itinerary);
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

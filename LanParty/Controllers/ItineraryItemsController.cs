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
    public class ItineraryItemsController : Controller
    {
        private LanPartyContext db = new LanPartyContext();

        // GET: ItineraryItems
        public ActionResult Index()
        {
            var itineraryItems = db.ItineraryItems.Include(i => i.Games).Include(i => i.Itinerary);
            return View(itineraryItems.ToList());
        }

        // GET: ItineraryItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryItem itineraryItem = db.ItineraryItems.Find(id);
            if (itineraryItem == null)
            {
                return HttpNotFound();
            }
            return View(itineraryItem);
        }

        // GET: ItineraryItems/Create
        [Authorize]
        public ActionResult Create()
        {
            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName");
            ViewBag.ItineraryID = new SelectList(db.Itinerary, "ID", "ID");
            return View();
        }

        // POST: ItineraryItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "ID,ItineraryID,StartTime,EndTime,Activity,GameID")] ItineraryItem itineraryItem)
        {
            if (ModelState.IsValid)
            {
                db.ItineraryItems.Add(itineraryItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName", itineraryItem.GameID);
            ViewBag.ItineraryID = new SelectList(db.Itinerary, "ID", "ID", itineraryItem.ItineraryID);
            return View(itineraryItem);
        }

        // GET: ItineraryItems/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryItem itineraryItem = db.ItineraryItems.Find(id);
            if (itineraryItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName", itineraryItem.GameID);
            ViewBag.ItineraryID = new SelectList(db.Itinerary, "ID", "ID", itineraryItem.ItineraryID);
            return View(itineraryItem);
        }

        // POST: ItineraryItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID,ItineraryID,StartTime,EndTime,Activity,GameID")] ItineraryItem itineraryItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(itineraryItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName", itineraryItem.GameID);
            ViewBag.ItineraryID = new SelectList(db.Itinerary, "ID", "ID", itineraryItem.ItineraryID);
            return View(itineraryItem);
        }

        // GET: ItineraryItems/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItineraryItem itineraryItem = db.ItineraryItems.Find(id);
            if (itineraryItem == null)
            {
                return HttpNotFound();
            }
            return View(itineraryItem);
        }

        // POST: ItineraryItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        
        public ActionResult DeleteConfirmed(int id)
        {
            ItineraryItem itineraryItem = db.ItineraryItems.Find(id);
            db.ItineraryItems.Remove(itineraryItem);
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

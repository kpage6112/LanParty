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
    public class LanPartiesController : Controller
    {
        private LanPartyContext db = new LanPartyContext();

        // GET: LanParties
        public ActionResult Index()
        {
            return View(db.LanParty.ToList());
        }

        // GET: LanParties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LanParty lanParty = db.LanParty.Find(id);
            if (lanParty == null)
            {
                return HttpNotFound();
            }
            return View(lanParty);
        }

        // GET: LanParties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LanParties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Date,StartTime,EndTime,Location")] LanParty lanParty)
        {
            if (ModelState.IsValid)
            {
                db.LanParty.Add(lanParty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lanParty);
        }

        // GET: LanParties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LanParty lanParty = db.LanParty.Find(id);
            if (lanParty == null)
            {
                return HttpNotFound();
            }
            return View(lanParty);
        }

        // POST: LanParties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Date,StartTime,EndTime,Location")] LanParty lanParty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lanParty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lanParty);
        }

        // GET: LanParties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LanParty lanParty = db.LanParty.Find(id);
            if (lanParty == null)
            {
                return HttpNotFound();
            }
            return View(lanParty);
        }

        // POST: LanParties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LanParty lanParty = db.LanParty.Find(id);
            db.LanParty.Remove(lanParty);
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

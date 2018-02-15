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
    public class GameOwnedsController : Controller
    {
        private LanPartyContext db = new LanPartyContext();

        // GET: GameOwneds
        public ActionResult Index()
        {
            var gamesOwned = db.GamesOwned.Include(g => g.Games).Include(g => g.Members);
            return View(gamesOwned.ToList());
        }

        // GET: GameOwneds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameOwned gameOwned = db.GamesOwned.Find(id);
            if (gameOwned == null)
            {
                return HttpNotFound();
            }
            return View(gameOwned);
        }

        // GET: GameOwneds/Create
        public ActionResult Create()
        {
            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName");
            ViewBag.MemberID = new SelectList(db.Members, "ID", "UserName");
            return View();
        }

        // POST: GameOwneds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameID,MemberID")] GameOwned gameOwned)
        {
            if (ModelState.IsValid)
            {
                db.GamesOwned.Add(gameOwned);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName", gameOwned.GameID);
            ViewBag.MemberID = new SelectList(db.Members, "ID", "UserName", gameOwned.MemberID);
            return View(gameOwned);
        }

        // GET: GameOwneds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameOwned gameOwned = db.GamesOwned.Find(id);
            if (gameOwned == null)
            {
                return HttpNotFound();
            }
            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName", gameOwned.GameID);
            ViewBag.MemberID = new SelectList(db.Members, "ID", "UserName", gameOwned.MemberID);
            return View(gameOwned);
        }

        // POST: GameOwneds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameID,MemberID")] GameOwned gameOwned)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameOwned).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GameID = new SelectList(db.Games, "ID", "GameName", gameOwned.GameID);
            ViewBag.MemberID = new SelectList(db.Members, "ID", "UserName", gameOwned.MemberID);
            return View(gameOwned);
        }

        // GET: GameOwneds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameOwned gameOwned = db.GamesOwned.Find(id);
            if (gameOwned == null)
            {
                return HttpNotFound();
            }
            return View(gameOwned);
        }

        // POST: GameOwneds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameOwned gameOwned = db.GamesOwned.Find(id);
            db.GamesOwned.Remove(gameOwned);
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

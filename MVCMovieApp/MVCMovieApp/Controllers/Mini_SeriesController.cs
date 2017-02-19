using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCMovieApp.Models;

namespace MVCMovieApp.Controllers
{
    public class Mini_SeriesController : Controller
    {
        private ApocalypseEntities3 db = new ApocalypseEntities3();

        // GET: Mini_Series
        public ActionResult Index()
        {
            return View(db.Mini_Series.ToList());
        }

        // GET: Mini_Series/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mini_Series mini_Series = db.Mini_Series.Find(id);
            if (mini_Series == null)
            {
                return HttpNotFound();
            }
            return View(mini_Series);
        }

        // GET: Mini_Series/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mini_Series/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Actress1,Actress2,Actress3,Actress4,Actress5,Actress6,Actress7,Actress8,Actress9,Actress10,Studio,Case,Position")] Mini_Series mini_Series)
        {
            if (ModelState.IsValid)
            {
                db.Mini_Series.Add(mini_Series);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mini_Series);
        }

        // GET: Mini_Series/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mini_Series mini_Series = db.Mini_Series.Find(id);
            if (mini_Series == null)
            {
                return HttpNotFound();
            }
            return View(mini_Series);
        }

        // POST: Mini_Series/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Actress1,Actress2,Actress3,Actress4,Actress5,Actress6,Actress7,Actress8,Actress9,Actress10,Studio,Case,Position")] Mini_Series mini_Series)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mini_Series).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mini_Series);
        }

        // GET: Mini_Series/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mini_Series mini_Series = db.Mini_Series.Find(id);
            if (mini_Series == null)
            {
                return HttpNotFound();
            }
            return View(mini_Series);
        }

        // POST: Mini_Series/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mini_Series mini_Series = db.Mini_Series.Find(id);
            db.Mini_Series.Remove(mini_Series);
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CanjeLibros.Models;

namespace CanjeLibros.Controllers
{
    public class LibroesController : Controller
    {
        private DbContextLibros db = new DbContextLibros();

        // GET: Libroes
        public ActionResult Index()
        {
            return View(db.Libroes.ToList());
        }

        // GET: Libroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libroes libroes = db.Libroes.Find(id);
            if (libroes == null)
            {
                return HttpNotFound();
            }
            return View(libroes);
        }

        // GET: Libroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,title,author,editorial,publishingDate,genre,synopsis,language,photo")] Libroes libroes)
        {
            if (ModelState.IsValid)
            {
                if(libroes.photo == null)
                {
                    libroes.photo = "https://www.freeiconspng.com/uploads/no-image-icon-6.png";
                }

                db.Libroes.Add(libroes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(libroes);
        }

        // GET: Libroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libroes libroes = db.Libroes.Find(id);
            if (libroes == null)
            {
                return HttpNotFound();
            }
            return View(libroes);
        }

        // POST: Libroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,title,author,editorial,publishingDate,genre,synopsis,language,photo")] Libroes libroes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libroes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(libroes);
        }

        // GET: Libroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libroes libroes = db.Libroes.Find(id);
            if (libroes == null)
            {
                return HttpNotFound();
            }
            return View(libroes);
        }

        // POST: Libroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Libroes libroes = db.Libroes.Find(id);
            db.Libroes.Remove(libroes);
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

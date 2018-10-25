﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CanjeLibros.Models;

namespace CanjeLibros.App_Data
{
    public class ExchangesController : Controller
    {
        private UsuarioDBContext db = new UsuarioDBContext();

        // GET: Exchanges
        public ActionResult Index()
        {
            return View(db.Exchanges.ToList());
        }

        // GET: Exchanges/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exchange exchange = db.Exchanges.Find(id);
            if (exchange == null)
            {
                return HttpNotFound();
            }
            return View(exchange);
        }

        // GET: Exchanges/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exchanges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,idUser1,idUser2,idBook1,idBook2,done")] Exchange exchange)
        {
            if (ModelState.IsValid)
            {
                db.Exchanges.Add(exchange);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exchange);
        }

        // GET: Exchanges/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exchange exchange = db.Exchanges.Find(id);
            if (exchange == null)
            {
                return HttpNotFound();
            }
            return View(exchange);
        }

        // POST: Exchanges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,idUser1,idUser2,idBook1,idBook2,done")] Exchange exchange)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exchange).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exchange);
        }

        // GET: Exchanges/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exchange exchange = db.Exchanges.Find(id);
            if (exchange == null)
            {
                return HttpNotFound();
            }
            return View(exchange);
        }

        // POST: Exchanges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exchange exchange = db.Exchanges.Find(id);
            db.Exchanges.Remove(exchange);
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

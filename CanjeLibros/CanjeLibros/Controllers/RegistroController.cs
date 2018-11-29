using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CanjeLibros.Models;

namespace CanjeLibros.Controllers
{
    public class RegistroController : Controller
    {
        private DbContextLibros db = new DbContextLibros();

        // GET: Usuarios/Create
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ID,userName,name,lastName,email,password,location,phone")] Usuarios usuario)
        {
            if (ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                return RedirectToAction("UserCreated", new RouteValueDictionary(new { controller = "Login", action = "UserCreated", registroExitoso = true }));
            }

            return View(usuario);
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

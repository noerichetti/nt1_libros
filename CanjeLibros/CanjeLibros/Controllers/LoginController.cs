using CanjeLibros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CanjeLibros.Controllers
{
    public class LoginController : Controller
    {
        private DbContextLibros db = new DbContextLibros();

        // GET: Login
        public ActionResult Index()
        {
            ViewBag.RegistroExitoso = false;

            return View();
        }

        public ActionResult UserCreated(Boolean registroExitoso)
        {
            ViewBag.RegistroExitoso = registroExitoso;
            ViewBag.RegistroMensaje = "Registro exitoso! Ya puede iniciar sesión.";

            return View("Index");
        }

        [HttpPost]
        public ActionResult Ingresar(Usuarios usuario)
        {
            var user = db.Usuarios.FirstOrDefault(u => u.userName == usuario.userName && u.password == usuario.password);

            if (user == null) {
                ViewBag.RegistroExitoso = false;
                ViewBag.LoginError = "Credenciales incorrectas";

                return View("Index");
            }

            return RedirectToAction("Index", "Libroes");
        }
    }
}
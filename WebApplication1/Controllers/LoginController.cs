using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
       

        [HttpPost]
        public ActionResult Verificar(Account cuenta)
        {
            try
            {
                using (webFinalEntities db = new webFinalEntities())
                {
                    var consulta_user = db.users.Where(x => x.nombre_usuario == cuenta.User).FirstOrDefault();
                    var consulta_pass = db.users.Where(x => x.password_usuario == cuenta.Password).FirstOrDefault();

                    if (!(consulta_user == null && consulta_pass == null))
                    {

                        return RedirectToAction("Index", "Socios");

                    }
                    else
                    {
                        return View("Error");

                    }

                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Error", ex.Message);
                return View();
            }
        }
    }
}
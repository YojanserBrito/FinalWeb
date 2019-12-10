using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebApplication1.Transversal.Dto;

namespace WebApplication1.Controllers
{
    public class SociosController : Controller
    {
        private webFinalEntities db = new webFinalEntities();

        // GET: Socios
        public ActionResult Index()
        {
            return View(db.Socios.ToList());
        }

        // GET: Socios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // GET: Socios/Create
        public ActionResult Create()
        {

            List<SelectListItem> lst = new List<SelectListItem>();

            var membresias = db.Membresias.ToList();
            foreach (var membresia in membresias)
            {
                lst.Add(new SelectListItem() { Text = membresia.Tipo, Value = membresia.Id_Membresia.ToString() });
            }
            ViewBag.Opciones = lst;
            ViewBag.Sexo = new SelectList(db.Socios, "M", "F");
            return View(new Socio());
           
        }

        // POST: Socios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Socio socio)
        {
            HttpPostedFileBase fileBase = Request.Files[0];
            WebImage image = new WebImage(fileBase.InputStream);
            socio.Foto = image.GetBytes();
            if (ModelState.IsValid)
            {
                socio.Estado = true;
                db.Socios.Add(socio);

               db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(socio);
        }

        // GET: Socios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // POST: Socios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Socio socio)
        {

            byte[] imagen = null;
            HttpPostedFileBase fileBase = Request.Files[0];
            if (fileBase == null)
            {
                imagen = db.Socios.SingleOrDefault(x => x.Id_Socio == socio.Id_Socio).Foto;
            }
            else
            {
                WebImage image = new WebImage(fileBase.InputStream);
                socio.Foto = image.GetBytes();
            }


            if (ModelState.IsValid)
            {
                db.Entry(socio).State = EntityState.Modified;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(socio);
        }

        // GET: Socios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Socio socio = db.Socios.Find(id);
            if (socio == null)
            {
                return HttpNotFound();
            }
            return View(socio);
        }

        // POST: Socios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Socio socio = db.Socios.Find(id);
            db.Socios.Remove(socio);
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

        public ActionResult Inicio()
        {
            return View();
        }

        public ActionResult getImage(int id)
        {
            Socio sociok = db.Socios.Find(id);
            byte[] byteImage = sociok.Foto;
            MemoryStream memoriaS = new MemoryStream(byteImage);
            Image image = Image.FromStream(memoriaS);
            memoriaS = new MemoryStream();
            image.Save(memoriaS, ImageFormat.Jpeg);
            memoriaS.Position = 0;

            
            return File(memoriaS,"image/jpg");

        }
    }
}

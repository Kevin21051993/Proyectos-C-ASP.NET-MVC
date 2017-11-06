using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MantenimientoMvc.Models;

namespace MantenimientoMvc.Controllers
{
    public class HomeController : Controller
    {
        private bdnotasEntities db = new bdnotasEntities();

        // GET: Home
        public ActionResult Index()
        {
            var alumno = db.Alumno.Include(a => a.especialidad);
            return View(alumno.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            ViewBag.Idesp = new SelectList(db.especialidad, "Idesp", "Nomesp");
            return View();
        }

        // POST: Home/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdAlumno,ApeAlumno,NomAlumno,Idesp,proce")] Alumno a)
        {
            if (ModelState.IsValid)
            {
                //db.Alumno.Add(alumno);
                //db.SaveChanges();
                db.SPADIALU(a.ApeAlumno,a.NomAlumno,a.Idesp,a.proce); //Registramos el alumno
                return RedirectToAction("Index");
            }

            ViewBag.Idesp = new SelectList(db.especialidad, "Idesp", "Nomesp", a.Idesp);
            return View(a);
        }

        // GET: Home/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            ViewBag.Idesp = new SelectList(db.especialidad, "Idesp", "Nomesp", alumno.Idesp);
            return View(alumno);
        }

        // POST: Home/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdAlumno,ApeAlumno,NomAlumno,Idesp,proce")] Alumno alumno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alumno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Idesp = new SelectList(db.especialidad, "Idesp", "Nomesp", alumno.Idesp);
            return View(alumno);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alumno alumno = db.Alumno.Find(id);
            if (alumno == null)
            {
                return HttpNotFound();
            }
            return View(alumno);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Alumno alumno = db.Alumno.Find(id);
            db.Alumno.Remove(alumno);
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

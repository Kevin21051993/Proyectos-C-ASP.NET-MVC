using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManteminiemtoClinica.Models;

namespace ManteminiemtoClinica.Controllers
{
    public class PacientesController : Controller
    {
        private BDCLINICA2Entities db = new BDCLINICA2Entities();

        //
        // GET: /Pacientes/

        public ActionResult Index(string id, string nomMed, int coleg)
        {
            var lis = from p in db.Citas
                      where p.codmed == id
                      select p;

            Session["codMed"] = id;
            Session["nomMed"] = nomMed;
            Session["col"] = coleg;
            return View(lis.ToList());
        }

        //
        // GET: /Pacientes/Details/5

        public ActionResult Details(int id = 0)
        {
            Citas citas = db.Citas.Find(id);
            if (citas == null)
            {
                return HttpNotFound();
            }
            return View(citas);
        }

        //
        // GET: /Pacientes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pacientes/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Citas citas)
        {
            if (ModelState.IsValid)
            {
                //db.Citas.Add(citas);
                //db.SaveChanges();
                db.sp_AdiCita((string)ViewBag.codMed, citas.nompac, citas.tipo, (decimal)ViewBag.costoEsp);
                return RedirectToAction("~/Pacientes/Index");
            }

            return View(citas);
        }

        //
        // GET: /Pacientes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Citas citas = db.Citas.Find(id);
            if (citas == null)
            {
                return HttpNotFound();
            }
            return View(citas);
        }

        //
        // POST: /Pacientes/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Citas citas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(citas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("~/Pacientes/Index");
            }
            return View(citas);
        }

        //
        // GET: /Pacientes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Citas citas = db.Citas.Find(id);
            if (citas == null)
            {
                return HttpNotFound();
            }
            return View(citas);
        }

        //
        // POST: /Pacientes/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Citas citas = db.Citas.Find(id);
            db.Citas.Remove(citas);
            db.SaveChanges();
            return RedirectToAction("~/Pacientes/Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
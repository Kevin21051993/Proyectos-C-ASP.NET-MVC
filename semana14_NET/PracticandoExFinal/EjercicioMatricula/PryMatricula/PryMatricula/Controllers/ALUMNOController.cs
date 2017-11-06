using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PryMatricula.Models;

namespace PryMatricula.Controllers
{
    public class ALUMNOController : Controller
    {
        private bdMatriculaEntities db = new bdMatriculaEntities();

        // GET: ALUMNO
        public ActionResult Index(string id, string nomCur, decimal costo)
        {
            var lis = from a in db.ALUMNO
                      where a.CODCUR == id
                      select a;
            ViewBag.nomC = nomCur;
            ViewBag.codC = id;
            ViewBag.cost = costo;
            return View(lis.ToList());
        }

        // GET: ALUMNO/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALUMNO aLUMNO = db.ALUMNO.Find(id);
            if (aLUMNO == null)
            {
                return HttpNotFound();
            }
            return View(aLUMNO);
        }

        // GET: ALUMNO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ALUMNO/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NROMAT,CODCUR,APENOM,TIPO,PAGO")] ALUMNO aLUMNO)
        {
            if (ModelState.IsValid)
            {
                db.ALUMNO.Add(aLUMNO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aLUMNO);
        }

        // GET: ALUMNO/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALUMNO aLUMNO = db.ALUMNO.Find(id);
            if (aLUMNO == null)
            {
                return HttpNotFound();
            }
            return View(aLUMNO);
        }

        // POST: ALUMNO/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NROMAT,CODCUR,APENOM,TIPO,PAGO")] ALUMNO aLUMNO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aLUMNO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aLUMNO);
        }

        // GET: ALUMNO/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ALUMNO aLUMNO = db.ALUMNO.Find(id);
            if (aLUMNO == null)
            {
                return HttpNotFound();
            }
            return View(aLUMNO);
        }

        // POST: ALUMNO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ALUMNO aLUMNO = db.ALUMNO.Find(id);
            db.ALUMNO.Remove(aLUMNO);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PryMatricula.Models;


namespace PryMatricula.Controllers
{
    public class HomeController : Controller
    {
        bdMatriculaEntities obj = new bdMatriculaEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View(obj.TABESP.ToList());
        }
        public ActionResult Cursos(string id, string nomE)
        {
            var lis = from c in obj.CURSO
                      where c.CODESP == id
                      select c;
            ViewBag.nomEs = nomE;
            return View(lis.ToList());
        }
        public ActionResult Alumnos(string id, string nomCur, decimal costo)
        {
            var lis = from a in obj.ALUMNO
                      where a.CODCUR == id
                      select a;
            ViewBag.nomC = nomCur;
            ViewBag.codC = id;
            ViewBag.cost = costo;
            return View(lis.ToList());
        }




    }
}
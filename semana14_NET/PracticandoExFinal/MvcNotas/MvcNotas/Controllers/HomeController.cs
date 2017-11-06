using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcNotas.Models;


namespace MvcNotas.Controllers
{
    public class HomeController : Controller
    {
        bdnotasEntities obj = new bdnotasEntities();
        public ActionResult Index()
        {
            return View(obj.especialidad.ToList());
        }
        public ActionResult LisAlu(string id, string nomEs)
        {
            var lis = from a in obj.Alumno
                      where a.Idesp == id
                      select a;

            ViewBag.nomEsp = nomEs;
            return View(lis.ToList());     
        }
        public ActionResult LisPago(string id, string nomAl)
        {
            var lis = from p in obj.PAGOS
                      where p.IdAlumno == id
                      select p;

            ViewBag.nomAl = nomAl;
            return View(lis.ToList());
        }
        public ActionResult LisNota(string id, string nomAl)
        {
            var lis = obj.spnota(id);
            ViewBag.nomAl = nomAl;
            return View(lis.ToList());
        }



        

    }
}
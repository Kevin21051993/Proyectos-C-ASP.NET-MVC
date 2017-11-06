using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManteminiemtoClinica.Models;

namespace ManteminiemtoClinica.Controllers
{
    public class HomeController : Controller
    {
        BDCLINICA2Entities obj = new BDCLINICA2Entities();
        // GET: /Home/

        public ActionResult Index()
        {
            return View(obj.tabesp.ToList());
        }
        public ActionResult Medicos(string id, string nomEs, decimal cost)
        {
            var lis = from m in obj.Medicos
                      where m.codes == id
                      select m;
            ViewBag.codEsp = id;
            ViewBag.nomEsp = nomEs;
            ViewBag.costoEsp = cost;
            return View(lis.ToList());
        }
        public ActionResult Pacientes(string id, string nomMed, int coleg)
        {
            var lis = from p in obj.Citas
                      where p.codmed == id
                      select p;
            Session["codMed"] = id;
            Session["nomMed"] = nomMed;
            Session["col"] = coleg;
            return View(lis.ToList());
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MantenimientoMvc.Models;

namespace MantenimientoMvc.Controllers
{
    public class ConsultaController : Controller
    {
        bdnotasEntities obj = new bdnotasEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NotaAlu(string id)
        {
            var lis = from c in obj.Curso
                      join n in obj.NOTAS
                      on c.IdCurso equals n.IdCurso
                      where n.IdAlumno == id
                      select new CursoNota
                      {
                          codc = c.IdCurso,
                          nomc = c.NomCurso,
                          exp = (double)n.ExaParcial,
                          exf = (double)n.ExaFinal,
                          pro = (double)(n.ExaParcial + n.ExaFinal),
                          obser = ((n.ExaParcial + n.ExaFinal) / 2) < 12 ? "Desaprobado" : "Aprobado"
                      };
            return View(lis.ToList());
        }
    }
}
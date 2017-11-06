using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pagina1 : System.Web.UI.Page
{   //creando el objeto que contiene todas las clases de lastablas
    DataNotasDataContext obj = new DataNotasDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {  //accediendo a las tablas del linq
            var lis = from es in obj.especialidads
                      select new { es.Idesp, es.Nomesp };
              //llenando el combo
            cbe.DataSource = lis.ToList();
            cbe.DataTextField = "nomesp";
            cbe.DataValueField = "idesp";
            cbe.DataBind();
        }
    }
    protected void cbe_SelectedIndexChanged(object sender, EventArgs e)
    { //cuando se eligio un item recuperar el codigo de especialidad
        string code = cbe.SelectedValue.ToString();
        var lis = from a in obj.Alumnos
                  where a.Idesp == code
                  select new { a.IdAlumno, a.ApeAlumno, a.NomAlumno };
        gwalu.DataSource = lis.ToList();
        gwalu.DataBind();
    }
    protected void gwalu_SelectedIndexChanged(object sender, EventArgs e)
    {
        string coda = gwalu.SelectedRow.Cells[1].Text;
        gwcurso.DataSource = obj.spnota(coda).ToList();
        gwcurso.DataBind();
    }
}
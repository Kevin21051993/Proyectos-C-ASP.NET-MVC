using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
{

    DataNotasDataContext obj = new DataNotasDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)    //Esto significa: si la página no ha sido enviada al servidor aún, entonces hacerlo
        {
            var lis = from c in obj.Cursos
                      select new { c.IdCurso, c.NomCurso };
            cbcurso.DataSource = lis.ToList();            //ToList() significa: Obtener la lisa genérica de datos.
            cbcurso.DataTextField = "nomcurso";
            cbcurso.DataValueField = "idcurso";
            cbcurso.DataBind();  //El DataBind enlaza el botón con los datos, siempre tiene que estar el DataBind

        }
    }

    protected void cbcurso_SelectedIndexChanged(object sender, EventArgs e)
    {
        string codC = cbcurso.SelectedValue.ToString();
        gvalum.DataSource = obj.spcurso(codC).ToList();
        gvalum.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.


    }
}
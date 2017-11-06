using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{
    public static string codEspp2, nomEspp2, codM2, nomMedd2;

    DataClinicaDataContext obj = new DataClinicaDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {

        nomMedd2 = Request.QueryString["nomMedd"];
        nomEspp2 = Request.QueryString["nomEspp"];
        codM2 = Request.QueryString["codM"];
        codEspp2 = Request.QueryString["codEspp"];
        lbNomMed.Text = nomMedd2;
        lbEsp.Text = nomEspp2;
        lbCodMed.Text = codM2;
        lbCodEsp.Text = codEspp2;

        var lis = from c in obj.Citas
                  where c.codmed == codM2
                  select new { c.nrocita,c.nompac,c.tipo,c.pago };
        gvCitas.DataSource = lis.ToList();  
        gvCitas.DataBind();

    }






    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina3.aspx?codEspp3=" + codEspp2 + "&nomEspp3=" + nomEspp2 + "&codM3=" + codM2 + "&nomMedd3=" + nomMedd2);


    }




    protected void gvCitas_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
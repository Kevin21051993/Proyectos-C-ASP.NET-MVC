using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
{

    DataClinicaDataContext obj = new DataClinicaDataContext();
    public static string codEspp, nomEspp, codM, nomMedd;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //Accediendo a las tablas del linq(el linq es bastante parecido al Hibernate Framework)
            var lis = from es in obj.tabesp
                      select new { es.code, es.nome };
            //Llenando el combo
            cbEsp.DataSource = lis.ToList();    //Tratando el lis como lista genérica
            cbEsp.DataTextField = "nome";
            cbEsp.DataValueField = "code";
            cbEsp.DataBind();   //DataBind es el enlace de datos, siempre tiene que ponerse esta línea, sino no se mostrará la información
                              //Siempre que traigo datos de una base de datos hacia un elemento de un formulario(tablas, datagridviews, 
                              //combos, etc) tengo que poner esta línea al final del código que escriba para traer dicha data.
        }

    }
    
    protected void cbEsp_SelectedIndexChanged(object sender, EventArgs e)
    {
        codEspp = cbEsp.SelectedValue.ToString();
        nomEspp = cbEsp.SelectedItem.ToString();
        var lis = from m in obj.Medicos
                  where m.codes == codEspp
                  select new { m.codmed,m.nombre,m.colegiatura }; // ahí se está obteniendo TODOS los campos

        gvMed.DataSource = lis.ToList();
        gvMed.DataBind();
    }


    protected void gvMed_SelectedIndexChanged(object sender, EventArgs e)
    {

        codM = gvMed.SelectedRow.Cells[1].Text;
        nomMedd = gvMed.SelectedRow.Cells[2].Text;
        Response.Redirect("Pagina2.aspx?codEspp=" + codEspp + "&nomEspp=" + nomEspp + "&codM=" + codM + "&nomMedd=" + nomMedd);
        
        //gwcurso.DataSource = obj.spnota(coda).ToList();  //Acá se utiliza el stored procedure de la bdnotas
        //gwcurso.DataBind();


    }

    /*
    public string codEsppp{get { return codEspp; }}
    public string nomEsppp { get { return nomEspp; } }
    public string codMeddd { get { return codM; } }
    public string nomMeddd { get { return nomMedd; } }
    */

}

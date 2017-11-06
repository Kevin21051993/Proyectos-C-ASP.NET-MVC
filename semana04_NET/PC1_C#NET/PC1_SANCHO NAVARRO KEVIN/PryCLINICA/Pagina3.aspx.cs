using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina3 : System.Web.UI.Page
{
    public static string codEspp3, nomEspp3, codM3, nomMedd3;
    DataClinicaDataContext obj = new DataClinicaDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        nomMedd3 = Request.QueryString["nomMedd3"];
        nomEspp3 = Request.QueryString["nomEspp3"];
        codM3 = Request.QueryString["codM3"];
        codEspp3 = Request.QueryString["codEspp3"];
        lbNomMed3.Text = nomMedd3;
        lbNomEsp3.Text = nomEspp3;
        lbCodMed3.Text = codM3;
        lbCodEsp3.Text = codEspp3;
        var costEsp = from te in obj.tabesp
                      where te.code == codEspp3
                      select new { te.costo }.ToString();

        /*
        var costosEsp = costEsp.ToList();
        double cosFinalEsp=0;
        foreach (var i in costosEsp)
        {
            cosFinalEsp = double.Parse(i.ToString());
            lbCostoEsp.Text = cosFinalEsp.ToString();
        }
        */

        

        string[] arreglo = new string[10];
        arreglo = costEsp.ToArray();
        lbCostoEsp.Text = arreglo[0];
        

    }

    protected void btnReg_Click(object sender, EventArgs e)
    {



    }



}
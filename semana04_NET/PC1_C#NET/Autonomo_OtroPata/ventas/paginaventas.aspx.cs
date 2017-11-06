using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class paginaventas : System.Web.UI.Page
{
    DataVentas2DataContext obj = new DataVentas2DataContext();

    protected void Page_Load(object sender, EventArgs e)
    {

      //var lisa = from ese in obj.Clientes
              //select new { ese.cli_cod, ese.cli_nom, ese.cli_tel };
       //gwalu.DataSource = lisa.ToList();
       
        //gwalu.DataBind();
             if (!Page.IsPostBack)
            {
               

           var lis = from es in obj.Fac_cabe
          select new {es.fac_num};
           //llenando el combo
           cbe.DataSource = lis.ToList();
          cbe.DataTextField = "fac_num";
        //cbe.DataValueField = "art_cod";
             cbe.DataBind();

            }

            //var lisa = from ese in obj.Clientes
            //      select new { ese.cli_cod, ese.cli_nom, ese.cli_tel };
            // gwalu.DataSource = lisa.ToList();
            //gwalu.DataBind(); 
           
    }
    protected void cbe_SelectedIndexChanged(object sender, EventArgs e)
    {

        string coda = cbe.SelectedValue.ToString();
        gwcurso.DataSource = obj.SPDETA(coda).ToList();
        gwcurso.DataBind();   
        
       //string code = cbe.SelectedValue.ToString();
       // var lis = from a in obj.Articulos
       
          // where a.art_cod == code
           //   select new { a.art_cod,a.art_nom,a.art_pre,a.art_uni};
       // gwcurso.DataSource = lis.ToList();
     // gwcurso.DataBind();
      
      


    }
    protected void gwalu_SelectedIndexChanged(object sender, EventArgs e)
    {

        


      string coda = gwalu.SelectedRow.Cells[0].Text;
     
         var lis = from a in obj.Fac_cabe

        where a.cli_cod == coda
        select new {a.fac_num};
        cbe.DataSource = lis.ToList();
        cbe.DataBind();

        string cod = cbe.SelectedValue.ToString();
        gwcurso.DataSource = obj.SPDETA(cod).ToList();
        gwcurso.DataBind(); 




    }
    protected void gwcurso_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void LinqDataSource1_Selecting(object sender, LinqDataSourceSelectEventArgs e)
    {

    }
    protected void LinqDataSource5_Selecting(object sender, LinqDataSourceSelectEventArgs e)
    {

    }
}
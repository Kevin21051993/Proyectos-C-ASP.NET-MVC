using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina1 : System.Web.UI.Page
{
    bdArtefactoEntities obj = new bdArtefactoEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            var lis = from l in obj.Linea
                      select l;
            cbLineas.DataSource = lis.ToList();
            cbLineas.DataTextField = "Lin_nom";
            cbLineas.DataValueField = "Lin_cod";
            cbLineas.DataBind();
        }
    }
    protected void cbLineas_SelectedIndexChanged(object sender, EventArgs e)
    {
        string codLin = cbLineas.SelectedValue;
        gvArtef.DataSource = obj.sp_ArtefactosxLinea(codLin);
        gvArtef.DataBind();
    }
    protected void gvArtef_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["codLin"] = cbLineas.SelectedValue;
        Session["codArt"] = gvArtef.SelectedRow.Cells[0].Text;
        Session["descArt"] = gvArtef.SelectedRow.Cells[1].Text;
        Session["precArt"] = gvArtef.SelectedRow.Cells[2].Text;
        Response.Redirect("Pagina2.aspx");
    }
}
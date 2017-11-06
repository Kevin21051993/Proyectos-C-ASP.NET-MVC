using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina3 : System.Web.UI.Page
{
    bdArtefactoEntities obj = new bdArtefactoEntities();

    void listadoFact() 
    {
        gvFact.DataSource = obj.sp_ListarProfConFormato(0);
        gvFact.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            lbCodArt.Text = (string)Session["codArt"];
            lbPrecCont.Text = (string)Session["precArt"];
            lbCodCli.Text = (string)Session["codCli"];
            listadoFact();
        }

    }
    protected void gvFact_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFact.PageIndex = e.NewPageIndex;
        listadoFact();
    }
    protected void btnGrabar_Click(object sender, EventArgs e)
    {
        string tipoVent="";
        switch (rblTipoComp.SelectedIndex)
        {
            case 0: tipoVent = "A"; break;
            case 1: tipoVent = "B"; break;
            case 2: tipoVent = "C"; break;
        }
        obj.sp_Adi_Prof((string)Session["codCli"],(string)Session["codArt"],Convert.ToDecimal(Session["precArt"]),tipoVent);
        listadoFact();
        rblTipoComp.ClearSelection();
        lbIntPag.Text = "";
        lbSaldo.Text = "";

    }
    protected void rblTipoComp_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rblTipoComp.SelectedIndex == 0)
        {
            lbIntPag.Text = ((decimal)(0.10*Convert.ToDouble(lbPrecCont.Text))).ToString();
            lbSaldo.Text = ((decimal)(Convert.ToDouble(lbPrecCont.Text)+ Convert.ToDouble(lbIntPag.Text))).ToString();
        }
        if (rblTipoComp.SelectedIndex == 1)
        {
            lbIntPag.Text = ((decimal)(0.18 * Convert.ToDouble(lbPrecCont.Text))).ToString();
            lbSaldo.Text = ((decimal)(Convert.ToDouble(lbPrecCont.Text) + Convert.ToDouble(lbIntPag.Text))).ToString();
        }
        if (rblTipoComp.SelectedIndex == 2)
        {
            lbIntPag.Text = ((decimal)(0.25 * Convert.ToDouble(lbPrecCont.Text))).ToString();
            lbSaldo.Text = ((decimal)(Convert.ToDouble(lbPrecCont.Text) + Convert.ToDouble(lbIntPag.Text))).ToString();
        }
    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina2.aspx");
    }
}
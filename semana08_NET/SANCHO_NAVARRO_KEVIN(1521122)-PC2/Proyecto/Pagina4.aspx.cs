using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina4 : System.Web.UI.Page
{

    bdArtefactoEntities obj = new bdArtefactoEntities();
    void listadoFactForm2(string cod)
    {
        gvFactForm2.DataSource = obj.sp_ListarProfConFormato2(cod);
        gvFactForm2.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void gvFactForm2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvFactForm2.PageIndex = e.NewPageIndex;
        listadoFactForm2((string)ViewState["codigoCli"]);
    }
    protected void btnBuscFact_Click(object sender, EventArgs e)
    {
        ViewState["codigoCli"] = txtCodCli.Text;
        listadoFactForm2((string)ViewState["codigoCli"]);

    }
}
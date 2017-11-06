using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{

    DataNotasDataContext obj = new DataNotasDataContext();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) 
        { 

            
        
        }

    }
    protected void cbesp_SelectedIndexChanged(object sender, EventArgs e)
    {
        obj.spadiAlu(txtape.Text,txtnom.Text,cbesp.Text,rbp.SelectedValue[0]);   //El [0] hace referencia a 1 caractér

    }
}
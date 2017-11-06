using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pagina2 : System.Web.UI.Page
{
    bdArtefactoEntities obj = new bdArtefactoEntities();
    void listadoCli() 
    {
        gvCli.DataSource = obj.Clientes.ToList();
        gvCli.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            listadoCli();
            PanelCli.Visible = false;
        }
    }
    protected void btnAdiCli_Click(object sender, EventArgs e)
    {
        ViewState["AccionCli"] = 1;
        lbTitCli.Text = "INGRESE NUEVO CLIENTE";
        txtNom.Text = "";
        txtRuc.Text = "";
        txtTel.Text = "";
        txtDirec.Text = "";
        PanelCli.Visible = true;
    }
    protected void gvCli_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["codCli"] = gvCli.SelectedRow.Cells[0].Text;
        Response.Redirect("Pagina3.aspx");

    }
    protected void gvCli_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int ind = int.Parse(e.CommandArgument.ToString()); //Detectamos en qué fila se hizo clic
        if (e.CommandName == "Modificar")
        {
            ViewState["AccionCli"] = 2;
            lbTitCli.Text = "MODIFICACION DE DATOS";
            PanelCli.Visible = true;
            txtNom.Text = gvCli.Rows[ind].Cells[1].Text;
            txtTel.Text = gvCli.Rows[ind].Cells[2].Text;
            string cod = gvCli.Rows[ind].Cells[0].Text;
            Session["codCli"] = cod;
            txtRuc.Text = Convert.ToString((from c in obj.Clientes
                          where c.cli_cod==cod
                          select c.cli_ruc).FirstOrDefault());
            txtDirec.Text = Convert.ToString((from c in obj.Clientes
                                              where c.cli_cod == cod
                                              select c.cli_dir).FirstOrDefault());
            PanelCli.Visible = true;
        }
        if (e.CommandName == "Eliminar")
        {
            string cod = gvCli.Rows[ind].Cells[0].Text;
            obj.sp_Elim_Cli(cod);
            listadoCli ();
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        int res = (int)ViewState["AccionCli"];
        if (res == 1)
        {
            obj.sp_Adi_Cli(txtNom.Text, Convert.ToDecimal(txtTel.Text), Convert.ToDecimal(txtRuc.Text), txtDirec.Text);
            listadoCli();
            txtNom.Text = "";
            txtRuc.Text = "";
            txtTel.Text = "";
            txtDirec.Text = "";
        }
        if (res == 2)
        {
            obj.sp_Modi_Cli((string)Session["codCli"], txtNom.Text, Convert.ToDecimal(txtTel.Text), Convert.ToDecimal(txtRuc.Text), txtDirec.Text);
            listadoCli();
            txtNom.Text = "";
            txtRuc.Text = "";
            txtTel.Text = "";
            txtDirec.Text = "";
            PanelCli.Visible = false;
        }
    }
    protected void btnReg_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pagina1.aspx");
    }
}
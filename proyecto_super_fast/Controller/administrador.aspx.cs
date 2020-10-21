using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_administrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){

    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e){
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "aceptar"){
         us.aceptarusuario(usuario1);
           // Response.Redirect("Inicio.aspx");
        }
       
    }
    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) {
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "aceptar"){
            us.aceptarusuario(usuario1);
          //  Response.Redirect("Inicio.aspx");
        }
    }
}
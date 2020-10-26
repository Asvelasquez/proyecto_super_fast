using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_administrador : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        LB_solicitudalaadosrechazados.Visible = false;
        GV_aliadorechazado.Visible = false;
        LB_solicituddomiciliariosrechazados.Visible = false;
        GV_domiciliariorechazado.Visible = false;

        //
        LB_solicitudalidosaceptados.Visible = false;
        GV_solicitudaliadosaceptados.Visible = false;
        LB_solicituddedomiciliariosaceptados.Visible = false;
        GV_domiciliariosaceptados.Visible = false;
        BTN_solicitudesaprobar.Visible = false;
        //

    }

    protected void GridView2_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e){
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();               
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Aceptar"){
         us.aceptarusuario(usuario1,((Usuario)Session["user"]).Correo);
         GridView2.DataBind();
        }else if (e.CommandName == "Rechazar"){
            us.rechazarusuario(usuario1, ((Usuario)Session["user"]).Correo);
           GridView2.DataBind();
        }

    }
    
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e) {
      //  ClientScriptManager cm = this.ClientScript;
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Aceptar"){
            us.aceptarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GridView1.DataBind();
  
        }
        else if (e.CommandName== "Rechazar"){
            us.rechazarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GridView1.DataBind();
          
        }
    }



    protected void GV_aliadorechazado_RowCommand(object sender, GridViewCommandEventArgs e){
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Aceptar"){
            us.aceptarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_aliadorechazado.DataBind();
        }else if (e.CommandName == "Revision"){
            us.revisionusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_aliadorechazado.DataBind();
        }
    }

    protected void GV_domiciliariorechazado_RowCommand(object sender, GridViewCommandEventArgs e){
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Aceptar"){
            us.aceptarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_domiciliariorechazado.DataBind();
        }
        else if (e.CommandName == "Revision"){
            us.revisionusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_domiciliariorechazado.DataBind();
        }
    }



    protected void BTN_solicitudesrechazas_Click(object sender, EventArgs e){
        LB_solicitudesaliados.Visible = false;
        GridView1.Visible = false;
        LB_solicituddomicilios.Visible = false;
        GridView2.Visible = false;
       
        //
        LB_solicitudalaadosrechazados.Visible = true;
        GV_aliadorechazado.Visible = true;
        LB_solicituddomiciliariosrechazados.Visible = true;
        GV_domiciliariorechazado.Visible = true;        
        BTN_solicitudesaprobar.Visible = true;
        //

        //
        LB_solicitudalidosaceptados.Visible = false;
        GV_solicitudaliadosaceptados.Visible = false;
        LB_solicituddedomiciliariosaceptados.Visible = false;
        GV_domiciliariosaceptados.Visible = false;
        
        //
    }

    protected void BTN_solicitudesaceptadas_Click(object sender, EventArgs e){
        LB_solicitudesaliados.Visible = true;
        GridView1.Visible = true;
        LB_solicituddomicilios.Visible = true;
        GridView2.Visible = true;

        //
        LB_solicitudalaadosrechazados.Visible = false;
        GV_aliadorechazado.Visible = false;
        LB_solicituddomiciliariosrechazados.Visible = false;
        GV_domiciliariorechazado.Visible = false;
        BTN_solicitudesaprobar.Visible = true;
        //

        //
        LB_solicitudalidosaceptados.Visible = true;
        GV_solicitudaliadosaceptados.Visible = true;
        LB_solicituddedomiciliariosaceptados.Visible = true;
        GV_domiciliariosaceptados.Visible = true;
        //
    }
}
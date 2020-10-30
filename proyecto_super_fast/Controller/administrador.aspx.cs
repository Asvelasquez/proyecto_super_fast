﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_administrador : System.Web.UI.Page{
    protected void Page_Load(object sender, EventArgs e){
        if (Session["user"] != null)
        {
            if (((Usuario)Session["user"]).Id_rol != 4)
            {
                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('acceso no permitido');</script>");
                Response.Redirect("AccesoDenegado.aspx");
            }


        }
        else
        {
            Response.Redirect("AccesoDenegado.aspx");
        }

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

    protected void GV_domiciliariiosaprobar_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e){
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        Usuario usuario2 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        usuario2.Hojavida =(e.CommandArgument.ToString());
        if (e.CommandName == "Aceptar"){
            us.aceptarusuario(usuario1,((Usuario)Session["user"]).Correo);
            GV_domiciliariiosaprobar.DataBind();
        }else if (e.CommandName == "Rechazar"){
            us.rechazarusuario(usuario1, ((Usuario)Session["user"]).Correo);
           GV_domiciliariiosaprobar.DataBind();
        }
        else if (e.CommandName == "hojavida")
        {
        Response.Write("window.open(usuario2, '_newtab');");

        }

    }
    //prueba
    protected void GV_aliadoaprobar_RowCommand(object sender, GridViewCommandEventArgs e) {
      //  ClientScriptManager cm = this.ClientScript;
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Aceptar"){
            us.aceptarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_aliadoaprobar.DataBind();
  
        }
        else if (e.CommandName== "Rechazar"){
            us.rechazarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_aliadoaprobar.DataBind();
          
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

    protected void GV_solicitudaliadosaceptados_RowCommand(object sender, GridViewCommandEventArgs e){
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Rechazar"){
            us.rechazarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_solicitudaliadosaceptados.DataBind();
        }
    }
    protected void GV_domiciliariosaceptados_RowCommand(object sender, GridViewCommandEventArgs e){
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Rechazar"){
            us.rechazarusuario(usuario1, ((Usuario)Session["user"]).Correo);
            GV_domiciliariosaceptados.DataBind();
        }
    }
    protected void BTN_solicitudesrechazas_Click(object sender, EventArgs e){
        LB_solicitudesaliados.Visible = false;
        GV_aliadoaprobar.Visible = false;
        LB_solicituddomicilios.Visible = false;
        GV_domiciliariiosaprobar.Visible = false;
       
        //
        LB_solicitudalaadosrechazados.Visible = true;
        GV_aliadorechazado.Visible = true;
        LB_solicituddomiciliariosrechazados.Visible = true;
        GV_domiciliariorechazado.Visible = true;
        BTN_solicitudesaprobar.Visible = true;
        BTN_solicitudesrechazas.Visible = false;
        BTN_solicitudesaceptadas.Visible = true;
        //

        //
        LB_solicitudalidosaceptados.Visible = false;
        GV_solicitudaliadosaceptados.Visible = false;
        LB_solicituddedomiciliariosaceptados.Visible = false;
        GV_domiciliariosaceptados.Visible = false;
        
        //
    }

    protected void BTN_solicitudesaceptadas_Click(object sender, EventArgs e){
        LB_solicitudesaliados.Visible = false;
        GV_aliadoaprobar.Visible = false;
        LB_solicituddomicilios.Visible = false;
        GV_domiciliariiosaprobar.Visible = false;
        //
        LB_solicitudalaadosrechazados.Visible = false;
        GV_aliadorechazado.Visible = false;
        LB_solicituddomiciliariosrechazados.Visible = false;
        GV_domiciliariorechazado.Visible = false;
        BTN_solicitudesaprobar.Visible = true;
        BTN_solicitudesrechazas.Visible = true;
        BTN_solicitudesaceptadas.Visible = false;
        //
        //
        LB_solicitudalidosaceptados.Visible = true;
        GV_solicitudaliadosaceptados.Visible = true;
        LB_solicituddedomiciliariosaceptados.Visible = true;
        GV_domiciliariosaceptados.Visible = true;
        
        //
    }

    protected void BTN_solicitudesaprobar_Click(object sender, EventArgs e){
        LB_solicitudesaliados.Visible = true;
        GV_aliadoaprobar.Visible = true;
        LB_solicituddomicilios.Visible = true;
        GV_domiciliariiosaprobar.Visible = true;
        //
        LB_solicitudalaadosrechazados.Visible = false;
        GV_aliadorechazado.Visible = false;
        LB_solicituddomiciliariosrechazados.Visible = false;
        GV_domiciliariorechazado.Visible = false;
        BTN_solicitudesaprobar.Visible = false;
        BTN_solicitudesrechazas.Visible = true;
        BTN_solicitudesaceptadas.Visible = true;
        //
        //
        LB_solicitudalidosaceptados.Visible = false;
        GV_solicitudaliadosaceptados.Visible = false;
        LB_solicituddedomiciliariosaceptados.Visible = false;
        GV_domiciliariosaceptados.Visible = false;
        
        //
    }

    
}
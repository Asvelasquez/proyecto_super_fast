﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_registrar_domiciliario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void BTND_registrar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        string nombreArchivo = System.IO.Path.GetFileName(FUD_hojavida.PostedFile.FileName);

        string extension = System.IO.Path.GetExtension(FUD_hojavida.PostedFile.FileName);

        string saveLocation = Server.MapPath("~\\Hojas_de_vida") + "\\" + nombreArchivo;

        if (!(extension.Equals(".PDF") || extension.Equals(".pdf") ))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido');</script>");
            return;}
        if (System.IO.File.Exists(saveLocation)){
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;}
        

        try{
            FUD_hojavida.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");

            Usuario domiciliario = new Usuario();
            domiciliario.Nombre = TBD_nombre.Text;
            domiciliario.Apellido = TBD_apellido.Text;
            domiciliario.Correo = TBD_correo.Text;
            domiciliario.Contrasenia = TBD_contrasena.Text;
            domiciliario.Documento = TBD_ndocumento.Text;
            domiciliario.Telefono = TBD_telefono.Text;
            domiciliario.Hojavida = "~\\Hojas_de_vida" + "\\" + nombreArchivo; ;
            domiciliario.Tipovehiculo = DDLD_tipovehiculo.Text;

            int rol3 = 3,aprob=0;
            domiciliario.Id_rol = rol3;
            domiciliario.Aprobacion = aprob;
            domiciliario.Auditoria = TBD_nombre.Text;
            new DAOUsuario().insertUsuario(domiciliario);
            
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su solicitud sera revisada y respondida al correo que ingreso');</script>");
           
          //  Response.Redirect("Inicio.aspx");
        }
        catch (Exception ex)
        { return; }


    }
}
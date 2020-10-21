﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Registrar_aliado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    String seleccion,texto;
    protected void DDLA_actividadcomercial_SelectedIndexChanged(object sender, EventArgs e){
        
        seleccion = DDLA_actividadcomercial.SelectedItem.Value;
        TBA_actividadcomercial.Text = seleccion;

       

    }



    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        TBA_actividadcomercial.Text = "";
    }

    protected void BTN_registrar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        string nombreArchivo = System.IO.Path.GetFileName(FUA_logo.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FUA_logo.PostedFile.FileName);
        string saveLocation = Server.MapPath("~\\Aliado\\logo") + "\\" + nombreArchivo;

        string nombreArchivo1 = System.IO.Path.GetFileName(FUA_rut.PostedFile.FileName);
        string extension1 = System.IO.Path.GetExtension(FUA_rut.PostedFile.FileName);
        string saveLocation1 = Server.MapPath("~\\Aliado\\rut") + "\\" + nombreArchivo1;

        if (!(extension.Equals(".jpg")  || extension.Equals(".JPEG") || extension.Equals(".png")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido, el LOGO tiene que ser en formato jpg, JPEG, png');</script>");
            return;
        }
        if (!(extension1.Equals(".pdf") || extension.Equals(".PDF") ))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido, el RUT tiene que ser en formato PDF');</script>");
            return;
        }
        if (System.IO.File.Exists(saveLocation))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;
        }

        if (System.IO.File.Exists(saveLocation1))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;
        }
        
        try
        {
            FUA_logo.PostedFile.SaveAs(saveLocation);
            FUA_rut.PostedFile.SaveAs(saveLocation1);

            Usuario aliado1 = new Usuario();
            aliado1.Nombre = TBA_nombrecomercial.Text;
            aliado1.Documento = TBA_nit.Text;
            aliado1.Correo = TBA_correo.Text;
            aliado1.Contrasenia = TBA_password.Text;
            aliado1.Telefono = TBA_telefono.Text;
            aliado1.Direccion = TBA_direccion.Text;
            aliado1.Actividadcomercial = TBA_actividadcomercial.Text;
            aliado1.Imagenperfil = "~\\Aliado\\logo" + "\\" + nombreArchivo; ;
            aliado1.Rut = "~\\Aliado\\rut" + "\\" + nombreArchivo1; ;
            int rol2 = 2, aprob = 0;
            aliado1.Id_rol = rol2;
            aliado1.Aprobacion = aprob;
            new DAOUsuario().insertUsuario(aliado1);

            //  Response.Redirect("Inicio.aspx");
        }
        catch (Exception ex)
        { return; }
    }
}
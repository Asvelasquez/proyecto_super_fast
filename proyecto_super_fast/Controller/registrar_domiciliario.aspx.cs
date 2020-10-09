using System;
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

        if (!(extension.Equals(".jpg") || extension.Equals(".gif") || extension.Equals(".JPEG") || extension.Equals(".png")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido');</script>");
            return;}
        if (System.IO.File.Exists(saveLocation)){
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;}
        

        try
        {
            FUD_hojavida.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");

            Domiciliario domiciliario1 = new Domiciliario();
            domiciliario1.Nombre_d = TBD_nombre.Text;
            domiciliario1.Apellido_d = TBD_apellido.Text;
            domiciliario1.Correo_d = TBD_correo.Text;
            domiciliario1.Contrasenia_d = TBD_contrasena.Text;
            domiciliario1.Documento_d = TBD_ndocumento.Text;
            domiciliario1.Telefono_d = TBD_telefono.Text;
            domiciliario1.Hojavida_d = "~\\Hojas_de_vida" + "\\" + nombreArchivo; ;
            domiciliario1.Tipovehiculo_d = DDLD_tipovehiculo.Text;

            new DAODomiciliario().insertDomiciliario(domiciliario1);
            Cliente cliente = new Cliente();
            cliente.Nombre = TBD_nombre.Text;
            cliente.Apellido = TBD_apellido.Text;
            cliente.Correo = TBD_correo.Text;
            cliente.Telefono = TBD_telefono.Text;
            cliente.Direccion = "no hay";
            cliente.Contrasenia = TBD_contrasena.Text;
            int rol3 = 3;
            cliente.Rol_id = rol3;
            new DAOCliente().insertCliente(cliente);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su solicitud sera revisada y respondida al correo que ingreso');</script>");
           
          //  Response.Redirect("Inicio.aspx");
        }
        catch (Exception ex)
        { return; }


    }
}
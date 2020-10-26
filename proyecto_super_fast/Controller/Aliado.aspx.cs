using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Aliado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BTN_guardarproducto_Click(object sender, EventArgs e){
        ClientScriptManager cm = this.ClientScript;

        string nombreArchivo = System.IO.Path.GetFileName(FP_imagen1.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FP_imagen1.PostedFile.FileName);
        string saveLocation = Server.MapPath("~\\Aliado\\imagenesproductos") + "\\" + nombreArchivo;
        string nombreArchivo1 = System.IO.Path.GetFileName(FP_imagen2.PostedFile.FileName);
        string extension1 = System.IO.Path.GetExtension(FP_imagen2.PostedFile.FileName);
        string saveLocation1 = Server.MapPath("~\\Aliado\\imagenesproductos") + "\\" + nombreArchivo1;

        if (!(extension.Equals(".jpg") || extension.Equals(".gif") || extension.Equals(".JPEG") || extension.Equals(".png"))){
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido');</script>");
            return;
        }
        if (System.IO.File.Exists(saveLocation)){
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
            return;
        }
        try {
            FP_imagen1.PostedFile.SaveAs(saveLocation);
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El archivo ha sido cargado');</script>");

            
            
            Producto producto1 = new Producto();
           
            producto1.Nombre_producto = TB_nombreproducto.Text;
            producto1.Descripcion_producto = TB_descripcionproducto.Text;            
            producto1.Precio_producto = Double.Parse(TB_precioproducto.Text);
            producto1.Imagen_producto1 = "~\\Aliado\\imagenesproductos" + "\\" + nombreArchivo; ;
            producto1.Imagen_producto2 = "~\\Aliado\\imagenesproductos" + "\\" + nombreArchivo1; ;
            new DAOProductos().insertProducto(producto1);
        }
        catch (Exception ex)
        { return; }
        ///////////////////////////////////
        


        try
        {
           
            
            new DAOUsuario().insertUsuario(domiciliario);

            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su solicitud sera revisada y respondida al correo que ingreso');</script>");

            //  Response.Redirect("Inicio.aspx");
        }
        catch (Exception ex)
        { return; }
        ////////////////////
    }
}
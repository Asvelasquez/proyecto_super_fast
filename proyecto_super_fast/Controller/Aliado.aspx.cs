using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Aliado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        if (Session["user"] != null){
            if (((Usuario)Session["user"]).Id_rol != 2){
              Response.Redirect("AccesoDenegado.aspx");
            }
            
        } else {
            Response.Redirect("AccesoDenegado.aspx");
        }

            

    }//

    protected void BTN_guardarproducto_Click(object sender, EventArgs e){
        ClientScriptManager cm = this.ClientScript;

        string nombreArchivo = System.IO.Path.GetFileName(FP_imagen1.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FP_imagen1.PostedFile.FileName);
        string saveLocation = Server.MapPath("~\\Aliado\\imagenesproducto") + "\\" + nombreArchivo;
        if (!(extension.Equals(".jpg") || extension.Equals(".JPEG") || extension.Equals(".png") || extension.Equals(".PNG") || extension.Equals(".JPG")))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido, la imagen tiene que ser formato jpg, JPEG o png');</script>");
            return;
        }
        if (System.IO.File.Exists(saveLocation))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre, cambielo y entente de nuevo');</script>");
            return;
        }

        try
        {
            
            Producto producto1 = new Producto();
            producto1.Nombre_producto = TB_nombreproducto.Text;
            producto1.Descripcion_producto = TB_descripcionproducto.Text;
            producto1.Precio_producto = Double.Parse(TB_precioproducto.Text);
            producto1.Imagen_producto1 = "~\\Aliado\\imagenesproducto" + "\\" + nombreArchivo; ;
            producto1.Estado_producto = 2;
            producto1.Correo_aliado = (((Usuario)Session["user"]).Correo);
            producto1.Nombre_aliado = (((Usuario)Session["user"]).Nombre);
            producto1.Actividad_comercial = (((Usuario)Session["user"]).Actividadcomercial);

            new DAOProductos().insertProducto(producto1);
            FP_imagen1.PostedFile.SaveAs(saveLocation);
            Response.Redirect("Aliado.aspx");
        }
        catch (Exception ex)
        { return; }//


    }//



    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        GV_pedidosaliado.DataBind();
    }
}
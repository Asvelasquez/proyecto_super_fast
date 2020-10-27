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
        string saveLocation = Server.MapPath("~\\Aliado\\imagenesproducto") + "\\" + nombreArchivo;
        if (!(extension.Equals(".jpg")  || extension.Equals(".JPEG") || extension.Equals(".png") || extension.Equals(".PNG") || extension.Equals(".JPG"))){
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido, la imagen tiene que ser formato jpg, JPEG o png');</script>");
            return;
        }
        if (System.IO.File.Exists(saveLocation)){
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre, cambielo y entente de nuevo');</script>");
            return;
        }
        
        try{
            FP_imagen1.PostedFile.SaveAs(saveLocation);    
            
            Producto producto1 = new Producto();           
            producto1.Nombre_producto = TB_nombreproducto.Text;
            producto1.Descripcion_producto = TB_descripcionproducto.Text;            
            producto1.Precio_producto = Double.Parse(TB_precioproducto.Text);
            producto1.Imagen_producto1 = "~\\Aliado\\imagenesproducto" + "\\" + nombreArchivo; ;           
            producto1.Estado_producto = 2;
            producto1.Correo_aliado= (((Usuario)Session["user"]).Correo);
            new DAOProductos().insertProducto(producto1);
        }
        catch (Exception ex)
        { return; }//
        
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        /*Filtro busqueda = new Filtro();
        busqueda.filtroproducto = ((Usuario)Session["user"]).Correo;
        Session["GV_sesionproducto"] = busqueda;*/
    }
}
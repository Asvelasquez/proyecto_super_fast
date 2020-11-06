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

    protected void GV_Productos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        DAOProductos us = new DAOProductos();
        Producto producto1 = new Producto();
        
        //producto1.Id = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Editar")
        {
            BTN_guardarproducto.Visible = false;
            BTN_GuardarCambios.Visible = true;
            mostrar(int.Parse(e.CommandArgument.ToString()));
            

            //us.updateproducto(producto1);
            //GV_domiciliariiosaprobar.DataBind();
        }
       
    }
    protected void mostrar(int id3)
    {

        DAOProductos productos1 = new DAOProductos();
        Producto productos2 = new Producto();
        productos2 = productos1.mostrar(id3);
        TB_nombreproducto.Text = productos2.Nombre_producto;
        TB_descripcionproducto.Text = productos2.Descripcion_producto;
        TB_precioproducto.Text = productos2.Precio_producto.ToString();
        TB_Url.Text = productos2.Imagen_producto1;
        TBX_Id.Text =  productos2.Id.ToString();


    }

    public void vaciar()
    {
        TB_nombreproducto.Text = "";
        TB_descripcionproducto.Text = "";
        TB_precioproducto.Text = "";

    }
    protected void BTN_GuardarCambios_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;

        string nombreArchivo = System.IO.Path.GetFileName(FP_imagen1.PostedFile.FileName);
        string extension = System.IO.Path.GetExtension(FP_imagen1.PostedFile.FileName);
        string saveLocation = Server.MapPath("~\\Aliado\\imagenesproducto") + "\\" + nombreArchivo;

        if (FP_imagen1.HasFile)
        {
            if (!(extension.Equals(".jpg") || extension.Equals(".JPEG") || extension.Equals(".png")))
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Tipo de archivo no valido');</script>");
                return;
            }
            if (System.IO.File.Exists(saveLocation))
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe un archivo en el servidor con ese nombre');</script>");
                return;
            }
            TB_Url.Text = "~\\imagenes_de_perfil" + "\\" + nombreArchivo; ;
        }
        else
        {

        }
        try
        {
            
            Producto producto1 = new Producto();
            producto1.Id = int.Parse(TBX_Id.Text);
            producto1.Nombre_producto = TB_nombreproducto.Text;
            producto1.Descripcion_producto = TB_descripcionproducto.Text;
            producto1.Precio_producto = Double.Parse(TB_precioproducto.Text);
            producto1.Imagen_producto1 = TB_Url.Text ;
            producto1.Estado_producto = 2;//REVISAR
            producto1.Correo_aliado = (((Usuario)Session["user"]).Correo);
            producto1.Nombre_aliado = (((Usuario)Session["user"]).Nombre);
            producto1.Actividad_comercial = (((Usuario)Session["user"]).Actividadcomercial);

            new DAOProductos().updateproducto(producto1);
            vaciar();
            if (!(TB_Url.Text == ((Usuario)Session["user"]).Imagenperfil))
            {//
                FP_imagen1.PostedFile.SaveAs(saveLocation);
            }//
            Response.Redirect("Aliado.aspx");
            

        }
        catch (Exception ex)
        { return; }//
       
    }
}
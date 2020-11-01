using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Producto> lista = new List<Producto>();
        if (!IsPostBack)
        {
            lista = new List<Producto>();
            Session["Carrito"] = lista;
        }
        else
        {
            lista = (List<Producto>)Session["Carrito"];

        }

        LB_Carrito.Text = lista.Count().ToString();
    }

    protected void Menu_principal_MenuItemClick(object sender, MenuEventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }



    protected void DL_Productos_ItemCommand(object source, DataListCommandEventArgs e){

        Pedido prod = new Pedido();
        DL_Productos.SelectedIndex = e.Item.ItemIndex;
        //  prod.Id_producto = int.Parse(e.CommandArgument.ToString());
       // prod.Id_producto = 2;
        prod.Nombre_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_nombreproducto")).Text;
        prod.Descripcion_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_descripcion")).Text;
        prod.Descripcion_pedido = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text;
        prod.Precio_pedido = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
        prod.Cantidad_pedido = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
       
      // prod.Imagen_producto1 = ((Image)DL_Productos.SelectedItem.FindControl("I_Productos")).ImageUrl;

        List<Pedido> lista = new List<Pedido>();
        if (Session["Carrito"] != null)
            lista = (List<Pedido>)Session["Carrito"];
       
        lista.Add(prod);
        LB_Carrito.Text = lista.Count().ToString();
        Session["Carrito"] = lista.OrderBy(x => x.Nombre_producto).ToList();
    }

  
}
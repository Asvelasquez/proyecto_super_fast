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



    protected void DL_Productos_ItemCommand(object source, DataListCommandEventArgs e)
    {
        Producto prod = new Producto();
        DL_Productos.SelectedIndex = e.Item.ItemIndex;
        prod.Precio_producto = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
        prod.Nombre_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_nombreproducto")).Text;
        prod.Cantidad_Producto = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
        prod.Id = int.Parse(e.CommandArgument.ToString());
        prod.Imagen_producto1 = ((Image)DL_Productos.SelectedItem.FindControl("I_Productos")).ImageUrl;

        List<Producto> lista = new List<Producto>();
        if (Session["Carrito"] != null)
            lista = (List<Producto>)Session["Carrito"];

        lista.Add(prod);
        LB_Carrito.Text = lista.Count().ToString();
        Session["Carrito"] = lista.OrderBy(x => x.Nombre_producto).ToList();
    }
}
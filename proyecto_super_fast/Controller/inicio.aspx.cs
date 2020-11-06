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
        List<Pedido> lista1 = new List<Pedido>();
        if (!IsPostBack)
        {
            lista = new List<Producto>();
            Session["Carrito"] = lista;
        }
        else
        {
            lista = (List<Producto>)Session["Carrito"];

        }

        LB_Carrito.Text = lista1.Count().ToString();
        //(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text)="1";
    }

    protected void Menu_principal_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
    

    protected void DL_Productos_ItemCommand(object source, DataListCommandEventArgs e){
        ClientScriptManager cm = this.ClientScript;
        if (Session["user"] == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('debe iniciar session, para poder comprar');</script>");

        }
        else if (((Usuario)(Session["user"])).Id_rol == 1)
        {
            //  Pedido prod = new Pedido();
            DL_Productos.SelectedIndex = e.Item.ItemIndex;
            //  //  prod.Id_producto = int.Parse(e.CommandArgument.ToString());
            //  prod.Id_producto = 2;
            //  prod.Nombre_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_nombreproducto")).Text;
            //  prod.Descripcion_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_descripcion")).Text;
            //  prod.Descripcion_pedido = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text;
            //  prod.Precio_pedido = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
            //  prod.Cantidad_pedido = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);

            //// prod.Imagen_producto1 = ((Image)DL_Productos.SelectedItem.FindControl("I_Productos")).ImageUrl;

            //  List<Pedido> lista = new List<Pedido>();
            //  if (Session["Carrito"] != null)
            //  lista = (List<Pedido>)Session["Carrito"];

            //  lista.Add(prod);
            //  LB_Carrito.Text = lista.Count().ToString();
            //  Session["Carrito"] = lista.OrderBy(x => x.Nombre_producto).ToList();
            try
            {
                Pedido pedido3 = new Pedido();
                
                pedido3.Nombre_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_nombreproducto")).Text;
                pedido3.Descripcion_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_descripcion")).Text;
                pedido3.Especificacion_pedido = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text;
                pedido3.Precio_pedido = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
                pedido3.Cantidad_pedido = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
                pedido3.Estado_pedido = 0;
                pedido3.Correo_cliente = ((Usuario)Session["user"]).Correo;
                pedido3.Nombre_clientec = ((Usuario)Session["user"]).Nombre + " " + ((Usuario)Session["user"]).Apellido;
                pedido3.Direccion_cliente = ((Usuario)Session["user"]).Direccion;
                pedido3.Telefono_cliente = ((Usuario)Session["user"]).Telefono;
                pedido3.Correo_aliadop = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_correoaliado")).Text;
                pedido3.Actividad_comercialp= ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_actividadcomercialp")).Text;
                
                new DAOPedido().insertPedido(pedido3);
            }
            catch (Exception ex)
            { return; }//
        }
        

    }


    protected void DL_productosfiltros_ItemCommand(object source, DataListCommandEventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        if (Session["user"] == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('debe iniciar session, para poder comprar');</script>");

        }
        else if (((Usuario)(Session["user"])).Id_rol == 1)
        {
            //  Pedido prod = new Pedido();
            DL_Productos.SelectedIndex = e.Item.ItemIndex;
            //  //  prod.Id_producto = int.Parse(e.CommandArgument.ToString());
            //  prod.Id_producto = 2;
            //  prod.Nombre_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_nombreproducto")).Text;
            //  prod.Descripcion_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_descripcion")).Text;
            //  prod.Descripcion_pedido = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text;
            //  prod.Precio_pedido = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
            //  prod.Cantidad_pedido = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);

            //// prod.Imagen_producto1 = ((Image)DL_Productos.SelectedItem.FindControl("I_Productos")).ImageUrl;

            //  List<Pedido> lista = new List<Pedido>();
            //  if (Session["Carrito"] != null)
            //  lista = (List<Pedido>)Session["Carrito"];

            //  lista.Add(prod);
            //  LB_Carrito.Text = lista.Count().ToString();
            //  Session["Carrito"] = lista.OrderBy(x => x.Nombre_producto).ToList();
            try
            {
                Pedido pedido3 = new Pedido();

                pedido3.Nombre_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_nombreproducto1")).Text;
                pedido3.Descripcion_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_descripcion1")).Text;
                pedido3.Especificacion_pedido = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion1")).Text;
                pedido3.Precio_pedido = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio1")).Text);
                pedido3.Cantidad_pedido = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad1")).Text);
                pedido3.Estado_pedido = 0;
                pedido3.Correo_cliente = ((Usuario)Session["user"]).Correo;
                pedido3.Nombre_clientec = ((Usuario)Session["user"]).Nombre + " " + ((Usuario)Session["user"]).Apellido;
                pedido3.Direccion_cliente = ((Usuario)Session["user"]).Direccion;
                pedido3.Telefono_cliente = ((Usuario)Session["user"]).Telefono;
                pedido3.Correo_aliadop = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_correoaliado")).Text;
                pedido3.Actividad_comercialp = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_actividadcomercialp1")).Text;

                new DAOPedido().insertPedido(pedido3);
            }
            catch (Exception ex)
            { return; }//
        }
    }


   

    protected void IB_Carrito_Click(object sender, ImageClickEventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        if (Session["user"] == null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('debe iniciar sesion, para poder comprar');</script>");

        }
        else if (((Usuario)(Session["user"])).Id_rol == 1)
        {
            Response.Redirect("Carrito.aspx");
        }
    }

    protected void BTN_buscar_Click(object sender, EventArgs e)
    {
        DL_Productos.Visible = false;
        DL_productosfiltros.Visible = true;
        DL_productosfiltrorest.Visible = false;
        TBX_buscar.Text=TBX_filtro1.Text;
        TBX_buscar.Text.Contains("");
    }

    protected void BTN_hamburguesa_Click(object sender, EventArgs e)
    {
        DL_Productos.Visible = false;
        DL_productosfiltros.Visible = true;
        DL_productosfiltrorest.Visible = false;
        TBX_buscar.Text = "hamburguesa";
    }

    protected void BTN_perrocaliente_Click(object sender, EventArgs e)
    {
        DL_Productos.Visible = false;
        DL_productosfiltros.Visible = true;
        TBX_buscar.Text = "perro";
        DL_productosfiltrorest.Visible = false;
    }

    protected void BTN_Restaurantes_Click(object sender, EventArgs e)
    {
       
    }

    protected void BTN_Supermecados_Click(object sender, EventArgs e)
    {
        DL_Productos.Visible = false;
        DL_productosfiltros.Visible = false;
        TBX_actividadcomercial.Text = "Super mercados";
        DL_productosfiltrorest.Visible = false;

    }

    protected void BTN_Restaurantes_Click1(object sender, EventArgs e)
    {
        DL_Productos.Visible = false;
        DL_productosfiltros.Visible = false;
        DL_productosfiltrorest.Visible = true;
        TBX_actividadcomercial.Text = "Restaurantes";
    }
}
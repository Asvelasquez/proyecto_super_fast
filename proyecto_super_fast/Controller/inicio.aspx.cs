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
            DL_Productos.SelectedIndex = e.Item.ItemIndex;
           

            Pedido pedido3 = new Pedido();
            Detalle_pedido det_pedido = new Detalle_pedido();
            DAOPedido dao = new DAOPedido();
            pedido3.Cliente_id = ((Usuario)Session["user"]).Id;
            pedido3.Fecha = DateTime.Now;
            pedido3.Estado_id = 1;
            pedido3.Aliado_id = 5;/////revisar   
            pedido3.Domiciliario_id =1;
            
            dao.insertPedido(pedido3);
           // det_pedido.Pedido_id = 1;
             det_pedido.Pedido_id = pedido3.Id_pedido;
            det_pedido.Descripcion = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion")).Text;
            det_pedido.V_unitario = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio")).Text);
            det_pedido.Cantidad = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad")).Text);
            det_pedido.Producto_id =int.Parse(e.CommandArgument.ToString());
            det_pedido.Direccion_cliente = ((Usuario)Session["user"]).Direccion;
            det_pedido.Telefono_cliente = ((Usuario)Session["user"]).Telefono;

            new DAODetalle_Pedido().insertdetallePedido(det_pedido);
            try
            {
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
           
            DL_Productos.SelectedIndex = e.Item.ItemIndex;

            try
            {
                Pedido pedido3 = new Pedido();

                //pedido3.Nombre_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_nombreproducto1")).Text;
                //pedido3.Descripcion_producto = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_descripcion1")).Text;
                //pedido3.Especificacion_pedido = ((TextBox)DL_Productos.SelectedItem.FindControl("TB_especificacion1")).Text;
                //pedido3.Precio_pedido = double.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_precio1")).Text);
                //pedido3.Cantidad_pedido = int.Parse(((TextBox)DL_Productos.SelectedItem.FindControl("TBX_cantidad1")).Text);
                //pedido3.Estado_pedido = 0;
                //pedido3.Correo_cliente = ((Usuario)Session["user"]).Correo;
                //pedido3.Nombre_clientec = ((Usuario)Session["user"]).Nombre + " " + ((Usuario)Session["user"]).Apellido;
                //pedido3.Direccion_cliente = ((Usuario)Session["user"]).Direccion;
                //pedido3.Telefono_cliente = ((Usuario)Session["user"]).Telefono;
                //pedido3.Correo_aliadop = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_correoaliado")).Text;
                //pedido3.Actividad_comercialp = ((TextBox)DL_Productos.SelectedItem.FindControl("TBX_actividadcomercialp1")).Text;

                //new DAOPedido().insertPedido(pedido3);
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
            new DAOPedido().obtenercarrito(((Usuario)Session["user"]).Id);
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
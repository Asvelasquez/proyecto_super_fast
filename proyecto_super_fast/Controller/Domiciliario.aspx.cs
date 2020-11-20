using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Domiciliario : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            if (((Usuario)Session["user"]).Id_rol != 3)
            {
                Response.Redirect("AccesoDenegado.aspx");
            }

        }
        else
        {
            Response.Redirect("AccesoDenegado.aspx");
        }

    }

    protected void GV_PedDomi_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        Pedido pedido = (Pedido)e.Row.DataItem;
        if (e.Row.FindControl("GV_detallespedido") != null)
        {
            ((GridView)e.Row.FindControl("GV_detallespedido")).DataSource = pedido.Compras;
            ((GridView)e.Row.FindControl("GV_detallespedido")).DataBind();
        }
    }

 
    protected void DDL_Estado_SelectedIndexChanged(object sender, EventArgs e)
    {
        DAOPedido pedido3 = new DAOPedido();
        Pedido pedido4 = new Pedido();
        DropDownList opciones = (DropDownList)sender;
        GridViewRow fila = (GridViewRow)opciones.Parent.Parent;
        int pedido = int.Parse(((Label)fila.FindControl("L_Pedido")).Text);
        pedido4.Id_pedido = pedido;

        //hacer el update
        string idseleccion = opciones.SelectedValue;
        pedido3.actualizarPedidoDomiciliario(pedido4, int.Parse(idseleccion));
        GV_PedDomi.DataBind();//
    }
}
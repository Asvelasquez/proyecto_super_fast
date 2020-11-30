using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_PedidosCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GV_pedidocarrito_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        Pedido pedido = (Pedido)e.Row.DataItem;
        int rowcount = GV_pedidocarrito.Rows.Count;
        if (rowcount == 0)
        {
            LB_Pedidos.Visible = true;
        }
        else
        {
            LB_Pedidos.Visible = false;
        }
        if (e.Row.FindControl("GV_detallespedido") != null)
        {
            ((GridView)e.Row.FindControl("GV_detallespedido")).DataSource = pedido.Compras;
            ((GridView)e.Row.FindControl("GV_detallespedido")).DataBind();
        }
    }
    protected void GV_pedidocarrito0_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        Pedido pedido = (Pedido)e.Row.DataItem;
        int rowcount = GV_pedidocarrito0.Rows.Count;
        if (rowcount == 0){
            LB_historial.Visible = true;
        }else{
            LB_historial.Visible = false;
        }
        if (e.Row.FindControl("GV_detallespedido0") != null){
            ((GridView)e.Row.FindControl("GV_detallespedido0")).DataSource = pedido.Compras;
            ((GridView)e.Row.FindControl("GV_detallespedido0")).DataBind();
        }
    }

    protected void GV_pedidocarrito_RowCommand(object sender, GridViewCommandEventArgs e)
    {

        DAOPedido daopedido = new DAOPedido();
        Pedido pedido2 = new Pedido();
        pedido2.Id_pedido = int.Parse(e.CommandArgument.ToString());
        if (e.CommandName == "Cancelar")
        {
            daopedido.Cancelarpedido(pedido2);
            GV_pedidocarrito.DataBind();

        }
    }
    protected void IB_recargar0_Click(object sender, ImageClickEventArgs e)
    {
        GV_pedidocarrito.DataBind();
    }
    protected void IB_recargar1_Click(object sender, ImageClickEventArgs e)
    {
        GV_pedidocarrito0.DataBind();
    }

    protected void GV_pedidocarrito0_RowCommand(object sender, GridViewCommandEventArgs e){
        DAOPedido daop = new DAOPedido();
        Pedido pedido4 = new Pedido();
        GridViewRow fila = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
        pedido4.Id_pedido = int.Parse(e.CommandArgument.ToString());
        pedido4.Comentario_cliente = ((TextBox)fila.FindControl("TBX_comentarioaliado")).Text; ;
        if (e.CommandName == "Guardar"){
            daop.guardarcomentariocliente(pedido4);
            GV_pedidocarrito0.DataBind();
        }else if (e.CommandName == "Generar"){
           int idpedidofactura = int.Parse(e.CommandArgument.ToString());
            

}
    }//
   
}
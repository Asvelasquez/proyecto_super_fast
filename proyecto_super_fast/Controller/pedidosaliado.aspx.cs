using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_pedidosaliado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            if (((Usuario)Session["user"]).Id_rol != 2)
            {
                Response.Redirect("AccesoDenegado.aspx");
            }

        }
        else
        {
            Response.Redirect("AccesoDenegado.aspx");
        }

        
    }

    protected void IB_recargar_Click(object sender, ImageClickEventArgs e)
    {
        GV_pedidos.DataBind();       
    }
    protected void IB_recargar1_Click(object sender, ImageClickEventArgs e)
    {
        GV_pedidosterminado.DataBind();
    }
    

    protected void GV_pedidos_RowDataBound(object sender, GridViewRowEventArgs e){
        int rowcount = GV_pedidos.Rows.Count;
        if (rowcount == 0){
            LB_notienespedidos.Visible = true;
        }else{
            LB_notienespedidos.Visible = false;
        }
        Pedido pedido = (Pedido)e.Row.DataItem;
        if (e.Row.FindControl("GV_Compras") != null){
            ((GridView)e.Row.FindControl("GV_Compras")).DataSource = pedido.Compras;
            ((GridView)e.Row.FindControl("GV_Compras")).DataBind();
        }
    }
    
    protected void GV_pedidosterminado_RowDataBound(object sender, GridViewRowEventArgs e){
        Pedido pedido = (Pedido)e.Row.DataItem;
        int rowcount = GV_pedidosterminado.Rows.Count;
        if (rowcount == 0){
            LB_Notienepedidosterminados.Visible = true;
        } else {
            LB_Notienepedidosterminados.Visible = false;
        }
        if (e.Row.FindControl("GV_Compras1") != null){
            ((GridView)e.Row.FindControl("GV_Compras1")).DataSource = pedido.Compras;
            ((GridView)e.Row.FindControl("GV_Compras1")).DataBind();
        }
    }
  

    protected void DDL_Categoria_SelectedIndexChanged(object sender, EventArgs e)
    {
        DAOPedido pedido3 = new DAOPedido();
        Pedido pedido4 = new Pedido();
        DropDownList opciones = (DropDownList)sender;
        GridViewRow fila = (GridViewRow)opciones.Parent.Parent;
        int pedido = int.Parse(((Label)fila.FindControl("L_Pedido")).Text);
        pedido4.Id_pedido = pedido;
        
        //hacer el update        
        string idseleccion = opciones.SelectedValue;
        pedido3.actualizarPedido(pedido4, int.Parse(idseleccion));
        GV_pedidos.DataBind();//

    }

    protected void DDL_Categoria1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DAOPedido pedido3 = new DAOPedido();
        Pedido pedido4 = new Pedido();
        DropDownList opciones = (DropDownList)sender;
        GridViewRow fila = (GridViewRow)opciones.Parent.Parent;
        int pedido = int.Parse(((Label)fila.FindControl("L_Pedido1")).Text);
        pedido4.Id_pedido = pedido;

        //hacer el update        
        string idseleccion = opciones.SelectedValue;
        pedido3.actualizarPedido(pedido4, int.Parse(idseleccion));
        GV_pedidos.DataBind();//

    }



    protected void GV_pedidos_RowCommand(object sender, GridViewCommandEventArgs e) {
        DAOPedido daop = new DAOPedido();
        Pedido pedido4 = new Pedido();
        GridViewRow fila = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
        pedido4.Id_pedido = int.Parse(e.CommandArgument.ToString());
        pedido4.Comentario_aliado = ((TextBox)fila.FindControl("TBX_comentarioaliado")).Text; ;
        if (e.CommandName == "Guardar") {
            daop.guardarcomentario(pedido4);
            GV_pedidos.DataBind();
        }
    }



    protected void GV_pedidosterminado_RowCommand(object sender, GridViewCommandEventArgs e)
    {
         DAOPedido daop = new DAOPedido();
        Pedido pedido4 = new Pedido();
        GridViewRow fila = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
        pedido4.Id_pedido = int.Parse(e.CommandArgument.ToString());
        pedido4.Comentario_aliado = ((TextBox)fila.FindControl("TBX_comentarioaliado")).Text; ;
        if (e.CommandName == "Guardar") {
            daop.guardarcomentario(pedido4);
            GV_pedidos.DataBind();
        }
    }
}
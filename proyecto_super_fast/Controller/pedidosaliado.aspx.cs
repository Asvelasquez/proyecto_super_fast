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

    

    protected void GV_pedidos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        
    }

    protected void GV_pedidos_RowCommand1(object sender, GridViewCommandEventArgs e)
    {

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
}
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
}
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

  

    protected void GV_pedidos_RowCommand(object sender, GridViewCommandEventArgs e)
    {
       
        
    }

  

    protected void GV_pedidos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
       
        if (e.Row.FindControl("DDL_Categoria") !=null)
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Eror')</script>");
        }
        //       Pedido pedido = new Pedido();
        //       Estado_pedido estado_ped = new Estado_pedido();
        //       pedido.Estado_id = int.Parse(DDL_Categoria);
        //       FindControl("DDL_Categoria");
        //       DropDownList ddl = FindControl("", DropDownList) as DropDownList;

        //       var check = row.FindControl("chkId") as CheckBox;

        //if(check != null && check.Checked)
        //{ya voy inge
        //	//codigo
        //}
    }
}
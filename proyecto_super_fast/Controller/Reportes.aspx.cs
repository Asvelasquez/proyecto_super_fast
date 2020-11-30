using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Reportes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBox1.Text = pedidosclientes;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int factura = int.Parse(TextBox1.Text);
        CRS_Facturas.ReportDocument.SetDataSource(generarFactura(factura));
        CRV_Factura.ReportSource = CRS_Facturas;
        CRV_Factura.Visible = true;
    }

    protected SuministroInformacion generarFactura(int facturaId)
    {
        SuministroInformacion informe = new SuministroInformacion();
        Pedido factura = new DAOPedido().obtenerFactura(facturaId);

        DataTable datosFinal = informe.Factura;
        DataRow fila;

        foreach (var item in factura.Compras)
        {
            fila = datosFinal.NewRow();
            fila["No"] = factura.Id_pedido;
            fila["Fecha"] = factura.Fecha;
            fila["NombreCliente"] = factura.Nombre_cliente;
            fila["NombreProducto"] = item.Nombreprodet;
            fila["Cantidad"] = item.Cantidad;
            fila["ValorUnitario"] = item.V_unitario;
            fila["ValorTotal"] = item.V_total;

            datosFinal.Rows.Add(fila);
        }
        return informe;
    }//
    protected void GV_pedidocarrito0_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        Pedido pedido = (Pedido)e.Row.DataItem;
        int rowcount = GV_pedidocarrito0.Rows.Count;
        if (rowcount == 0)
        {
            LB_historial.Visible = true;
        }
        else
        {
            LB_historial.Visible = false;
        }
        if (e.Row.FindControl("GV_detallespedido0") != null)
        {
            ((GridView)e.Row.FindControl("GV_detallespedido0")).DataSource = pedido.Compras;
            ((GridView)e.Row.FindControl("GV_detallespedido0")).DataBind();
        }
    }//
    protected void GV_pedidocarrito0_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        DAOPedido daop = new DAOPedido();
        Pedido pedido4 = new Pedido();
      //  GridViewRow fila = (GridViewRow)(((ImageButton)e.CommandSource).NamingContainer);
        pedido4.Id_pedido = int.Parse(e.CommandArgument.ToString());
       // pedido4.Comentario_cliente = ((TextBox)fila.FindControl("TBX_comentarioaliado")).Text; ;
       if (e.CommandName == "Generar")
        {
            ////int idpedidofactura = 
            int factura = int.Parse(e.CommandArgument.ToString());
            CRS_Facturas.ReportDocument.SetDataSource(generarFactura(factura));
            CRV_Factura.ReportSource = CRS_Facturas;
            CRV_Factura.Visible = true;
        }
    }//
    protected void IB_recargar1_Click(object sender, ImageClickEventArgs e)
    {
        GV_pedidocarrito0.DataBind();
    }//

}
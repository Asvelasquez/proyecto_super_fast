using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ReporteVentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
       // CRS_Ventas.ReportDocument.SetDataSource(generarFactura(factura));
        CRV_Ventas.ReportSource = CRS_Ventas;
        CRV_Ventas.Visible = true;
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
        fila = datosFinal.NewRow();
        fila["NombreProducto"] = "Domicilio";
        fila["Cantidad"] = "1";
        fila["ValorUnitario"] = "3000";
        fila["ValorTotal"] = "3000";

        datosFinal.Rows.Add(fila);
        return informe;
    }//
}
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
        CRS_Ventas.ReportDocument.SetDataSource(obtenerInformacion());
        CRV_Ventas.ReportSource = CRS_Ventas;
        CRV_Ventas.Visible = true;
    }
    protected SuministroInformacion obtenerInformacion()
    {

        SuministroInformacion informe = new SuministroInformacion();
      //  DateTime fechaInicio = DateTime.Parse(TB_FechaInicio.Text);
       // DateTime fechaFin = DateTime.Parse(TB_FechaFin.Text);
        List<Producto> listaProductos = new List<Producto>();

        List<Detalle_pedido> lista = new DAOPedido().productosVendidosXFecha(/*fechaInicio, fechaFin*/);
        var prod = lista.GroupBy(x => (x.Nombreprodet)).Select(grp => grp.ToList()).ToList();

        foreach (var item in prod)
        {
            List<Detalle_pedido> detalle = item;
            Producto nuevo = new Producto();
            nuevo.Nombre_producto = detalle.First().Nombreprodet;
            nuevo.Cantidad = detalle.Sum(x => x.Cantidad);
            nuevo.Id = detalle.First().Producto_id;
            nuevo.Precio_producto = detalle.Average(x => x.V_unitario);

            listaProductos.Add(nuevo);
        }

        DataTable datosFinal = informe.Ventas;
        DataRow fila;

        foreach (var item in listaProductos)
        {
            fila = datosFinal.NewRow();
            fila["ProductoId"] = item.Id;
            fila["NombreProducto"] = item.Nombre_producto;
            fila["Cantidad"] = item.Cantidad;
            fila["NombreAdmin"] = item.Nombre_aliado;
            datosFinal.Rows.Add(fila);
        }

        return informe;
    }
}
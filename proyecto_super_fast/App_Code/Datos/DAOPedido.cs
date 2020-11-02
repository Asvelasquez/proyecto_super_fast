using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOPedido
/// </summary>
public class DAOPedido
{
    public void insertPedido(Pedido pedido2)
    {
        using (var db = new Mapeo())
        {
            db.pedido1.Add(pedido2);
            db.SaveChanges();
        }
    }//
    public List<Pedido> mostrarpedidocarrito(Usuario busqueda)
    {
        return new Mapeo().pedido1.Where(x => x.Correo_cliente == busqueda.Correo && x.Estado_pedido == 0).ToList<Pedido>();
    }
}
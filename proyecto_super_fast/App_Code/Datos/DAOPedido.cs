using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }//
    public void comprarproducto(Pedido pedido5){
        using (var db = new Mapeo())
        {
            Pedido pedidoanterior = db.pedido1.Where(x => x.Id_pedido == pedido5.Id_pedido).First();
           
            pedidoanterior.Estado_pedido = 1;
            pedidoanterior.Cantidad_pedido = pedido5.Cantidad_pedido;
            pedidoanterior.Direccion_cliente = pedido5.Direccion_cliente;
            pedidoanterior.Telefono_cliente = pedido5.Telefono_cliente;
            db.pedido1.Attach(pedidoanterior);
            var entry = db.Entry(pedidoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();

        }//
    }//
  
    public void deletepedido(Pedido pedidoborar)
    {
        using (var db = new Mapeo())
        {
            Pedido pedido8 = db.pedido1.Where(x => x.Id_pedido == pedidoborar.Id_pedido).First();
            db.pedido1.Remove(pedido8);
            db.SaveChanges();
        }
    }//
    public List<Pedido> mostrarproducto(Usuario consulta)
    {
        return new Mapeo().pedido1.Where(x => x.Correo_aliadop == consulta.Correo && x.Estado_pedido==1).ToList<Pedido>();

    }

}
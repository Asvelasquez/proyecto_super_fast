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
    public Pedido insertPedido(Pedido pedido2)
    {
        using (var db = new Mapeo())
        {
            db.pedido1.Add(pedido2);
            db.SaveChanges();
            return pedido2;
        }
    }//


    public Pedido obtenerFactura(Usuario usuariopedido)
    {
         Pedido pedido = new Pedido();
        using (var db = new Mapeo())
        {
         return (from p in db.pedido1
                      join u in db.usuari on p.Cliente_id equals u.Id
                      where p.Cliente_id == usuariopedido.Id

                      select new
                      {
                          p,
                          u,
                          

                      }).ToList().Select(m => new Pedido
                      {
                          Id_pedido = m.p.Id_pedido,
                          Aliado_id = m.p.Aliado_id,
                          Estado_pedido=m.p.Estado_pedido,
                            Valor_total=m.p.Valor_total,
                            Estado_id=m.p.Estado_id,
                          Fecha=m.p.Fecha,
                          Cliente_id=m.p.Cliente_id,


                      }).FirstOrDefault();
        }
       //pedido.Compras= obtenerDetalleFactura(pedido.Id_pedido);
       // return pedido;
    }

    public List<Detalle_pedido> obtenerDetalleFactura(int pedidoId)
    {
        using (var db = new Mapeo())
        {
            return (from dp in db.detpedido
                    join p in db.producto on dp.Producto_id equals p.Id
                  //  where dp.Pedido_id == pedidoId

                    select new
                    {
                        p,
                        dp


                    }).ToList().Select(m => new Detalle_pedido
                    {
                        Nombreprodet=m.p.Nombre_producto,
                       
                        V_unitario=m.dp.V_unitario,
                        Cantidad = m.dp.Cantidad,
                        

                    }).ToList();
        }
    }





    //public List<Pedido>  obtenercarrito(/*int usuariop*/)
    //{
    //    Pedido pedido = new Pedido();
    //    using (var db = new Mapeo())
    //    {
    //     return     (from p in db.pedido1
    //                  join u in db.usuari on p.Cliente_id equals u.Id
    //             //     where p.Cliente_id == usuariop

    //                  select new
    //                  {
    //                      p,
    //                      u,


    //                  }).ToList().Select(m => new Pedido
    //                  {
    //                      Cliente_id = m.p.Cliente_id,
    //                      Fecha = m.p.Fecha,


    //                  }).ToList();
    //    }

    //  //  pedido.Compras = obtenerDetalleFactura(pedido.Id_pedido);

    //    //return  pedido;
    //}

    //public List<Detalle_pedido> obtenerDetalleFactura(/*int pedidoId*/)
    //{
    //    using (var db = new Mapeo())
    //    {
    //        return (from dp in db.detpedido
    //                join p in db.producto on dp.Producto_id equals p.Id
    //              //  where dp.Pedido_id == pedidoId

    //                select new
    //                {
    //                    p,
    //                    dp


    //                }).ToList().Select(m => new Detalle_pedido
    //                {

    //                    Nombre_producto = m.p.Nombre_producto,
    //                    Cantidad = m.dp.Cantidad,
    //                    V_unitario = m.dp.V_unitario

    //                }).ToList();
    //    }
    //}
    public List<Detalle_pedido> mostrarpedidoaliado()
    {
        using (var db = new Mapeo())
        {
            return (from p in db.producto
                    join dp in db.detpedido on p.Id equals dp.Producto_id

                    select new
                    {
                        dp,
                        p,
                        

                    }).ToList().Select(m => new Detalle_pedido
                    {

                        Pedido_id = m.dp.Pedido_id,
                        Id_dpedido = m.dp.Id_dpedido,
                        Producto_id = m.dp.Producto_id,
                        Cantidad = m.dp.Cantidad,
                        Descripcion = m.p.Descripcion_producto,
                        V_unitario = m.dp.V_unitario,
                        V_total = m.dp.V_total,
                        Nombreprodet=m.p.Nombre_producto,
                        Especprodaliado=m.dp.Descripcion
                       


                    }).ToList();
        }


        //  return new Mapeo().pedido1.Where(x =>  x.Estado_pedido == 0).ToList<Pedido>();
    }//
    public void comprarproducto(Pedido pedido5 ){
        using (var db = new Mapeo())
        {
            Pedido pedidoanterior = db.pedido1.Where(x => x.Id_pedido == pedido5.Id_pedido).First();
            
            pedidoanterior.Estado_pedido = 1;           
            db.pedido1.Attach(pedidoanterior);
            var entry = db.Entry(pedidoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();

        }//
    }//
    //
    public void comprarproductodetalle(Detalle_pedido de_pedido5)
    {
        using (var db = new Mapeo()){
            Detalle_pedido dpedidoanterior = db.detpedido.Where(x => x.Id_dpedido == de_pedido5.Id_dpedido).First();

          
            dpedidoanterior.Cantidad= de_pedido5.Cantidad;
            dpedidoanterior.Direccion_cliente = de_pedido5.Direccion_cliente;
            dpedidoanterior.Telefono_cliente = de_pedido5.Telefono_cliente;
            db.detpedido.Attach(dpedidoanterior);
            var entry = db.Entry(dpedidoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();

        }//
    }//
     //

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
        return new Mapeo().pedido1.Where(x => x.Comentario_aliado == consulta.Correo && x.Estado_pedido==1).ToList<Pedido>();

    }

}
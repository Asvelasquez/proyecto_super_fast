﻿using System;
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

    

    public  List <Pedido> obtenerPedidoUsuario(Usuario usuariopedido)
    {
         List<Pedido> pedido = new List <Pedido>();
        using (var db = new Mapeo()){
         pedido= (from p in db.pedido1
                      join u in db.usuari on p.Cliente_id equals u.Id
                      where p.Cliente_id == usuariopedido.Id
                      select new {
                          p,
                          u,
                      }).ToList().Select(m => new Pedido
                      {
                          Id_pedido = m.p.Id_pedido,
                          Aliado_id = m.p.Aliado_id,
                          Estado_pedido=m.p.Estado_pedido,
                            Valor_total=m.p.Valor_total,
                            Estado_id=m.p.Estado_id,
                            Nombre_estado_ped=m.p.Nombre_estado_ped,
                          Fecha=m.p.Fecha,
                          Cliente_id=m.p.Cliente_id,
                      }).ToList();
        }
        foreach (var item in pedido){
            item.Compras = obtenerDetalleFactura(item.Id_pedido);
        }
         return pedido;
    }

    public List<Detalle_pedido> obtenerDetalleFactura(int pedidoId)
    {
        using (var db = new Mapeo()){
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

    
    public void actualizarPedido(Pedido pedido2, int estadopedido2)
    {
        using (var db = new Mapeo())
        {
            Pedido pedidoanterior = db.pedido1.Where(x => x.Id_pedido == pedido2.Id_pedido).First();
            pedidoanterior.Estado_id = estadopedido2 ;
            
            db.pedido1.Attach(pedidoanterior);
            var entry = db.Entry(pedidoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }//


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
    
    /// /////////////////////////////////obtener pedido 
    
    public List<Pedido> obtenerEstadoPedido(){
        List<Pedido> pedido = new List<Pedido>();
        using (var db = new Mapeo()){
            pedido= (from ped in db.pedido1
                    join p in db.estpedido on ped.Estado_id equals p.Id
                    //  where dp.Pedido_id == pedidoId
                    where ped.Estado_id != 5 && ped.Estado_pedido==1
                    select new
                    {
                        p,
                        ped

                    }).ToList().Select(m => new Pedido
                    {
                        Id_pedido = m.ped.Id_pedido,
                        Aliado_id = m.ped.Aliado_id,
                        Nombre_estado_ped = m.p.Nombre,
                        Cliente_id=m.ped.Cliente_id,
                        Comentario_aliado=m.ped.Comentario_aliado,
                        Comentario_cliente=m.ped.Comentario_cliente,
                        Domiciliario_id=m.ped.Domiciliario_id,
                        Estado_id=m.ped.Estado_id,
                        Estado_pedido=m.ped.Estado_pedido,
                        Fecha=m.ped.Fecha,                        
                        Valor_total=m.ped.Valor_total
                        
                    }).ToList();
        }
        foreach (var item in pedido)
        {
            item.Compras = mostrarpedidoaliado(item.Id_pedido);
        }
        return pedido;
    }
    public List<Detalle_pedido> mostrarpedidoaliado(int idpedido){
        using (var db = new Mapeo()){
            return (from p in db.producto
                    join dp in db.detpedido on p.Id equals dp.Producto_id
                    where dp.Pedido_id==idpedido
                    select new{
                        dp,
                        p,
                    }).ToList().Select(m => new Detalle_pedido
                    {                      
                        Pedido_id=m.dp.Pedido_id,
                        Id_dpedido=m.dp.Id_dpedido,
                        Direccion_cliente=m.dp.Direccion_cliente,
                        Telefono_cliente=m.dp.Telefono_cliente,
                        Producto_id = m.dp.Producto_id,
                        Cantidad = m.dp.Cantidad,
                        Descripcion = m.dp.Descripcion,
                        V_unitario = m.dp.V_unitario,
                        V_total = m.dp.V_total,
                        Nombreprodet=m.p.Nombre_producto,
                        Especprodaliado=m.p.Descripcion_producto
                    }).ToList();
        }
        //  return new Mapeo().pedido1.Where(x =>  x.Estado_pedido == 0).ToList<Pedido>();
    }//
     /////////////////////////////////cierre obtener pedido 

    ///////////////////
    public List<Pedido> obtenerEstadoPedidoterminado(){
        List<Pedido> pedido = new List<Pedido>();
        using (var db = new Mapeo()){
            pedido = (from ped in db.pedido1
                      join p in db.estpedido on ped.Estado_id equals p.Id
                      where ped.Estado_id == 5 && ped.Estado_pedido == 1
                      select new{
                          p,
                          ped
                      }).ToList().Select(m => new Pedido
                      {
                          Id_pedido = m.ped.Id_pedido,
                          Aliado_id = m.ped.Aliado_id,
                          Nombre_estado_ped = m.p.Nombre,
                          Cliente_id = m.ped.Cliente_id,
                          Comentario_aliado = m.ped.Comentario_aliado,
                          Comentario_cliente = m.ped.Comentario_cliente,
                          Domiciliario_id = m.ped.Domiciliario_id,
                          Estado_id = m.ped.Estado_id,
                          Estado_pedido = m.ped.Estado_pedido,
                          Fecha = m.ped.Fecha,
                          Valor_total = m.ped.Valor_total

                      }).ToList();
        }
        foreach (var item in pedido){
            item.Compras = mostrarpedidoaliadoterminado(item.Id_pedido);
        }
        return pedido;
    }
    public List<Detalle_pedido> mostrarpedidoaliadoterminado(int idpedido){
        using (var db = new Mapeo()){
            return (from p in db.producto
                    join dp in db.detpedido on p.Id equals dp.Producto_id
                    where dp.Pedido_id == idpedido
                    select new{
                        dp,
                        p,
                    }).ToList().Select(m => new Detalle_pedido{
                        Pedido_id = m.dp.Pedido_id,
                        Id_dpedido = m.dp.Id_dpedido,
                        Direccion_cliente = m.dp.Direccion_cliente,
                        Telefono_cliente = m.dp.Telefono_cliente,
                        Producto_id = m.dp.Producto_id,
                        Cantidad = m.dp.Cantidad,
                        Descripcion = m.dp.Descripcion,
                        V_unitario = m.dp.V_unitario,
                        V_total = m.dp.V_total,
                        Nombreprodet = m.p.Nombre_producto,
                        Especprodaliado = m.p.Descripcion_producto
                    }).ToList();
        }
        //  return new Mapeo().pedido1.Where(x =>  x.Estado_pedido == 0).ToList<Pedido>();
    }//
     /////////////////

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
    //
    public void guardarcomentario(Pedido pedido2)
    {
        using (var db = new Mapeo())
        {
            Pedido comentarioanterior = db.pedido1.Where(x => x.Id_pedido == pedido2.Id_pedido).First();
            comentarioanterior.Comentario_aliado = pedido2.Comentario_aliado;
            

            db.pedido1.Attach(comentarioanterior);
            var entry = db.Entry(comentarioanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
           

        }
    }

}
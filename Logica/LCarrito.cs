﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Data;
namespace Logica{

    public class LCarrito{
        UMac datos1 = new UMac();
        //
        public UMac LGV_pedidocarrito(UPedido pedido2,String comandname){
            DAOPedido daopedido = new DAOPedido();
            if (comandname == "Cancelar"){
                daopedido.Cancelarpedido(pedido2);                
                datos1.Url="Carrito.aspx";
            }
            return datos1;
        }
        //
        public List<UPedido> Lmostrarpreciototal1(int idusuario){
            DAOPedido dpedido = new DAOPedido();
            List<UPedido> pedido3 = new List<UPedido>();
            //List<UDetalle_pedido> detallepedido3 = new List<UDetalle_pedido>();
            //int idusuario = ((UUsuario)Session["user"]).Id;
            return pedido3 = dpedido.preciototal(idusuario);
            //double total = 0;
            //int idpedido8 = 0;
            //foreach (var item in pedido3)
            //{
            //    idpedido8 = item.Id_pedido;
            //    detallepedido3 = dpedido.precioTotal2(idpedido8);
            //    foreach (var item2 in detallepedido3)
            //    {
            //        total += item2.V_total;
            //    }
            //}
            //return total.ToString();
        }
        //
        public string Lmostrarpreciototal(List<UPedido> pedido3) {
            DAOPedido dpedido = new DAOPedido();
            //List<UPedido> pedido3 = new List<UPedido>();
            List<UDetalle_pedido> detallepedido3 = new List<UDetalle_pedido>();
            //int idusuario = ((UUsuario)Session["user"]).Id;
            //pedido3 = dpedido.preciototal(idusuario);
            double total = 0;
            int idpedido8 = 0;
            foreach (var item in pedido3){
                idpedido8 = item.Id_pedido;
                detallepedido3 = dpedido.precioTotal2(idpedido8);
                foreach (var item2 in detallepedido3){
                    total += item2.V_total;
                }
            }
            return total.ToString();
        }
        //
        public List<UPedido> Lmostrarpreciodomicilio(int idusuario){
            DAOPedido dpedido = new DAOPedido();
            List<UPedido> pedido3 = new List<UPedido>();
           return pedido3 = dpedido.PedidosTotal(idusuario);   
        }
        //
        public UMac LBTN_comprar(int idusuario, UDetalle_pedido detapedido4, UPedido pedido4){
            DAOPedido dpedido = new DAOPedido();
            List<UPedido> pedido3 = new List<UPedido>();
            //UPedido pedido4 = new UPedido();
           // UDetalle_pedido detapedido4 = new UDetalle_pedido();
            pedido3 = dpedido.pedidoscomprar(idusuario);
           // pedido4.Valor_total = double.Parse(TBX_total.Text);
            //detapedido4.Telefono_cliente = TBX_telefono1.Text;
            //detapedido4.Direccion_cliente = TBX_direccion1.Text;
            //  int total = 0;68/64
            foreach (var item in pedido3){
                dpedido.actualizarcomprar(item.Id_pedido, pedido4);
                dpedido.actualizardatosentrega(item.Id_pedido, detapedido4);
            }
           datos1.Url="Carrito.aspx";
            return datos1;
        }
        //
    }
    //
}

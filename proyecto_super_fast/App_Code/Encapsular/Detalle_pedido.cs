﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Detalle_pedido
/// </summary>
/// 
/// 
/*
 *   id_dpedido integer NOT NULL DEFAULT nextval('informacion.detalle_pedido_id_dpedido_seq'::regclass),
    pedido_id integer NOT NULL,
    producto_id integer NOT NULL,
    cantidad integer NOT NULL,
    descripcion text COLLATE pg_catalog."default" NOT NULL,
    v_unitario double precision NOT NULL,
    v_total double precision NOT NULL,
 */

[Serializable]
[Table("detalle_pedido", Schema = "informacion")]

public class Detalle_pedido
{
    private int id_dpedido;
    private int pedido_id;
    private int producto_id;
    private int cantidad;
    private string descripcion;
    private double v_unitario;
    private double v_total;
    private string direccion_cliente;
    private string telefono_cliente;
    private string nombreprodet;
    private string especprodaliado;
    


    [Key]
    [Column("id_dpedido")]
    public int Id_dpedido { get => id_dpedido; set => id_dpedido = value; }
    [Column("pedido_id")]
    public int Pedido_id { get => pedido_id; set => pedido_id = value; }
    [Column("producto_id")]
    public int Producto_id { get => producto_id; set => producto_id = value; }
    [Column("cantidad")]
    public int Cantidad { get => cantidad; set => cantidad = value; }
    [Column("descripcion")]
    public string Descripcion { get => descripcion; set => descripcion = value; }
    [Column("v_unitario")]
    public double V_unitario { get => v_unitario; set => v_unitario = value; }
    [Column("v_total")]
    public double V_total { get => v_total; set => v_total = value; }
    [Column("direccion_cliente")]
    public string Direccion_cliente { get => direccion_cliente; set => direccion_cliente = value; }
    [Column("telefono_cliente")]
    public string Telefono_cliente { get => telefono_cliente; set => telefono_cliente = value; }

    [NotMapped]
    public string Nombreprodet { get => nombreprodet; set => nombreprodet = value; }

    [NotMapped]
    public string Especprodaliado { get => especprodaliado; set => especprodaliado = value; }
}
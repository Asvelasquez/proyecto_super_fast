using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Pedido
/// </summary>
/*
 id_pedido integer NOT NULL DEFAULT nextval('informacion.pedido_id_pedido_seq'::regclass),
    nombre_producto text COLLATE pg_catalog."default" NOT NULL,
    especificacion_pedido text COLLATE pg_catalog."default" NOT NULL,
    descripcion_producto text COLLATE pg_catalog."default" NOT NULL,
    precio_pedido double precision NOT NULL,
    cantidad_pedido integer NOT NULL,
    estado_pedido integer NOT NULL,
    correo_cliente text COLLATE pg_catalog."default" NOT NULL,
    nombre_clientec text COLLATE pg_catalog."default" NOT NULL,
    direccion_cliente text COLLATE pg_catalog."default" NOT NULL,
    telefono_cliente text COLLATE pg_catalog."default" NOT NULL,
    correo_aliadop text COLLATE pg_catalog."default" NOT NULL,
    actividad_comercialp text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pk_informacion_pedido PRIMARY KEY (id_pedido)
 */
[Serializable]
[Table("pedido", Schema = "informacion")]
public class Pedido
{
    private int id_pedido;
    private string nombre_producto;
    private string especificacion_pedido;
    private string descripcion_producto;
    private double precio_pedido;
    private int cantidad_pedido;
    private int estado_pedido;
    private string correo_cliente;
    private string nombre_cliente;
    private string direccion_cliente;
    private string telefono_cliente;
    private string correo_aliadop;
    private string actividad_comercialp;

    [Key]
    [Column("id_pedido")]
    public int Id_pedido { get => id_pedido; set => id_pedido = value; }    
    [Column("nombre_producto")]
    public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
    [Column("especificacion_pedido")]
    public string Especificacion_pedido { get => especificacion_pedido; set => especificacion_pedido = value; }
    [Column("descripcion_producto")]
    public string Descripcion_producto { get => descripcion_producto; set => descripcion_producto = value; }
    [Column("precio_pedido")]
    public double Precio_pedido { get => precio_pedido; set => precio_pedido = value; }
    [Column("cantidad_pedido")]
    public int Cantidad_pedido { get => cantidad_pedido; set => cantidad_pedido = value; }
    [Column("estado_pedido")]
    public int Estado_pedido { get => estado_pedido; set => estado_pedido = value; }
    [Column("correo_cliente")]
    public string Correo_cliente { get => correo_cliente; set => correo_cliente = value; }
    [Column("nombre_clientec")]
    public string Nombre_clientec { get => nombre_cliente; set => nombre_cliente = value; }
    [Column("direccion_cliente")]
    public string Direccion_cliente { get => direccion_cliente; set => direccion_cliente = value; }
    [Column("telefono_cliente")]
    public string Telefono_cliente { get => telefono_cliente; set => telefono_cliente = value; }
    [Column("correo_aliadop")]
    public string Correo_aliadop { get => correo_aliadop; set => correo_aliadop = value; }
    [Column("actividad_comercialp")]
    public string Actividad_comercialp { get => actividad_comercialp; set => actividad_comercialp = value; }
}
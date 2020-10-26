using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Producto
/// </summary>
/*
  id integer NOT NULL DEFAULT nextval('informacion.productos_id_seq'::regclass),
    nombre_producto text COLLATE pg_catalog."default" NOT NULL,
    descripcion_producto text COLLATE pg_catalog."default" NOT NULL,
    precio_producto money NOT NULL,
    imagen_producto1 text COLLATE pg_catalog."default" NOT NULL,
    imagen_producto2 text COLLATE pg_catalog."default",
    CONSTRAINT pk_informacion_producto PRIMARY KEY (id)
     * */
[Serializable]
[Table("productos", Schema = "informacion")]
public class Producto{
    private int id;
    private string nombre_producto;
    private string descripcion_producto;    
    private double precio_producto;
    private string imagen_producto1;
    private string imagen_producto2;
    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("nombre_producto")]
    public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
    [Column("descripcion_producto")]
    public string Descripcion_producto { get => descripcion_producto; set => descripcion_producto = value; }
    [Column("precio_producto")]
    public double Precio_producto { get => precio_producto; set => precio_producto = value; }
    [Column("imagen_producto1")]
    public string Imagen_producto1 { get => imagen_producto1; set => imagen_producto1 = value; }
    [Column("imagen_producto2")]
    public string Imagen_producto2 { get => imagen_producto2; set => imagen_producto2 = value; }
}
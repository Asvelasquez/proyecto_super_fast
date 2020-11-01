﻿using System;
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
    imagen_producto1 text COLLATE pg_catalog."default" NOT NULL,
    imagen_producto2 text COLLATE pg_catalog."default",
   ----- precio_producto double precision NOT NULL,
    estado_producto integer NOT NULL,
    correo_aliado text COLLATE pg_catalog."default" NOT NULL,
    nombre_aliado text COLLATE pg_catalog."default" NOT NULL,
     actividad_comercial text COLLATE pg_catalog."default" NOT NULL,
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
    private int estado_producto;
    private string correo_aliado;
    private string nombre_aliado;
    private string actividad_comercial;
    
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
    [Column("estado_producto")]
    public int Estado_producto { get => estado_producto; set => estado_producto = value; }
    [Column("correo_aliado")]
    public string Correo_aliado { get => correo_aliado; set => correo_aliado = value; }
    [Column("nombre_aliado")]
    public string Nombre_aliado { get => nombre_aliado; set => nombre_aliado = value; }
    [Column("actividad_comercial")]
    public string Actividad_comercial { get => actividad_comercial; set => actividad_comercial = value; }
  


   
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Rol
/// </summary>
[Serializable]
[Table("rol", Schema = "usuario")]
public class Rol
{
    /*id_rol integer NOT NULL DEFAULT nextval('informacion.rol_id_rol_seq'::regclass),
    tipo text COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT "PK_id_rol_informacion" PRIMARY KEY (id_rol)*/

    private int id_rol;
    private string tipo;
    [Key]
    [Column("id_rol")]
    public int Id_rol { get => id_rol; set => id_rol = value; }
    [Column("tipo")]
    public string Tipo { get => tipo; set => tipo = value; }
}
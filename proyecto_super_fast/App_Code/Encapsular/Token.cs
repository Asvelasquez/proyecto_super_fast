using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Token
/// </summary>
[Serializable]
[Table("token_recuperacion", Schema = "seguridad")]

public class Token{
    /*id_recuperacion integer NOT NULL DEFAULT nextval('seguridad.token_recuperacion_id_recuperacion_seq'::regclass),
    user_id integer NOT NULL,
    token text COLLATE pg_catalog."default" NOT NULL,
    creado timestamp without time zone NOT NULL,
    vigencia timestamp without time zone NOT NULL,
    */
    private int id;
    private int userId;
    private string tokenGenerado;
    private DateTime creado;
    private DateTime vigencia;

   /* [Key]
    [Column("id_recuperacion")]
    public int Id { get => id; set => id = value; }
    [Column("user_id")]
    public int UserId { get => userId; set => userId = value; }
    [Column("token")]
    public string TokenGenerado { get => tokenGenerado; set => tokenGenerado = value; }
    [Column("creado")]
    public DateTime Creado { get => creado; set => creado = value; }
    [Column("vigencia")]
    public DateTime Vigencia { get => vigencia; set => vigencia = value; }*/
}
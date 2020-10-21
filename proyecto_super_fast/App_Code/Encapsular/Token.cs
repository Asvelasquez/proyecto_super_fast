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

public class Token
{
   
    private int id;
    private int user_id;
    private string tokeng;
    private DateTime creado;
    private DateTime vigencia;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("user_id")]
    public int User_id { get => user_id; set => user_id = value; }
    [Column("tokeng")]
    public string Tokeng { get => tokeng; set => tokeng = value; }
    [Column("creado")]
    public DateTime Creado { get => creado; set => creado = value; }
    [Column("vigencia")]
    public DateTime Vigencia { get => vigencia; set => vigencia = value; }

}
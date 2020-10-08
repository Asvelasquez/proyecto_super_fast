using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOCliente
/// </summary>
[Serializable]
[Table("cliente", Schema = "informacion")]

public class DAOCliente
{
    public Cliente login(Cliente cliente)
    {
        return new Mapeo().client.Where(x => x.Correo.ToUpper().Equals(cliente.Correo.ToUpper()) && x.Contrasenia.Equals(cliente.Contrasenia)).FirstOrDefault();
    }
    //metodo insertar cliente
    public void insertCliente(Cliente cliente)
    {
        using (var db = new Mapeo())
        {
            db.client.Add(cliente);
            db.SaveChanges();

        }


    }
}
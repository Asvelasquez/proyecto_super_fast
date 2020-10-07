using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOCliente
/// </summary>
public class DAOCliente
{
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
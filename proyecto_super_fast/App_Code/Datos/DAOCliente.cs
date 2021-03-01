using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Utilitarios;
/// <summary>
/// Descripción breve de DAOCliente
/// </summary>

namespace Data
{


public class DAOCliente
{
    public UCliente login(UCliente cliente)
    {
        return new Mapeo().client.Where(x => x.Correo.ToUpper().Equals(cliente.Correo.ToUpper()) && x.Contrasenia.Equals(cliente.Contrasenia)).FirstOrDefault();
    }
    //metodo insertar cliente
    public void insertCliente(UCliente cliente){
        using (var db = new Mapeo())
        {
            db.client.Add(cliente);
            db.SaveChanges();

        }
    }

    public List<UCliente> obtenerCliente()
    {
        using (var db = new Mapeo())
        {
            return (from u in db.client
                    join r in db.rol on u.Rol_id equals r.Id
                    join u2 in db.client on u.Rol_id equals u2.Rol_id
                    select new
                    {
                        u,
                        r.Nombre
                    }).ToList().Select(m => new UCliente
                    {
                        Apellido = m.u.Apellido,
                        Contrasenia = m.u.Contrasenia,
                        Correo = m.u.Correo,
                        Id_cliente = m.u.Id_cliente,
                        Nombre = m.u.Nombre,
                        Nombre_rol = m.Nombre,
                        Direccion = m.u.Direccion,
                        Rol_id = m.u.Rol_id,
                        Telefono = m.u.Telefono
                    }).ToList();
        }
    }
}
}
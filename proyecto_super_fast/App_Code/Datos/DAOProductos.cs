using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOProductos
/// </summary>
public class DAOProductos{
    public void insertProducto(Producto producto2){
        using (var db = new Mapeo()) {
            db.producto.Add(producto2);
            db.SaveChanges();
        }
    }//
    public List<Producto> mostrarproducto(Usuario consulta ){
        return new Mapeo().producto.Where(x =>  x.Correo_aliado == consulta.Correo).ToList<Producto>();
        
    }
   
    public List<Producto> mostrar()
    {
        return new Mapeo().producto.OrderBy(x => x.Id).ToList<Producto>();
    }
}
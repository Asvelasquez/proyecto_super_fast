using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public List<Producto> mostrarproductoinicio()
    {
        return new Mapeo().producto.OrderBy(x => x.Id).ToList<Producto>();

    }
    public List<Producto> mostrarimagenproducto(Usuario consulta)
    {
        return new Mapeo().producto.Where(x => x.Correo_aliado == consulta.Correo).ToList<Producto>();

    }

    public List<Producto> mostrar()
    {
        return new Mapeo().producto.OrderBy(x => x.Id).ToList<Producto>();
    }
    public void updateproducto(Producto producto3){
        using (var db = new Mapeo()){
            Producto productoanterior = db.producto.Where(x => x.Id == producto3.Id).First();
            productoanterior.Nombre_producto = producto3.Nombre_producto;
            productoanterior.Descripcion_producto = producto3.Descripcion_producto;
            productoanterior.Precio_producto = producto3.Precio_producto;
            productoanterior.Imagen_producto1 = producto3.Imagen_producto1;
            productoanterior.Estado_producto = producto3.Estado_producto;
            productoanterior.Correo_aliado = producto3.Correo_aliado;
            productoanterior.Nombre_aliado = producto3.Nombre_aliado;
            productoanterior.Actividad_comercial = producto3.Actividad_comercial;
            db.producto.Attach(productoanterior);

            var entry = db.Entry(productoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }//
}
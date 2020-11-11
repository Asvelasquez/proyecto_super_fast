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

     
        return new Mapeo().producto.Where(x =>  x.Id_aliado == consulta.Id && x.Estado_producto==1).ToList<Producto>();

    }//
    public List<Producto> mostrarproductodesactivado(Usuario consulta)
    {
        return new Mapeo().producto.Where(x => x.Id_aliado == consulta.Id && x.Estado_producto == 2).ToList<Producto>();

    }//
  
    public List<Producto> mostrarproductoinicio(){

        using (var db = new Mapeo())
        {
            return (from p in db.producto
                    join u in db.usuari on p.Id_aliado equals u.Id
                    select new
                    {
                        p,
                        u.Nombre,
                     
                    }).ToList().Select(m => new Producto
                    {
                        Id=m.p.Id,
                        Nombre_producto = m.p.Nombre_producto,
                        Descripcion_producto = m.p.Descripcion_producto,
                        Precio_producto = m.p.Precio_producto,
                        Imagen_producto1 = m.p.Imagen_producto1,
                        Estado_producto = m.p.Estado_producto,
                        Id_aliado = m.p.Id_aliado,
                        Nombre_aliado = m.Nombre,
                       
                        
                    }).ToList();
        }

        //return new Mapeo().producto.OrderBy(x => x.Id).ToList<Producto>();
    }
    ///////////
    public List<Producto> mostrarproductoiniciobusqueda(String busqueda)
    {
        return new Mapeo().producto.Where(x => x.Nombre_producto == busqueda).ToList();
    }
    ///////////
   
        
        /// <returns></returns>
    public List<Usuario> mostrarproductoinicioactividad(String busqueda)
    {


        return new Mapeo().usuari.Where(x => x.Actividadcomercial == busqueda).ToList();
    }

  
    //////
    public List<Producto> mostrarimagenproducto(Usuario consulta)
    {
        return new Mapeo().producto.Where(x => x.Id == consulta.Id).ToList<Producto>();

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
            db.producto.Attach(productoanterior);

            var entry = db.Entry(productoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }//
    public void Desactivarproducto(Producto producto3)
    {
        using (var db = new Mapeo())
        {
            Producto productoanterior = db.producto.Where(x => x.Id == producto3.Id).First();
            
            productoanterior.Estado_producto =2;
            db.producto.Attach(productoanterior);

            var entry = db.Entry(productoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }//
    public void Activarproducto(Producto producto3)
    {
        using (var db = new Mapeo())
        {
            Producto productoanterior = db.producto.Where(x => x.Id == producto3.Id).First();

            productoanterior.Estado_producto = 1;
            db.producto.Attach(productoanterior);

            var entry = db.Entry(productoanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }//
    public Producto mostrar(int userId)
    {
        return new Mapeo().producto.Where(x => x.Id == userId).First();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utilitarios;
namespace Data{
 public class DAODomiciliario{
    public void insertDomiciliario(UDomiciliario domiciliario){
        using (var db = new Mapeo()){
            db.domiciliari.Add(domiciliario);
            db.SaveChanges();
        }


    }
 }
}
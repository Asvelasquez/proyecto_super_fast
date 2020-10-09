using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAODomiciliario
/// </summary>
public class DAODomiciliario{
    public void insertDomiciliario(Domiciliario domiciliario){
        using (var db = new Mapeo()){
            db.domiciliari.Add(domiciliario);
            db.SaveChanges();
        }


    }
}
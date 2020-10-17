﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>
public class DAOUsuario
{
    public void insertUsuario(Usuario usuario2){
        using (var db = new Mapeo()){
            db.usuari.Add(usuario2);
            db.SaveChanges();
        }
    }

    public Usuario loginusuario(Usuario usuario)
    {
        return new Mapeo().usuari.Where(x => x.Correo.ToUpper().Equals(usuario.Correo.ToUpper()) && x.Contrasenia.Equals(usuario.Contrasenia)).FirstOrDefault();
    }
    public Usuario getUserByUserName(string correo)
    {
        return new Mapeo().usuari.Where(x => x.Correo.ToUpper().Equals(correo.ToUpper())).FirstOrDefault();
    }

    public List<Usuario> mostraraliado() {
        return new Mapeo().usuari.Where(x => x.Id_rol==2).ToList<Usuario>();
    }

    public List<Usuario> mostrardomiciliario()
    {
        return new Mapeo().usuari.Where(x => x.Id_rol == 3).ToList<Usuario>();
    }

}
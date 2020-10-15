using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>
public class DAOUsuario
{
    public void insertUsuario(Usuario usuario){
        using (var db = new Mapeo()){
            db.usuari.Add(usuario);
            db.SaveChanges();
        }
    }

    public Usuario loginusuario(Usuario usuario)
    {
        return new Mapeo().usuari.Where(x => x.Correo.ToUpper().Equals(usuario.Correo.ToUpper()) && x.Contrasennia.Equals(usuario.Contrasennia)).FirstOrDefault();
    }

    public List<Usuario> mostraraliado() {
        return new Mapeo().usuari.Where(x => x.Id_rol==2).ToList<Usuario>();
    }

}
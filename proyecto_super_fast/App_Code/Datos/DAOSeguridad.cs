using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOSeguridad
/// </summary>
public class DAOSeguridad
{
    public void insertarToken(Token token)
    {
        using (var db = new Mapeo())
        {
            db.token.Add(token);
            db.SaveChanges();
        }
    }

    public Token getTokenByUser(int userId)
    {
        return new Mapeo().token.Where(x => x.User_id == userId && x.Vigencia > DateTime.Now).FirstOrDefault();
    }

    public Token getTokenByToken(string token)
    {
        return new Mapeo().token.Where(x => x.Tokeng == token).FirstOrDefault();
    }

    public void updateClave(Usuario usuario)
    {
        using (var db = new Mapeo())
        {
            Usuario usuarioAnterior = db.user.Where(x => x.Id == usuario.Id).First();
            usuarioAnterior.Contrasenia = usuario.Contrasenia;

            db.user.Attach(usuarioAnterior);

            var entry = db.Entry(usuarioAnterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}

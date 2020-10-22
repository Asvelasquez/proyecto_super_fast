using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>
[Serializable]
[Table("usuario", Schema = "informacion")]
public class DAOUsuario
{
    public void insertUsuario(Usuario usuario2){
        using (var db = new Mapeo()){
            db.usuari.Add(usuario2);
            db.SaveChanges();
        }
    }

   //validar correo registrarse 
    public Usuario getCorreoByregistrarse(string correo)
    {
      
        return new Mapeo().usuari.Where(x => (x.Correo.Equals(correo))).FirstOrDefault();
    }
    //envio dinamico clase generarToken dinamico correo
    public Usuario getCorreoByCorreos(string correo)
    {
        return new Mapeo().usuari.Where(x => (x.Correo.Contains(correo))).FirstOrDefault();
    }



    public Usuario loginusuario(Usuario usuario)
    {
        return new Mapeo().usuari.Where(x => x.Correo.ToUpper().Equals(usuario.Correo.ToUpper()) && x.Contrasenia.Equals(usuario.Contrasenia)).FirstOrDefault();
    }
    public Usuario getUserByUserName(string correo)
    {
        return new Mapeo().usuari.Where(x => x.Correo.ToUpper().Equals(correo.ToUpper())).FirstOrDefault();
    }

    public List<Usuario> mostrarsolicitudaliado() {
        return new Mapeo().usuari.Where(x => x.Id_rol == 2 && x.Aprobacion == 0).ToList<Usuario>();
    }

    public List<Usuario> mostrarsolicituddomiciliario()
    {
        return new Mapeo().usuari.Where(x => x.Id_rol == 3 && x.Aprobacion==0).ToList<Usuario>();
    }

    public void aceptarusuario(Usuario usuario){

        using (var db = new Mapeo()){
            Usuario aprobacionanterior = db.usuari.Where(x => x.Id == usuario.Id).First();           
            aprobacionanterior.Aprobacion = 1;
            db.usuari.Attach(aprobacionanterior);      
            var entry = db.Entry(aprobacionanterior);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }

}
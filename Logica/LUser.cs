using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Data;
using System.Web.UI;

namespace Logica
{

     public class LUser
    {
       
        public URespuesta login(UUsuario usuario)
        {
            
            usuario = new DAOUsuario().loginusuario(usuario);
            URespuesta respuesta = new URespuesta();
            if (usuario == null)
            {
                

                 Session["user"] = null;
              respuesta.Mensaje= cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('revise sus credenciales de acceso');window.location=\"Login.aspx\"</script>");
            }
            else
            {

                Session["user"] = usuario;

                MAC conexion = new MAC();
                Acceso acceso = new Acceso();

                acceso.FechaInicio = DateTime.Now;
                acceso.Ip = conexion.ip();
                acceso.Mac = conexion.mac();
                acceso.Session = Session.SessionID;
                acceso.UserId = usuario.Id;

                new DAOSeguridad().insertarAcceso(acceso);
                if (usuario.Id_rol == 1)
                {
                   // Response.Redirect("inicio.aspx");
                    respuesta.Mensaje=("inicio.aspx");
                }
                else
                {
                    if (usuario.Id_rol == 2 && usuario.Aprobacion == 1)
                    {
                       // Response.Redirect("pedidosaliado.aspx");
                        respuesta.Mensaje=("pedidosaliado.aspx");
                    }
                    else if (usuario.Id_rol == 2 && usuario.Aprobacion == 0)
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como aliado, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');window.location.href=\"CerrarSession.aspx\"</script>");
                        return;
                    }
                    if (usuario.Id_rol == 3 && usuario.Aprobacion == 1)
                    {
                        respuesta.Mensaje = ("Domiciliario.aspx");
                       // Response.Redirect("Domiciliario.aspx");
                    }
                    else if (usuario.Id_rol == 3 && usuario.Aprobacion == 0)
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como domiciliario, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');window.location.href=\"CerrarSession.aspx\"</script>");
                        return;
                    }
                    if (usuario.Id_rol == 4 && usuario.Aprobacion == 1)
                    {
                       
                        respuesta.Mensaje=("administrador.aspx");
                    }
                    else if (usuario.Id_rol == 4 && usuario.Aprobacion == 0)
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como administrador, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');window.location.href=\"CerrarSession.aspx\"</script>");
                        return;
                    }
                    if (usuario.Id_rol == 2 && usuario.Aprobacion == 2)
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su solicitud como Aliado ha sido rachazada');window.location.href=\"CerrarSession.aspx\"</script>");
                        return;
                    }
                    if (usuario.Id_rol == 3 && usuario.Aprobacion == 2)
                    {
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su solicitud como Domiciliario ha sido rachazada');window.location.href=\"CerrarSession.aspx\"</script>");
                        return;
                    }
                }

            }
            return respuesta;
        }
    }
}

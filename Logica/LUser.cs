using System;
using Utilitarios;
using Data;

namespace Logica
{

    public class LUser
    {

        public UMac login(UUsuario usuario)
        {
            UMac datos = new UMac();
            MAC mac = new MAC();
            
            datos.Usuario = new DAOUsuario().loginusuario(usuario);
            datos.Fecha_Inicio1 = DateTime.Now;
           
            datos.Ip = mac.ip();
            datos.Mac = mac.mac();


            //if (usuario == null)
            //{
            /* WEB
           
                 Session["user"] = null;
            respuesta.Mensaje = cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('revise sus credenciales de acceso');window.location=\"Login.aspx\"</script>");
           }
            else
            {

            Session["user"] = usuario; WEB
            acceso.Session = Session.SessionID; WEB
             */


            //MAC conexion = new MAC();
            //Acceso acceso = new Acceso();
            //acceso.FechaInicio = DateTime.Now;
            //acceso.Ip = conexion.ip();
            //acceso.Mac = conexion.mac();
           


            datos.User_id = usuario.Id;
           
            new DAOSeguridad().insertarAcceso(datos);
                if (usuario.Id_rol == 1)
                {
                    // Response.Redirect("inicio.aspx");
                     datos.Url = ("inicio.aspx");
                    
                }
                else
                {
                    if (usuario.Id_rol == 2 && usuario.Aprobacion == 1)
                    {
                       // Response.Redirect("pedidosaliado.aspx");
                        
                        datos.Url = ("pedidosaliado.aspx");
                    }

                /*WEB
                    else if (usuario.Id_rol == 2 && usuario.Aprobacion == 0)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como aliado, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');window.location.href=\"CerrarSession.aspx\"</script>");
                    return;
                }
                */
             
                if (usuario.Id_rol == 3 && usuario.Aprobacion == 1)
                    {
                        datos.Url = ("Domiciliario.aspx");
                       // Response.Redirect("Domiciliario.aspx");
                    }
                /* WEB
                else if (usuario.Id_rol == 3 && usuario.Aprobacion == 0)
                {
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como domiciliario, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');window.location.href=\"CerrarSession.aspx\"</script>");
                    return;
                }
                */
                if (usuario.Id_rol == 4 && usuario.Aprobacion == 1)
                    {
                       
                        datos.Url=("administrador.aspx");
                    }
                /*WEB
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
                */
            }
            return datos;
        }
         
          
        //}
    }
}

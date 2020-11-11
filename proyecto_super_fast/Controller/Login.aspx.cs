using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Login : System.Web.UI.Page{
    protected void Page_Load(object sender, EventArgs e)
   {

    }


    protected void LG_Principal_Authenticate(object sender, AuthenticateEventArgs e){
        Usuario usuario = new Usuario();
        usuario.Correo = LG_Principal.UserName;
        usuario.Contrasenia = LG_Principal.Password;
        ClientScriptManager cm = this.ClientScript;
        usuario = new DAOUsuario().loginusuario(usuario);
        if (usuario == null){          
            Session["user"] = null;
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('revise sus credenciales de acceso');window.location=\"Login.aspx\"</script>");
        }
        else{

            Session["user"] = usuario;

            MAC conexion = new MAC();
            Acceso acceso = new Acceso();

            acceso.FechaInicio = DateTime.Now;
            acceso.Ip = conexion.ip();
            acceso.Mac = conexion.mac();
            acceso.Session = Session.SessionID;
            acceso.UserId = usuario.Id;

            new DAOSeguridad().insertarAcceso(acceso);
            if (usuario.Id_rol == 1) { 
                Response.Redirect("inicio.aspx");
                
            }
            else {
                if (usuario.Id_rol == 2 && usuario.Aprobacion==1){
                    Response.Redirect("pedidosaliado.aspx");
                }else{
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como aliado, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');window.location=\"Login.aspx\"</script>");
                   
                    }
                if (usuario.Id_rol == 3 && usuario.Aprobacion == 1){
                    Response.Redirect("Domiciliario.aspx");
                }else{
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como domiciliario, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');</script>");
                    
                }
                if (usuario.Id_rol == 4 && usuario.Aprobacion == 1){
                    Response.Redirect("administrador.aspx");
                } else{
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En este momento no puede iniciar sesion, se esta revisando su solicitud de registro como domiciliario, recibira una respuesta al correo que ingreso en el registro para la aprobacion o no aprobacion para nuestra plataforma');</script>");
                    
                }
                if (usuario.Id_rol == 2 && usuario.Aprobacion == 2){
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su solicitud como Aliado ha sido rachazada');</script>");

                }
                if (usuario.Id_rol == 3 && usuario.Aprobacion == 2){
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Su solicitud como Domiciliario ha sido rachazada');</script>");

                }
            }

        }

    }

    protected void LB_RecuperarContrasenia_Click(object sender, EventArgs e)
    {
        Response.Redirect("GenerarToken.aspx");
    }
}
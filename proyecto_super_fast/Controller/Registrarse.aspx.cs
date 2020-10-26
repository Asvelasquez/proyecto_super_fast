using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Registrarse : System.Web.UI.Page
{
   

    protected void BT_Registrar_Click(object sender, EventArgs e)
    {



        try
        {

            ClientScriptManager cm = this.ClientScript;
            Usuario cliente1 = new Usuario();
            DAOUsuario dAOUsuario = new DAOUsuario();
            cliente1.Nombre = TB_Nombre.Text;
            cliente1.Apellido = TB_Apellido.Text;
            cliente1.Correo = TB_Correo.Text;
            cliente1.Contrasenia = TB_Contrasenia.Text;
            cliente1.Telefono = TB_Telefono.Text;
            cliente1.Direccion = TB_Direccion.Text;
            cliente1.Auditoria = TB_Nombre.Text;
            //cliente1.Auditoria = ((Usuario)Session["user"]).Correo; VA EN ADMINISTRADOR
            int rol1 = 1, aprob = 1;
            cliente1.Id_rol = rol1;
            cliente1.Aprobacion = aprob;
            Usuario validarUsuario = dAOUsuario.getCorreoByregistrarse(TB_Correo.Text);
            new DAOUsuario().getCorreoByregistrarse(TB_Correo.Text);
            if (validarUsuario != null)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('correo registrado,ingrese uno diferente');</script>");
            }
            else
            {
                new DAOUsuario().insertUsuario(cliente1);
                Response.Redirect("Inicio.aspx");
            }
        }
        catch(Exception ex)
        { return; }
        
    }
}
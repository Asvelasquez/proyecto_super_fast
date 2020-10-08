using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void LG_Principal_Authenticate(object sender, AuthenticateEventArgs e)
    {
        Cliente cliente = new Cliente();
        cliente.Correo = LG_Principal.UserName;
        cliente.Contrasenia = LG_Principal.Password;

        cliente = new DAOCliente().login(cliente);
        if (cliente == null)
        {
            ((Label)LG_Principal.FindControl("L_Mensaje")).Text = "Usuario o Clave incorrecto.";
            Session["user"] = null;
        }
        else
        {
            Session["user"] = cliente;
            if (cliente.Rol_id == 1)
                Response.Redirect("Registrarse.aspx");
            else
                Response.Redirect("Inicio.aspx");


        }

    }
}
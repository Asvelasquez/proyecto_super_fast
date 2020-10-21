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

        Usuario cliente1 = new Usuario();
        cliente1.Nombre = TB_Nombre.Text;
        cliente1.Apellido = TB_Apellido.Text;
        cliente1.Correo = TB_Correo.Text;
        cliente1.Contrasenia = TB_Contrasenia.Text;
        cliente1.Telefono = TB_Telefono.Text;
        cliente1.Direccion = TB_Direccion.Text;
        int rol1 = 1, aprob = 1;
        cliente1.Id_rol = rol1;
        cliente1.Aprobacion = aprob;
        new DAOUsuario().insertUsuario(cliente1);
        Response.Redirect("Inicio.aspx");
        try
        {
        }
        catch(Exception ex)
        { return; }
        
    }
}
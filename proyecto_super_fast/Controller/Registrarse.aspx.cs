using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Registrarse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BT_Registrar_Click(object sender, EventArgs e)
    {
    
        try
        {
            Cliente cliente = new Cliente();
            cliente.Nombre = TB_Nombre.Text;
            cliente.Apellido = TB_Apellido.Text;
            cliente.Correo = TB_Correo.Text;
            cliente.Telefono = TB_Telefono.Text;
            cliente.Contrasenia = TB_Contrasenia.Text;
            cliente.Direccion = TB_Direccion.Text;
            new DAOCliente().insertCliente(cliente);
            Response.Redirect("Inicio.aspx");
        }
        catch(Exception ex)
        { return; }
        
    }
}
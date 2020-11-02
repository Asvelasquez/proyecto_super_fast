using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Carrito : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        TBX_nombrecliente.Text = ((Usuario)Session["user"]).Nombre + " " + ((Usuario)Session["user"]).Apellido;
        TBX_direccioncliente.Text= ((Usuario)Session["user"]).Direccion;
        TBX_telefonocliente.Text= ((Usuario)Session["user"]).Telefono;
        //TBX_total2.Text=
        var lista5 = new List<Pedido>();
        foreach (var a in lista5){
            Console.WriteLine();
                
        }
            
        
    }
}
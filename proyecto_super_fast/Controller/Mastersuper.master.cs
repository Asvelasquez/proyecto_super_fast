using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Mastersuper : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!Page.AppRelativeVirtualPath.Contains("Login.aspx"))
        {
            Response.Cache.SetNoStore();
            if (Session["user"] == null)
                Response.Redirect("Login.aspx");
           
            menu();
            
        }       
        else

        {
            sinRol();
            
        }
    }
    protected void menu()
    {
        if (Session["user"] != null)
        {
            switch (((Usuario)Session["user"]).Id_rol)
            {
                case 1:
                    rolCliente();
                    break;
                case 2:
                    rolAliado();
                    break;
                case 3:
                    rolDomiciliario();
                    break;
                case 4:
                    rolAdmin();
                    break;
                default:
                    sinRol();
                    break;
            }

        }
        else
            sinRol();
    }

    protected void rolAdmin()
    {
        M_Admin.Visible = true;
        M_Cliente.Visible = false;
    }

    protected void rolCliente()
    {
        M_Admin.Visible = false;
        M_Cliente.Visible = true;
    }
    protected void rolDomiciliario()
    {
        M_Admin.Visible = false;
        M_Cliente.Visible = false;
    }
    protected void rolAliado()
    {
        M_Admin.Visible = false;
        M_Cliente.Visible = false;
    }
    protected void sinRol()
    {
        M_Admin.Visible = false;
        M_Cliente.Visible = true;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {

    }

    protected void M_Admin_MenuItemClick(object sender, MenuEventArgs e)
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
public partial class View_RecuperarContrasenia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){
        if (Request.QueryString.Count > 0){
            Token token = new DAOSeguridad().getTokenByToken(Request.QueryString[0]);

            if (token == null)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"Login.aspx\"</script>");
            else if (token.Vigencia < DateTime.Now)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"Login.aspx\"</script>");
            else
                Session["user_id"] = token.User_id;
        }

        else
            Response.Redirect("Login.aspx");
    }

    protected void B_Cambiar_Click(object sender, EventArgs e){
        UUsuario usuario = new UUsuario();
        UUsuario usuar = new UUsuario();
        usuar = new DAOUsuario().nuevacontrasenia(usuario);

        usuario.Id = int.Parse(Session["user_id"].ToString());
        usuario.Contrasenia = TB_ConfirmarContrasenia.Text;
     
        new DAOSeguridad().updateClave(usuario);

        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Su contraseña fue actualizada');window.location=\"Login.aspx\"</script>");

    }
}
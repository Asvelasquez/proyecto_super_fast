using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Perfil : System.Web.UI.Page{
    protected void Page_Load(object sender, EventArgs e) {//1
        
            menu();
        mostrar();
        TB_nombreperfila.Visible = false;
        TB_apellidoperfila.Visible = false;
        TB_correoperfila.Visible = false;
        TB_contraseniaperfila.Visible = false;
        TB_direccionperfila.Visible = false;
        TB_telefonoperfila.Visible = false;
        TB_documentoperfila.Visible = false;
        TB_actividadcomercialperfila.Visible = false;
        TB_tipodevehiculoperfila.Visible = false;

    }//1
    protected void menu() {//2
        if (Session["user"] != null) {//3
            switch (((Usuario)Session["user"]).Id_rol) {//4
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
            }//4
        }//3
    }//2
     protected void rolAdmin(){
        //   M_Admin.Visible = false;        
        TB_tipodevehiculoperfil.Visible = false;
        DDLD_tipovehiculo.Visible = false;
        LB_tipodevehiculoperfil.Visible = false;
        LB_actividadcomercial.Visible = false;
        TB_actividadcomercialperfil.Visible = false;
        DDLA_actividadcomercial.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;

     }

     protected void rolCliente(){
        TB_tipodevehiculoperfil.Visible = false;
        DDLD_tipovehiculo.Visible = false;
        LB_tipodevehiculoperfil.Visible = false;
        LB_actividadcomercial.Visible = false;
        TB_actividadcomercialperfil.Visible = false;
        DDLA_actividadcomercial.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;

    }
      protected void rolDomiciliario(){
        TB_tipodevehiculoperfil.Visible = true;
        TB_tipodevehiculoperfila.Visible = true;
        DDLD_tipovehiculo.Visible = true;
        LB_tipodevehiculoperfil.Visible = true;
        LB_actividadcomercial.Visible = false;
        TB_actividadcomercialperfil.Visible = false;
        DDLA_actividadcomercial.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;

    }
      protected void rolAliado(){
        TB_tipodevehiculoperfil.Visible = false;
        DDLD_tipovehiculo.Visible = false;
        LB_tipodevehiculoperfil.Visible = false;
        LB_actividadcomercial.Visible = true;
        TB_actividadcomercialperfil.Visible = true;
        TB_actividadcomercialperfila.Visible = true;
        DDLA_actividadcomercial.Visible = true;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;

    }
    protected void BTN_cancelar_Click(object sender, EventArgs e){
        TB_nombreperfil.Enabled = false;
        TB_apellidoperfil.Enabled = false;
        TB_correoperfil.Enabled = false;
        TB_contraseniaperfil.Enabled = false;
        TB_direccionperfil.Enabled = false;
        TB_telefonoperfil.Enabled = false;
        TB_documentoperfil.Enabled = false;
        TB_tipodevehiculoperfil.Enabled = false;
        BTN_editar.Visible = true;
        


    }
    protected void BTN_editar_Click(object sender, EventArgs e){
        //
        TB_nombreperfila.Visible = true;
        TB_apellidoperfila.Visible = true;
        TB_correoperfila.Visible = true;
        TB_contraseniaperfila.Visible = true;
        TB_direccionperfila.Visible = true;
        TB_telefonoperfila.Visible = true;
        TB_documentoperfila.Visible = true;
        //
        BTN_guardar.Visible = true;
        BTN_cancelar.Visible = true;
        BTN_editar.Visible = false;
        //
        TB_nombreperfila.Text = TB_nombreperfil.Text;
        TB_apellidoperfila.Text = TB_apellidoperfil.Text;
        TB_correoperfila.Text = TB_correoperfil.Text;
        TB_contraseniaperfila.Text = TB_contraseniaperfil.Text;
        TB_direccionperfila.Text = TB_direccionperfil.Text;
        TB_telefonoperfila.Text = TB_telefonoperfil.Text;
        TB_documentoperfila.Text = TB_documentoperfil.Text;
        TB_actividadcomercialperfila.Text = TB_actividadcomercialperfil.Text;
        TB_tipodevehiculoperfila.Text = TB_tipodevehiculoperfil.Text;
        //

    }//
    protected void mostrar(){

        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();

       usuario1= us.mostrar(((Usuario)Session["user"]).Id);
        TB_nombreperfil.Text = usuario1.Nombre;
        TB_apellidoperfil.Text = usuario1.Apellido;
        TB_correoperfil.Text = usuario1.Correo;
        TB_contraseniaperfil.Text = usuario1.Contrasenia;
        TB_direccionperfil.Text = usuario1.Direccion;
        TB_telefonoperfil.Text = usuario1.Telefono;
        TB_documentoperfil.Text = usuario1.Documento;
        TB_tipodevehiculoperfil.Text = usuario1.Tipovehiculo;
        imagen_perfil.AlternateText = usuario1.Imagenperfil;

    }

    String seleccion;
    protected void DDLD_tipovehiculo_SelectedIndexChanged(object sender, EventArgs e){
        seleccion = DDLD_tipovehiculo.SelectedItem.Value;
        TB_tipodevehiculoperfila.Text = seleccion;
    }//
    String seleccion1;
    protected void DDLA_actividadcomercial_SelectedIndexChanged(object sender, EventArgs e){
        seleccion1 = DDLD_tipovehiculo.SelectedItem.Value;
        TB_actividadcomercialperfila.Text = seleccion1;
    }//

    protected void BTN_guardar_Click(object sender, EventArgs e){
        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
        usuario1.Id = ((Usuario)Session["user"]).Id;
        usuario1.Nombre = TB_nombreperfila.Text;
        usuario1.Apellido = TB_apellidoperfila.Text;
        usuario1.Correo = TB_correoperfila.Text;
        usuario1.Contrasenia = TB_contraseniaperfila.Text;
        usuario1.Direccion = TB_direccionperfila.Text;
        usuario1.Telefono = TB_telefonoperfila.Text;
        usuario1.Documento = TB_documentoperfila.Text;
        usuario1.Tipovehiculo = TB_tipodevehiculoperfila.Text;
        usuario1.Actividadcomercial = TB_actividadcomercialperfila.Text;
        us.actualizarperfil(usuario1);
        Response.Redirect("Perfil.aspx");

    }//

}//finalclase


   








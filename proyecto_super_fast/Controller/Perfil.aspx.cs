using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Perfil : System.Web.UI.Page{
    protected void Page_Load(object sender, EventArgs e) {//1
        
            menu();
        
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
        LB_tipodevehiculoperfil.Visible = false;
        LB_actividadcomercial.Visible = false;
        TB_actividadcomercialperfil.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;
     }

     protected void rolCliente(){
        TB_tipodevehiculoperfil.Visible = false;
        LB_tipodevehiculoperfil.Visible = false;
        LB_actividadcomercial.Visible = false;
        TB_actividadcomercialperfil.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;

    }
      protected void rolDomiciliario(){        
        LB_actividadcomercial.Visible = false;
        TB_actividadcomercialperfil.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;

    }
      protected void rolAliado(){
        TB_tipodevehiculoperfil.Visible = false;
        LB_tipodevehiculoperfil.Visible = false;
        BTN_guardar.Visible = false;
        BTN_cancelar.Visible = false;

    }


    

    protected void BTN_cancelar_Click(object sender, EventArgs e){
       // TB_nombreperfil.Enabled = false;
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
        TB_nombreperfil.Enabled = true;
        TB_apellidoperfil.Enabled = true;
        TB_correoperfil.Enabled = true;
        TB_contraseniaperfil.Enabled = true;
        TB_direccionperfil.Enabled = true;
        TB_telefonoperfil.Enabled = true;
        TB_documentoperfil.Enabled = true;
        BTN_guardar.Visible = true;
        BTN_cancelar.Visible = true;
        BTN_editar.Visible = false;
        mostrar();
       
    }
    protected void mostrar(){

        DAOUsuario us = new DAOUsuario();
        Usuario usuario1 = new Usuario();
    //    usuario1.Id = int.Parse(GetType);

        TB_nombreperfil.Text = usuario1.Nombre;

    }

    
}//finalclase


   








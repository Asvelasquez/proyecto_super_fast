using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.UI;
using Newtonsoft.Json;

public partial class View_GenerarToken : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e){

    }
    protected void B_Recuperar_Click(object sender, EventArgs e){
       Usuario usuario = new DAOUsuario().getUserByUserName(TB_Correo.Text);

        if (usuario != null){
            Token validarToken = new DAOSeguridad().getTokenByUser(usuario.Id);
            //if (validarToken != null)
            //{
            //    L_Mensaje.Text = "Ya extsite un token, por favor verifique su correo.";
            //}
            //else
            //{
            Token token = new Token();
            token.Creado = DateTime.Now;
            token.User_id = usuario.Id;
            token.Vigencia = DateTime.Now.AddHours(2);
<<<<<<< Updated upstream
            
=======
            ClientScriptManager cm = this.ClientScript;
            //inicio prueba
//            var areYouReallySure = false;
//            function areYouSure()
//            {
//                if (allowPrompt)
//                {
//                    if (!areYouReallySure && true)
//                    {
//                        areYouReallySure = true;
//                        var confMessage = "***************************************nn E S P E R A !!! nnAntes de abandonar nuestra web, síguenos en nuestras redes sociales como Facebook, Twitter o Instagram.nnnYA PUEDES HACER CLIC EN EL BOTÓN CANCELAR SI QUIERES...nn***************************************";
//                        return confMessage;
//                    }
//                }
//                else
//                {
//                    allowPrompt = true;
//                }
//            }

//            var allowPrompt = true;
//            window.onbeforeunload = areYouSure;
//            cm.RegisterClientScriptBlock(this.GetType(), "", " < script type = "text / javascript" >
            
           
//</ script > ");
//                 cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('En ');window.location=\"Login.aspx\"</script>");


           
            //fin prueba

 

>>>>>>> Stashed changes
            token.Tokeng = encriptar(JsonConvert.SerializeObject(token));
            new DAOSeguridad().insertarToken(token);

            Correo correo = new Correo();

            new DAOUsuario().getCorreoByCorreos(usuario.Correo);
            String mensaje = "su link de acceso es: " + "http://localhost:56248/View/RecuperarContrasenia.aspx?" + token.Tokeng;
                                                                                
            correo.enviarCorreo(usuario.Correo, token.Tokeng, mensaje);

            LB_Mensaje.Text = "Su nueva contraseña ha sido enviada a su correo";
            //}
        }

        else{
            LB_Mensaje.Text = "El usurio digitado no existe";
        }

    }

    private string encriptar(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
            output.Append(hashedBytes[i].ToString("x2").ToLower());

        return output.ToString();
    }


}
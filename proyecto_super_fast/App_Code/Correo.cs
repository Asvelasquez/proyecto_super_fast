﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Descripción breve de Correo
/// </summary>
public class Correo
{
     
    public void enviarCorreo(String correoDestino, String userToken, String mensaje)
    {

        try
        {
           /*var Emailtemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "Plantilla\\mailer.html"));
            var strBody = string.Format(Emailtemplate.ReadToEnd(), userToken);
           Emailtemplate.Close(); Emailtemplate.Dispose(); Emailtemplate = null;
           
            strBody = strBody.Replace("#TOKEN#", mensaje);
            */
            //Configuración del Mensaje
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            //Especificamos el correo desde el que se enviará el Email y el nombre de la persona que lo envía
            mail.From = new MailAddress("sop.superfast@gmail.com", "Correo de Recuperación");

            //Aquí ponemos el asunto del correo
            mail.Subject = "Recuperación Contraseña";
            //Aquí ponemos el mensaje que incluirá el correo
           mail.Body = mensaje;
            //Especificamos a quien enviaremos el Email, no es necesario que sea Gmail, puede ser cualquier otro proveedor
            mail.To.Add(correoDestino);
            //Si queremos enviar archivos adjuntos tenemos que especificar la ruta en donde se encuentran
            //mail.Attachments.Add(new Attachment(@"C:\Documentos\carta.docx"));
            //mail.IsBodyHtml = true;

            //mail.Priority = MailPriority.High;
            //Configuracion del SMTP
            SmtpServer.Port = 587; //Puerto que utiliza Gmail para sus servicios
            //Especificamos las credenciales con las que enviaremos el mail
            SmtpServer.Credentials = new System.Net.NetworkCredential("sop.superfast@gmail.com", "sUp3rFa5t");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
        catch (Exception ex){}
        //////////////////////
       
            /////////////////////
        }
    public void correoaprobacion(String correoDestino, String mensaje){

        try{
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("sop.superfast@gmail.com", "Correo de Aprobacion");
            mail.Subject = "Solicitud de aprobacion SuperFast";
            mail.Body = mensaje;
            mail.To.Add(correoDestino);
            SmtpServer.Port = 587; 
            SmtpServer.Credentials = new System.Net.NetworkCredential("sop.superfast@gmail.com", "sUp3rFa5t");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
        catch (Exception ex) { }
    }//finalcorreoaprobacion
}
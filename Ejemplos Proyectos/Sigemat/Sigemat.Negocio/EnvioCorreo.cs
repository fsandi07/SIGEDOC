using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;


namespace Sigemat.Negocio
{
    public class EnvioCorreo
    {
        public bool Enviar_Correo(string destino, string Asunto, string Cuerpo)
        {

            try
            {

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();

                msg.To.Add(destino);
                msg.Bcc.Add(destino); //Copia Oculto, en caso que se requiera
                msg.From = new MailAddress("lezki90.loco@gmail.com", "Matricula SIGEMAT", System.Text.Encoding.UTF8);//Verificar el formato
                msg.Subject = Asunto;
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Body = Cuerpo;
                msg.BodyEncoding = System.Text.Encoding.Unicode;
                msg.IsBodyHtml = true;

                ///  //Hotmail: smtp.live.com puerto:25
                //SmtpClient server = new SmtpClient();// para usar el smtp de hotmail

                SmtpClient client = new SmtpClient();// para usar el smtp de gmail
                // credenciales de gmail
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("lezki90.loco@gmail.com", "lezki9009");
                // credenciales de hotmail
                //server.UseDefaultCredentials = false;
                //server.Credentials = new System.Net.NetworkCredential("leonatro24@hotmail.com", "heredia12");

                client.Port = 587;
                client.Host = "smtp.gmail.com";
                //client.Port = 25;
                //client.Host = "smtp.live.com";

                client.EnableSsl = true;
                //server.EnableSsl = true;
                client.Send(msg);
                client.Dispose();

                //server.Send(msg);
                //server.Dispose();

                return true;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                return false;
            }
                                   
        }
    }
}

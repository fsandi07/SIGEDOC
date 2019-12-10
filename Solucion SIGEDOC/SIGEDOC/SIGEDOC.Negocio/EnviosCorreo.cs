using System.Net.Mail;
namespace SIGEDOC.Negocio
{
    public class EnviosCorreo
    {
        public bool Enviar_Correo(string destino, string Asunto, string Cuerpo)
        {
            try
            {
                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.To.Add(destino);
                msg.Bcc.Add(destino); //Copia Oculto, en caso que se requiera
                msg.From = new MailAddress("pqsdical@gmail.com", "Sistema SIGEDOC", System.Text.Encoding.UTF8);//Verificar el formato
                msg.Subject = Asunto;
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Body = Cuerpo;
                msg.BodyEncoding = System.Text.Encoding.Unicode;
                msg.IsBodyHtml = true;               
                SmtpClient client = new SmtpClient();// para usar el smtp de gmail
                // credenciales de gmail
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("pqsdical@gmail.com", "pqsdical2019");             
                client.Port = 587;
                client.Host = "smtp.gmail.com";               
                client.EnableSsl = true;             
                client.Send(msg);
                client.Dispose();           
                return true;
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                return false;
            }
        }
    }
}

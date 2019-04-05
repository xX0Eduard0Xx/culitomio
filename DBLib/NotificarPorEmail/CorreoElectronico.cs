using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace NotificarPorEmail
{
    public class CorreoElectronico
    {
        MailMessage msg = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        /// <summary>
        /// Toma del constructor TU correo para mandar notificación
        /// </summary>
        private string tuCorreo = "";
        /// <summary>
        /// Consulta esta variable para ver el ERROR, en caso de que se devuelva FALSE en el método ENVIAR CORREO
        /// </summary>
        public string error = "";

        //constructor
        /// <summary>
        /// En el Constructor se Define SU CORREO, con el cual mandaràn correos para notificar a los usuarios de su sistema.
        /// </summary>
        /// <param name="smtp">Servidor de correo del servicio que utilizan. (smtp.gmail.com, por ejemplo si usan GMAIL )</param>
        /// <param name="correo">Correo desde el que enviarán la notificación</param>
        /// <param name="contraseña">Su contraseña para acceder a su correo.</param>
        public CorreoElectronico(string smtp, string correo, string contraseña)
        {
            this.tuCorreo = correo;
            this.smtp.Host = smtp;
            this.smtp.Port = 587;//465
            this.smtp.EnableSsl = true;//true;true
            this.smtp.UseDefaultCredentials = false;
            this.smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            this.smtp.Credentials = new NetworkCredential(correo, contraseña);
        }

        /// <summary>
        /// Constructor POR DEFAULT, manda correo con el correo de prueba hmo?servicios@aloncello.com.
        /// </summary>
        public CorreoElectronico()
        {
            this.tuCorreo = "hmo_servicios@aloncello.com";
            smtp.Host = "mail.aloncello.com";
            //smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;//465
            smtp.EnableSsl = true;//true;true
            smtp.UseDefaultCredentials = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("hmo_servicios@aloncello.com", "Ss!er3=V@1C10s");
            // smtp.Credentials = new NetworkCredential("aloncello@gmail.com", "");
        }

        /// <summary>
        /// Método para enviar correo, especificando A QUIEN va dirigido, el ASUNTO del correo, y el MENSAJE de texto del correo. 
        /// </summary>
        /// <param name="aQuien">A quien va dirigido el correo</param>
        /// <param name="asunto">Asunto especificado para el mensaje</param>
        /// <param name="mensaje">Texto del cuerpo del correo electrónico</param>
        /// <returns>Verdadero si se envió, falso y hubo error... verificar la variable ERROR en este caso.</returns>
        public bool enviarEmail(string aQuien, string asunto, string mensaje)
        {
            bool res = false;
            try
            {
                msg.To.Add(aQuien);
                msg.Subject = asunto;
                // msg.From= new MailAddress("aloncello@gmail.com");
                //msg.From = new MailAddress("hmo_servicios@aloncello.com");
                msg.From = new MailAddress(this.tuCorreo);
                msg.Priority = MailPriority.Normal;
                msg.IsBodyHtml = false;
                msg.Body = mensaje;
                smtp.Send(msg);
                msg.Dispose();
                res = true;
            }
            catch (Exception ex)
            {
                this.error="Error al enviar correo. " + ex.ToString();
            }
            return res;
        }
    }
}

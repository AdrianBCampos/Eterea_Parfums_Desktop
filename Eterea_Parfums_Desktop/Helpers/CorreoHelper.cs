using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Eterea_Parfums_Desktop.Helpers
{
    public static class CorreoHelper
    {
        public static void EnviarCorreoNotificacionDespacho(string emailDestino, string nombreCliente, string codigoDespacho)
        {
            string asunto = "Tu pedido fue despachado - Etérea Parfums";
            string mensaje = $"Hola {nombreCliente},\n\n" +
                             "Queremos informarte que tu pedido ha sido despachado.\n" +
                             $"Tu código de seguimiento es: {codigoDespacho}\n\n" +
                             "¡Gracias por elegirnos!\n\n" +
                             "Etérea Parfums.";

            // Reutilizá tu lógica ya existente
            EnviarCorreo(asunto, mensaje, emailDestino);
        }

        private static void EnviarCorreo(string asunto, string mensaje, string emailDestino)
        {
            try
            {
                var mail = new System.Net.Mail.MailMessage();
                mail.To.Add(emailDestino);
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = false;

                // Configuración SMTP desde tu archivo de config
                var smtp = new SmtpClient("smtp.gmail.com");
                smtp.Credentials = new System.Net.NetworkCredential("etereaparfumsinfo@gmail.com", "jcfy ubtj cknd bosb"); // Cambiar
                smtp.Port = 587;
                smtp.EnableSsl = true;

                mail.From = new MailAddress("etereaparfumsinfo@gmail.com", "Etérea Parfums");

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar correo: " + ex.Message);
            }
        }
    }

}

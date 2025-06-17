using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

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
        public static void EnviarCorreoFactura(string rutaArchivoPdf, string emailDestino)
        {
            string asunto = "Factura de tu compra";
            string mensaje = "Adjunto encontrarás tu factura en PDF. ¡Gracias por tu compra!";

            try
            {

                if (!File.Exists(rutaArchivoPdf))
                {
                    MessageBox.Show("No se encontró el archivo PDF a adjuntar.");
                    return;
                }

                var mail = new MailMessage();
                mail.From = new MailAddress("etereaparfumsinfo@gmail.com", "Etérea Parfums");
                mail.To.Add(emailDestino);
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = false;

                // Adjuntar el PDF
                if (!string.IsNullOrEmpty(rutaArchivoPdf))
                {
                    Attachment archivo = new Attachment(rutaArchivoPdf);
                    mail.Attachments.Add(archivo);
                }

                var smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("etereaparfumsinfo@gmail.com", "jcfy ubtj cknd bosb");
                smtp.EnableSsl = true;

                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la factura: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Extensions
{
    public class MailSender
    {
        public static void SendMail(string mail, string subject, string message)
        {
            var mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("contact@hotcat.com", "Restaurant Contact Services");
            mailMessage.To.Add(mail);
            mailMessage.Subject = subject;
            mailMessage.Body = message;
            mailMessage.IsBodyHtml = true;
            mailMessage.BodyEncoding = Encoding.UTF8;
            mailMessage.SubjectEncoding = Encoding.UTF8;

            try
            {
                var client = new SmtpClient("smtp.mailtrap.io", 2525)
                {
                    Credentials = new NetworkCredential("1d02057ce87f00", "caaa419c6b3ca4"),
                    EnableSsl = true
                };
                client.Send(mailMessage);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

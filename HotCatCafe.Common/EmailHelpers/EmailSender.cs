using System.Net;
using System.Net.Mail;

namespace HotCatCafe.Common.EmailHelpers
{
    public class EmailSender
    {
        public static void SendEmail(string email, string subject, string body)
        {
            //MailMessage
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("hotcatcafe@hotmail.com", "HotCatCafe");
            sender.Subject = subject;
            sender.Body = body;
            //Kime gönderileceği
            sender.To.Add(email);
            //sender.To.Add(""); //ikinci bir mail adresi ekleyebiliriz ama string[] emails yazmamız gerekir

            //SmtpClient 
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("hotcatcafe@hotmail.com", "Cafeprojesi.123");
            smtpClient.Host = "smtp-mail.outlook.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;

            smtpClient.Send(sender);

        }
    }
}

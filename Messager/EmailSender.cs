using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Messager
{
    class EmailSender : IMessageSender
    {
        public void SendMessage()
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("SDPBank.162@gmail.com");
            msg.To.Add("serik.siti@gmail.com");
            msg.Subject = "Example";
            msg.Body = "Test";
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("SDPBank.162@gmail.com", "qwerty123*");
            client.Timeout = 20000;
            client.Send(msg);

            Console.WriteLine("Message sended!");
        }
    }
}

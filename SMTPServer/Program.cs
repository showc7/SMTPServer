using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;

namespace SMTPServer
{
    class Program
    {
        /*
         * ehlo mail.example.org
         * 
         */
        static void Main(string[] args)
        {
            MailMessage mail = new MailMessage("wsb-223@mail.example.org", "showc7@gmail.com");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "127.0.0.1";
            mail.Subject = "this is a test email.";
            mail.Body = "this is my test email body";
            client.Send(mail);
        }
    }
}

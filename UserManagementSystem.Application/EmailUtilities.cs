using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using UserManagementSystem.Model;

namespace UserManagementSystem.Application
{
    class EmailUtilities
    {
        public void SendRegistrationEmail(User user)
        {
            MailMessage mail = new MailMessage("thiscourse@isawesome.com", user.Email);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.google.com";
            mail.Subject = "You have successfully registered!";
            mail.Body = "Hope you are enjoying this course so far";
            client.Send(mail);

        }
       
    }
}

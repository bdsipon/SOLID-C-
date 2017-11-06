using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserManagementSystem.Model;
using UserManagementSystem.Model.Repositories;

namespace UserManagementSystem.Application
{
    public class UserManagement
    {
        public bool Register(User user)
        {
            //User Validation
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(user.Email);
            if ( string.IsNullOrEmpty(user.Password) || user.Password.Length < 8 || !match.Success)
            {
                return false;
            }

            //Save User
            UserRepository userRepository = new UserRepository();
            userRepository.SaveUser(user);

            //Send registration email
            MailMessage mail = new MailMessage("thiscourse@isawesome.com", user.Email);
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.google.com";
            mail.Subject = "You have successfully registered!";
            mail.Body = "Hope you are enjoying this course so far";
            client.Send(mail);

            return true;
        }
    }
}

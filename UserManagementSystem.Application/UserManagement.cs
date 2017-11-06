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

            UserValidation uservalidation = new UserValidation();
            if (!uservalidation.Validation(user))
                return false;

            //Save User
            UserRepository userRepository = new UserRepository();
            userRepository.SaveUser(user);

            //Send registration email
            EmailUtilities emailUitilities = new EmailUtilities();
            emailUitilities.SendRegistrationEmail(user);

            return true;
        }
    }
}

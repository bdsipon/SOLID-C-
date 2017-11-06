using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserManagementSystem.Model;

namespace UserManagementSystem.Application
{
    public class UserValidation
    {
        public bool Validation(User user) {
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(user.Email);
            if (string.IsNullOrEmpty(user.Password) || user.Password.Length< 8 || !match.Success)
            {
                return false;
            }
    return true;
        }
    }
}

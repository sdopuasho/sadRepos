using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountigConsumable
{
    public class AuthorizationDataCheck
    {
        public bool LoginCheck(string Login)
        {
            if (Login.Length < 4 || Login.Length > 30)
                return false;
            if (!Login.Any(char.IsDigit))
                return false;
            if (!Login.Any(char.IsLower))
                return false;
            if (!Login.Any(char.IsUpper))
                return false;
            if (Login.Intersect("#$%^&*(!)_").Count() == 0)
                return false;

            return true;
        } 
        public bool PasswordCheck(string Password)
        {
            if (Password.Length < 4 || Password.Length > 30)
                return false;
            if (!Password.Any(char.IsDigit))
                return false;
            if (!Password.Any(char.IsLower))
                return false;
            if (!Password.Any(char.IsUpper))
                return false;
            if (Password.Intersect("#$%^&*(!)_").Count() == 0)
                return false;

            return true;
        }
    }
}

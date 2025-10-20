using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }


        private readonly string storedUsername = "admin";
        private readonly string storedPassword = "password123";
        private readonly string storedRole = "Administrator";

        public bool AuthenticateUser()
        {
           if(Username == storedUsername && Password == storedPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AuthorizeUser()
        {
            if(Role == storedRole)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

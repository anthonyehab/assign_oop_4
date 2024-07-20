using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign_oop_4
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string _storedUsername = "admin";
        private readonly string _storedPassword = "password";
        private readonly string _adminRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == _storedUsername && password == _storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == _storedUsername && role == _adminRole;
        }

    }
}

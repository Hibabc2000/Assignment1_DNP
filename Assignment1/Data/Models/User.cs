using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Data.Models
{
    public class User
    {
        private string username;
        private string password;
        private ArrayList authority = new ArrayList();

        public User(string username, string password, ArrayList authority)
        {
            this.username = username;
            this.password = password;
            this.authority = authority;
        }

        public bool getAuthority(string auth)
        {
            if (authority.Contains(auth))
            {
                return true;
            }
            else return false;
        }
    }
}

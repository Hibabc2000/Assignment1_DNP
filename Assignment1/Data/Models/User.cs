using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Data.Models
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public ArrayList authority { get; set; }

        public User(string username, string password, ArrayList authority)
        {
            this.username = username;
            this.password = password;
            this.authority = authority;
        }

        public User()
        {
            throw new NotImplementedException();
        }

        public bool GetAuthority(string auth)
        {
            if (authority.Contains(auth))
            {
                return true;
            }
            else 
                return false;
        }
    }
}

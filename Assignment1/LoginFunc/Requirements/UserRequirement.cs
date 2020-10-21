using Assignment1.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Assignment1
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    internal class UserRequirement : IAuthorizationRequirement
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        private string v { get; set; }

        public UserRequirement(string v)
        {
            this.v = v;
        }

        public override bool Equals(object obj)
        {
            if(obj is UserRequirement)
            {
                UserRequirement obj2 = (UserRequirement)obj;
                if (obj2.getV().Equals(this.v))
                {
                    return true;
                }
            }
            return false;
        }

        public string getV()
        {
            return v;
        }
    }
}
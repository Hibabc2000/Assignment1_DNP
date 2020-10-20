using Microsoft.AspNetCore.Authorization;

namespace Assignment1.LoginFunc.Requirements {
    public class Requirement : IAuthorizationRequirement {
        public readonly string Student = "Student";

        public Requirement()
        {
        }
    }
}
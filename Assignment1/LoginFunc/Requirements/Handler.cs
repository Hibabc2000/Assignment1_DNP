using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace SimpleLogin.LoginFunctionality.Requirement {
    public class Handler : AuthorizationHandler<Assignment1.LoginFunc.Requirements.Requirement> {
        // TODO finish actually using this one in Startup
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, Assignment1.LoginFunc.Requirements.Requirement requirement) {
            ClaimsPrincipal claimsPrincipal = context.User;

            if (claimsPrincipal.HasClaim("Role", "student")) {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
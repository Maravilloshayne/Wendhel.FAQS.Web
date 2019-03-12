using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WendhelAton.FAQ.Web.Infrastructure.Data.Enums;

namespace WendhelAton.FAQ.Web.Infrastructure.Security
{
    public class AuthorizeUserRequirementHandler : AuthorizationHandler<AuthorizeAdminRequirement>
    {
        public AuthorizeUserRequirementHandler() { }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthorizeAdminRequirement requirement)
        {
            if (!WebUser.Roles.Contains(Role.Admins))
            {
                context.Fail();
                return Task.CompletedTask;
            }
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
    public class AuthorizeUserRequirement : IAuthorizationRequirement
    {
    }
}

using System;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using DS.Core.EF;
using Microsoft.EntityFrameworkCore;
using DS.Core.Enum;

namespace DS.Service.Sercurity
{
    public class IsUserRequirement : IAuthorizationRequirement
    {
    }

    public class IsUserRequirementHandle : AuthorizationHandler<IsUserRequirement>
    {
        private readonly DsDbContext _dsdbContext;
        public IsUserRequirementHandle(DsDbContext dataContext)
        {
            _dsdbContext = dataContext;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsUserRequirement requirement)
        {
            var claimUserId = context.User.FindFirst(ClaimTypes.NameIdentifier);

            if (claimUserId == null) return Task.CompletedTask;

            var userId = claimUserId.Value;

            if (userId == default) return Task.CompletedTask;

            var roles = _dsdbContext.UserRole!.Include(x => x.Role).Where(x => x.UserId == userId).Select(x => x.Role!.Name).ToList();

            if (roles.Contains(Role.User.ToString())) context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}


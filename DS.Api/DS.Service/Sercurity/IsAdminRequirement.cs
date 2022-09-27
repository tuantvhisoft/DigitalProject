using System;
using System.Data;
using System.Security.Claims;
using DS.Core.EF;
using DS.Core.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace DS.Service.Sercurity
{
    public class IsAdminRequirement : IAuthorizationRequirement
    {
    }
    public class IsAdminRequirementHandle : AuthorizationHandler<IsAdminRequirement>
    {
        private readonly DsDbContext _dsdbContext;
        public IsAdminRequirementHandle(DsDbContext dataContext)
        {
            _dsdbContext = dataContext;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, IsAdminRequirement requirement)
        {
            var claimUserId = context.User.FindFirst(ClaimTypes.NameIdentifier);

            if (claimUserId == null) return Task.CompletedTask;

            var userId = claimUserId.Value;

            if (userId == default) return Task.CompletedTask;

            var roles = _dsdbContext.UserRole!.Include(x => x.Role).Where(x => x.UserId == userId).Select(x => x.Role!.Name).ToList();
            if (roles.Contains(Role.Admin.ToString())) context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }
}


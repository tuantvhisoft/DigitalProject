using DS.ViewModel.Accessors;
using DS.ViewModel.UnitOfWork;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DS.Service.Sercurity
{
    public class UserAccessor : IUserAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUnitOfWork _unitOfWork;
        public UserAccessor(IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
        }

        //public async Task<CreatedByDto?> GetCreatedInfo(DateTime CreatedAt, Guid userId)
        //{
        //    var user = await _unitOfWork.Users.GetByIdAsync(userId);

        //    if (user == null) return null;

        //    return new CreatedByDto
        //    {
        //        UserId = user.Id,
        //        FullName = user.FullName,
        //        CreatedAt = CreatedAt
        //    };
        //}

        //public async Task<LastModifiedByDto?> GetLastModifiedInfo(DateTime? LastModifiedAt, Guid? userId = default)
        //{
        //    if (userId == default) return null;

        //    var user = await _unitOfWork.Users.GetByIdAsync(userId ?? Guid.Empty);

        //    if (user == null) return null;

        //    return new LastModifiedByDto
        //    {
        //        UserId = user.Id,
        //        FullName = user.FullName,
        //        LastModifiedAt = LastModifiedAt
        //    };
        //}

        public string GetUserEmail()
        {
            return _httpContextAccessor.HttpContext!.User.FindFirst(ClaimTypes.Email)!.Value;
        }

        public Guid GetUserId()
        {
            string userId = _httpContextAccessor.HttpContext!.User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            return Guid.TryParse(userId, out Guid id) ? id : default;
        }
    }
}

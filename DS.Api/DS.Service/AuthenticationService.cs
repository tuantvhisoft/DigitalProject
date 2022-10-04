using AutoMapper;
using DS.Core.Entity;
using DS.ViewModel.Accessors;
using DS.ViewModel.Constants;
using DS.ViewModel.Exceptions;
using DS.ViewModel.Helper;
using DS.ViewModel.Interface;
using DS.ViewModel.UnitOfWork;
using DS.ViewModel.VModel.Authentication;
using DS.ViewModel.VModel.User;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DS.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IUserAccessor _userAccessor;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public AuthenticationService(IUnitOfWork unitOfWork, IMapper mapper,
            ITokenService tokenService, IUserAccessor userAccessor, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tokenService = tokenService;
            _userAccessor = userAccessor;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<UserViewModel> GetCurrentUser()
        {
            Guid userId = _userAccessor.GetUserId();

            var user = await _unitOfWork.Users.GetByIdAsync(userId);

            if (user == null) throw new UnauthorizedException(Errors.RESOURCE_NOTFOUND("User"));

            var result = _mapper.Map<UserViewModel>(user);

            return result;
        }

        public async Task<AuthenticationResponse> Login(LoginViewModel loginVm)
        {
            var user = await _unitOfWork.Users.GetFirstOrDefaultAsync(x => x.Email == loginVm.Email);

            if (user == null) throw new UnauthorizedException(Errors.INCORRECT_LOGIN_INFO, Errors.INCORRECT_EMAIL);

            if (user.IsBlocked) throw new UnauthorizedException(Errors.LOCKED_USER);

            var loginResult = PasswordHelper.ValidatePassword(loginVm.Password!, user.PasswordHash!, user.PasswordSalt!);

            if (!loginResult) throw new UnauthorizedException(Errors.INCORRECT_LOGIN_INFO, Errors.INCORRECT_PASSWORD);

            var refreshToken = await CreateRefreshToken(user, loginVm.Remember);

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };

            _httpContextAccessor.HttpContext!.Response.Cookies.Append("refreshToken", refreshToken.Token!, cookieOptions);

            return CreateAuthenticationResponse(user);
        }

        public async Task<AuthenticationResponse> RefreshToken()
        {
            var refreshToken = _httpContextAccessor.HttpContext!.Request.Cookies["refreshToken"];

            Guid userId = _userAccessor.GetUserId();

            var user = await _unitOfWork.Users.GetIQueryable()
                .Include(x => x.UserLoginTokens).FirstOrDefaultAsync(x => x.Id == userId);

            if (user == null) throw new UnauthorizedException(Errors.RESOURCE_NOTFOUND("User"));

            var oldToken = user.UserLoginTokens!.SingleOrDefault(x => x.Token == refreshToken);

            if (oldToken != null && !oldToken.IsActive) throw new UnauthorizedException(Errors.REVOKED_TOKEN);

            return CreateAuthenticationResponse(user);
        }

        public async Task<AuthenticationResponse> Register(RegisterViewModel registerVm)
        {
            var user = _mapper.Map<User>(registerVm);

            var passwordResponse = registerVm.Password!.HashPassword();

            user.PasswordHash = passwordResponse.PasswordHash;
            user.PasswordSalt = passwordResponse.PasswordSalt;
            
            var adminRole = await _unitOfWork.Roles.GetFirstOrDefaultAsync(x => x.Name == Core.Enum.Role.Admin.ToString());

            user.UserRoles!.Add(new UserRole
            {
                RoleId = adminRole!.Id
            });

            await _unitOfWork.Users.AddAsync(user);

            var result = await _unitOfWork.SaveChangeAsync() > 0;

            if (!result) throw new BadRequestException(Errors.ADD_FAILURE);

            var refreshToken = await CreateRefreshToken(user);

            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = DateTime.UtcNow.AddDays(7)
            };

            _httpContextAccessor.HttpContext!.Response.Cookies.Append("refreshToken", refreshToken.Token!, cookieOptions);

            return CreateAuthenticationResponse(user);
        }

        private async Task<UserLoginToken> CreateRefreshToken(User user, bool remember = false)
        {
            var refreshToken = _tokenService.GenerateRefreshToken(remember);

            user.UserLoginTokens!.Add(refreshToken);

            _unitOfWork.Users.Update(user!);

            await _unitOfWork.SaveChangeAsync();

            return refreshToken;
        }

        private AuthenticationResponse CreateAuthenticationResponse(User user)
        {
            var jwt = _tokenService.CreateToken(user);

            return new AuthenticationResponse
            {
                Token = jwt
            };
        }
    }
}

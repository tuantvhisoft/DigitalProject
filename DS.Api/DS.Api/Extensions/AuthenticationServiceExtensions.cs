using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using DS.Service.Sercurity;
using DS.ViewModel.Accessors;
using DS.ViewModel.Interface;
using DS.Service;

namespace DS.Api.Extensions
{
    public static class AuthenticationServiceExtensions
    {
        public static IServiceCollection AddAuthenticationServices(this IServiceCollection services, IConfiguration config)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["TokenKey"]));

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = key,
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                    };
                });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("IsAdmin", policy =>
                {
                    policy.Requirements.Add(new IsAdminRequirement());
                });
                options.AddPolicy("IsUser", policy =>
                {
                    policy.Requirements.Add(new IsUserRequirement());
                });
            });


            services.AddTransient<IAuthorizationHandler, IsAdminRequirementHandle>();
            services.AddTransient<IAuthorizationHandler, IsUserRequirementHandle>();

            services.AddHttpContextAccessor();

            services.AddTransient<IUserAccessor, UserAccessor>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
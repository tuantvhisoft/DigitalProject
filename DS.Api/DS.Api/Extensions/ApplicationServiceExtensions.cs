using System;
using System.Reflection;
using DS.Core.EF;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace DS.Api.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            ).AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                options.DisableDataAnnotationsValidation = true;
            });

            services.AddEndpointsApiExplorer();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "tuantv15",
                        Email = "tuantv@hisoft.vn",
                    }
                });
                options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"<p>JWT Authorization header using the Bearer scheme.</br>
                                    Enter 'Bearer' [space] and then your token in the text input below.</br>
                                    Example: 'Bearer json-web-token'</p>",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                options.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });
            });

            services.AddDbContext<DsDbContext>(options =>
            {
                options/*.UseLazyLoadingProxies()*/
                .UseSqlServer(config.GetConnectionString("DsDb"));
            });

            //services.Configure<DefaultCredential>(config.GetSection("DefaultCredential"));
            //services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));

            //services.AddAutoMapper(typeof(MapperProfile).Assembly);

            //services.AddScoped<IUnitOfWork, UnitOfWork>();


            services.Configure<RouteOptions>(options =>
            {
                options.LowercaseUrls = true;
            });

            return services;
        }
    }
}


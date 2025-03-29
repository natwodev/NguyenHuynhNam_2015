using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace NguyenHuynhNam_2015.Authentication
{
    public static class JwtConfig
    {
        public static void ConfigureJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var keyValue = configuration["JWT:Key"];
            var issuerValue = configuration["JWT:Issuer"];
            var audienceValue = configuration["JWT:Audience"];
            
            Console.WriteLine($"🔑 JWT Key: {keyValue}");
            Console.WriteLine($"🎯 Issuer: {issuerValue}, Audience: {audienceValue}");

            var key = Encoding.ASCII.GetBytes(keyValue);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidIssuer = issuerValue,
                    ValidAudience = audienceValue,
                    RoleClaimType = ClaimTypes.Role
                };

                // Debug JWT
                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        Console.WriteLine($"🔍 Received Token: {context.Token}");
                        return Task.CompletedTask;
                    },
                    OnAuthenticationFailed = context =>
                    {
                        Console.WriteLine($"❌ JWT Authentication Failed: {context.Exception.Message}");
                        return Task.CompletedTask;
                    }
                };
            });
        }
    }
}

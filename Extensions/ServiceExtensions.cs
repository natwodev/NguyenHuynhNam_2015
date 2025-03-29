using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.Data;


using NguyenHuynhNam_2015.Authentication;
using NguyenHuynhNam_2015.Configurations; // Import JwtConfig

namespace NguyenHuynhNam_2015.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Đăng ký DbContext
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Auth/Login"; // Đường dẫn đến trang đăng nhập
                    options.LogoutPath = "/Auth/Logout"; // Đường dẫn đến trang logout
                    options.AccessDeniedPath = "/Auth/AccessDenied"; // Trang khi bị chặn quyền
                });

            // Add services to the container.
            services.AddControllersWithViews();

            // Đăng ký các service khác
            services.ConfigureDependencies();

            // Đăng ký xác thực JWT (được tách riêng)
            services.ConfigureJwt(configuration);
/*         
            // Đăng ký các service khác
            services.ConfigureDependencies();

            // Đăng ký xác thực JWT (được tách riêng)
            services.ConfigureJwt(configuration);

            // Đăng ký các service cần thiết cho API Controllers
            services.AddControllers();
            
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "localhost:6379"; // Thay bằng địa chỉ Redis của bạn
            });

            //đăng ký tạo policy phân quyền
            services.AddAuthorization(options =>
            {
                AuthorizationPolicies.AddCustomPolicies(options);
            });
*/
        }
    }
}
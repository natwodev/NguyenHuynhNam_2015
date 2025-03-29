using Microsoft.AspNetCore.Builder;

namespace NguyenHuynhNam_2015.Extensions
{
    public static class AppExtensions
    {
        public static void ConfigureMiddleware(this WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();
            
            // ✅ Xác thực & phân quyền
            app.UseAuthentication();
            app.UseAuthorization();

            /*
            // Cấu hình API lắng nghe trên tất cả IP trong mạng
            app.Urls.Add("http://0.0.0.0:5013");

            // ✅ Kiểm tra token trước khi xác thực
            app.UseMiddleware<JwtBlacklistMiddleware>();

          
            */
        }
    }
}
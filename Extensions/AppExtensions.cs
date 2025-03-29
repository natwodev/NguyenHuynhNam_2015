using Microsoft.AspNetCore.Builder;

namespace webphuckhao_api.Extensions
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

            /*
            // Cấu hình API lắng nghe trên tất cả IP trong mạng
            app.Urls.Add("http://0.0.0.0:5013");

            // ✅ Kiểm tra token trước khi xác thực
            app.UseMiddleware<JwtBlacklistMiddleware>();

            // ✅ Xác thực & phân quyền
            app.UseAuthentication();
            app.UseAuthorization();
            */
        }
    }
}
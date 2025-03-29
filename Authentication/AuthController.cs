using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            // Nếu đã đăng nhập, chuyển hướng về trang chủ
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModelDTO loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            var authResult = await _authService.AuthenticateAsync(loginModel);
            if (authResult == null || string.IsNullOrEmpty(authResult.Role))
            {
                TempData["Message"] = "Tên đăng nhập hoặc mật khẩu không đúng.";
                return RedirectToAction("Login");
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, loginModel.Id),
                new Claim(ClaimTypes.Role, authResult.Role)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties();

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, 
                new ClaimsPrincipal(claimsIdentity), authProperties);

            // Điều hướng dựa trên Role
            if (authResult.Role == "Student")
            {
                return RedirectToAction("Index", "Student");
            }
    
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}

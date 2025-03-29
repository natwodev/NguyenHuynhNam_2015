using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using NguyenHuynhNam_2015.DTOs;

public class AuthService : IAuthService
{
    private readonly IAuthRepository _authRepository;
    private readonly IConfiguration _configuration;

    public AuthService(IAuthRepository authRepository, IConfiguration configuration)
    {
        _authRepository = authRepository;
        _configuration = configuration;
    }

    public async Task<AuthResultDTO> AuthenticateAsync(LoginModelDTO loginModel)
    {
        var user = await _authRepository.GetUserAsync(loginModel.Id, loginModel.PasswordHash);
        if (user == null) return null;

        var key = Encoding.ASCII.GetBytes(_configuration["JWT:key"] ?? "default_secret_key");
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Role, user.Role.Name) // Gán quyền (role)
            }),
            Expires = DateTime.UtcNow.AddHours(1),
            Issuer = _configuration["JWT:Issuer"],
            Audience = _configuration["JWT:Audience"],
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
    
        var token = new JwtSecurityTokenHandler().CreateToken(tokenDescriptor);
        var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

        return new AuthResultDTO
        {
            Token = tokenString,
            Role = user.Role.Name
        };
    }
}
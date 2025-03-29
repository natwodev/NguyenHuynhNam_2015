using NguyenHuynhNam_2015.DTOs;
using System.Threading.Tasks;

public interface IAuthService
{
    Task<AuthResultDTO> AuthenticateAsync(LoginModelDTO loginModel);
}
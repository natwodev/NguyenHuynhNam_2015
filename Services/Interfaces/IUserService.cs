using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Services
{
    public interface IUserService
    {
        Task<UserDTO> GetByIdAsync(string userId);
        Task<IEnumerable<UserDTO>> GetAllAsync();
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task LockUserAsync(string userId);
        Task ResetPasswordAsync(string userId, string newPasswordHash);

    }
}
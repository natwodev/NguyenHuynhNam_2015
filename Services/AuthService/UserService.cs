using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDTO> GetByIdAsync(string userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            return user != null
                ? new UserDTO { UserId = user.UserId, RoleId = user.RoleId, RoleName = user.Role.Name }
                : null;
        }

        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            await _userRepository.AddUserAsync(user);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateUserAsync(user);
        }

        public async Task LockUserAsync(string userId)
        {
            await _userRepository.LockUserAsync(userId);
        }
        
        public async Task ResetPasswordAsync(string userId, string newPasswordHash)
        {
            var user = await _userRepository.GetByIdAsync(userId);
            if (user == null) throw new KeyNotFoundException("User not found");

            user.PasswordHash = newPasswordHash;
            await _userRepository.UpdateUserAsync(user);
        }

    }
}
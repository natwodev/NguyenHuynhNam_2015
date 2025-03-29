using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Models;
using NguyenHuynhNam_2015.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NguyenHuynhNam_2015.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(string userId);
        Task<IEnumerable<UserDTO>> GetAllAsync();
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task LockUserAsync(string userId);

    }
}
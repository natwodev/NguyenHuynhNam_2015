using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Models;
using NguyenHuynhNam_2015.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.Data;

namespace NguyenHuynhNam_2015.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetByIdAsync(string userId)
        {
            return await _context.Users.Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.UserId == userId);
        }
        
        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            return await _context.Users.Include(u => u.Role)
                .Select(u => new UserDTO
                {
                    UserId = u.UserId,
                    RoleId = u.RoleId,
                    RoleName = u.Role.Name
                })
                .ToListAsync();
        }

        public async Task AddUserAsync(User user)
        {
            // Lấy Role từ database
            user.Role = await _context.Roles.FindAsync(user.RoleId);
            if (user.Role == null)
                throw new KeyNotFoundException("RoleId không hợp lệ.");

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task LockUserAsync(string userId)
        {
            var user = await GetByIdAsync(userId);
            if (user != null)
            {
                user.IsLocked = true;
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
            }
        }
        
    }
}

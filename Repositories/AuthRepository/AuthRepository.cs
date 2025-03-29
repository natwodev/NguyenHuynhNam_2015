using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.Models;
using Microsoft.EntityFrameworkCore;

public class AuthRepository : IAuthRepository
{
    private readonly ApplicationDbContext _context;

    public AuthRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> GetUserAsync(string id, string passwordHash)
    {
        return await _context.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.UserId == id && u.PasswordHash == passwordHash);
    }
}
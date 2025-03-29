using NguyenHuynhNam_2015.Models;

public interface IAuthRepository
{
    Task<User> GetUserAsync(string id, string passwordHash);
}
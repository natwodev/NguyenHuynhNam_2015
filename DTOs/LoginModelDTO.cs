namespace webphuckhao_api.DTOs;

public class LoginModelDTO
{
    public string Id { get; set; }
    public string PasswordHash { get; set; }  // Lưu mật khẩu đã hash
}


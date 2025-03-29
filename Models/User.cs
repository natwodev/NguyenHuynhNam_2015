using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace NguyenHuynhNam_2015.Models;

public class User
{
    [Key]
    [Required]
    [MaxLength(10)]
    public string UserId { get; set; }  // Trùng với StudentId, EmployeeId, LecturerId

    [Required]
    [MaxLength(255)]
    public string PasswordHash { get; set; }  // Lưu mật khẩu đã hash

    [Required]
    public int RoleId { get; set; }  // Liên kết với bảng Role

    [ForeignKey("RoleId")]
   // [JsonIgnore]
    public Role? Role { get; set; }
    
    public bool IsLocked { get; set; } = false;

}

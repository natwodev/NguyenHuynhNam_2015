namespace webphuckhao_api.DTOs
{
    public class UserDTO
    {
        public string UserId { get; set; }       // Trùng với StudentId/EmployeeId/LecturerId
        public int RoleId { get; set; }          // Khóa ngoại đến Role
        public string RoleName { get; set; }     // Lấy tên Role ("Admin", "NhanVien", v.v.)
    }
}
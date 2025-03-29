using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace webphuckhao_api.Models
{
    // Lớp đại diện cho sinh viên
    public class Student
    {
        // Khóa chính của sinh viên, bắt buộc và tối đa 10 ký tự
        [Key]
        [Required]
        [MaxLength(10)]
        public string StudentId { get; set; }  

        // Họ và tên đầy đủ của sinh viên, bắt buộc và tối đa 100 ký tự
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }  

        // Ngày sinh của sinh viên, bắt buộc
        [Required]
        public DateTime DateOfBirth { get; set; }  

        // Số căn cước công dân của sinh viên, bắt buộc và tối đa 12 ký tự
        [Required]
        [MaxLength(12)]
        public string CitizenId { get; set; }
        
        // Email của sinh viên, định dạng email và tối đa 100 ký tự
        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }  

        // Số điện thoại của sinh viên, tùy chọn và tối đa 15 ký tự
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }  

        // Giới tính của sinh viên, tùy chọn và tối đa 10 ký tự
        [MaxLength(10)]
        public string? Gender { get; set; }  

        // Địa chỉ của sinh viên, tùy chọn và tối đa 255 ký tự
        [MaxLength(255)]
        public string? Address { get; set; }  
        
        // Hình ảnh của sinh viên lưu dưới dạng varbinary(MAX)
        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? Image { get; set; }
        
        // Khóa ngoại cho lớp (Class) của sinh viên, bắt buộc và tối đa 10 ký tự
        [Required]
        [MaxLength(10)]
        [ForeignKey("Class")]
        public string ClassId { get; set; }  
        // Đối tượng Class liên kết
        public Class Class { get; set; }  

        // Khóa ngoại cho chuyên ngành (Major) của sinh viên, tùy chọn và tối đa 10 ký tự
        [MaxLength(10)]
        [ForeignKey("Major")]
        public string? MajorId { get; set; }  
        // Đối tượng Major liên kết (có thể null)
        public Major? Major { get; set; }  

        // Bộ sưu tập bảng điểm của sinh viên, có thể có nhiều bảng điểm
        public ICollection<Transcript>? Transcripts { get; set; }  
        // Bộ sưu tập đơn phúc khảo của sinh viên, có thể có nhiều đơn phúc khảo
        public ICollection<RegradeRequest>? RegradeRequests { get; set; } 
        
        // Trạng thái khóa tài khoản, mặc định là false (chưa bị khóa)
        public bool IsLocked { get; set; } = false;

    }
}

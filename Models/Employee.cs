using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenHuynhNam_2015.Models
{
    // Class representing an employee
    public class Employee
    {
        // Primary key for employee, required and maximum 10 characters
        [Key]
        [Required]
        [MaxLength(10)]
        public string EmployeeId { get; set; }
        
        // Full name of the employee, required and maximum 100 characters
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        
        // Date of birth of the employee, required
        public DateTime? DateOfBirth { get; set; }
        
        // Email of the employee, required, must be a valid email format, and maximum 100 characters
        [Required, EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        
        // Phone number of the employee, optional and maximum 15 characters
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
        
        // Gender of the employee, optional and maximum 10 characters
        [MaxLength(10)]
        public string? Gender { get; set; }
        
        // Address of the employee, optional and maximum 255 characters
        [MaxLength(255)]
        public string? Address { get; set; }
        
        // Citizen ID of the employee, required and maximum 12 characters
        [MaxLength(12)]
        public string? CitizenId { get; set; }
        
        // Employee's image stored as varbinary(MAX)
        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? Image { get; set; }
        
        // Foreign key for the position, required and maximum 10 characters
        [MaxLength(10)]
        [ForeignKey("Position")]
        public string? PositionId { get; set; }
        // Associated Position object
        public Position? Position { get; set; }
        
        // Trạng thái khóa tài khoản, mặc định là false (chưa bị khóa)
        public bool IsLocked { get; set; } = false;

    }
}

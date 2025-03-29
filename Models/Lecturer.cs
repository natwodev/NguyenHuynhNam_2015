using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace webphuckhao_api.Models
{
    // Class representing a lecturer
    public class Lecturer
    {
        // Primary key for the lecturer, required and maximum 10 characters
        [Key]
        [Required]
        [MaxLength(10)]
        public string LecturerId { get; set; }
        
        // Full name of the lecturer, required and maximum 100 characters
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        
        // Date of birth of the lecturer, required
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        // Citizen ID of the lecturer, required and maximum 12 characters
        [Required]
        [MaxLength(12)]
        public string CitizenId { get; set; }
        
        // Email of the lecturer, required, must be a valid email format, and maximum 100 characters
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        
        // Phone number of the lecturer, optional and maximum 15 characters
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        
        // Gender of the lecturer, optional and maximum 10 characters
        [MaxLength(10)]
        public string Gender { get; set; }
        
        // Address of the lecturer, optional and maximum 255 characters
        [MaxLength(255)]
        public string Address { get; set; }
        
        // Lecturer's image stored as varbinary(MAX)
        [Column(TypeName = "varbinary(MAX)")]
        public byte[]? Image { get; set; }
        
        // Foreign key for the department, required and maximum 10 characters
        [Required]
        [MaxLength(10)]
        [ForeignKey("Department")]
        public string DepartmentId { get; set; }
        
        // Navigation property for the associated department
        public Department Department { get; set; }
        
        // Trạng thái khóa tài khoản, mặc định là false (chưa bị khóa)
        public bool IsLocked { get; set; } = false;

    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenHuynhNam_2015.DTOs
{
    public class LecturerDTO
    {
        [Required]
        [MaxLength(10)]
        public string LecturerId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [MaxLength(12)]
        public string CitizenId { get; set; }
        
        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }
        
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
        
        [MaxLength(10)]
        public string Gender { get; set; }
        
        [MaxLength(255)]
        public string Address { get; set; }
        
        public byte[]? Image { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string DepartmentId { get; set; }
        
        [MaxLength(100)]
        public string? DepartmentName { get; set; }

    }
}
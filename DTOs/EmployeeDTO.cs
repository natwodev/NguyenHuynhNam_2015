using System;

namespace NguyenHuynhNam_2015.DTOs
{
    // DTO for Employee data
    public class EmployeeDTO
    {
        public string EmployeeId { get; set; }
        
        public string FullName { get; set; }
        
        public DateTime? DateOfBirth { get; set; }
        
        public string Email { get; set; }
        
        public string? PhoneNumber { get; set; }
        
        public string? Gender { get; set; }
        
        public string? Address { get; set; }
        
        public string? CitizenId { get; set; }
        
        public byte[]? Image { get; set; }
        
        public string? PositionId { get; set; }
        
        // Field to hold the position name
        public string? PositionName { get; set; }
    }
}
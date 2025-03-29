using System;
using NguyenHuynhNam_2015.Enums;

namespace NguyenHuynhNam_2015.DTOs
{
    // DTO for Regrade Request data
    public class RegradeRequestDTO
    {
        public int RegradeRequestId { get; set; }
        
        public int SemesterId { get; set; }
        
        // Example: "Semester 1", "Semester 2"
        public string SemesterName { get; set; }
        
        public DateTime RequestCreationDate { get; set; }
        
        public string Reason { get; set; }
        
        public double? DesiredScore { get; set; }
        
        public RegradeStatus Status { get; set; }
        
        public string? EmployeeNote { get; set; }
        
        public int TranscriptId { get; set; }
        
        public double? FinalScore { get; set; }
        
        public string? StudentId { get; set; }
        
        public string? StudentFullName { get; set; }
        
        public string? ApprovingEmployeeId { get; set; }
        
        public string? ApprovingEmployeeFullName { get; set; }
        
        public bool IsCancelled { get; set; }
    }
}
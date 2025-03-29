using System;
using NguyenHuynhNam_2015.Enums;

namespace NguyenHuynhNam_2015.DTOs
{
    // DTO for Regrade Detail data
    public class RegradeDetailDTO
    {
        public int RegradeDetailId { get; set; }
        
        public int RegradeRequestId { get; set; }
        
        public double? RegradeResult { get; set; }
        
        public string? Note { get; set; }
        
        public DateTime? RegradeDate { get; set; }
        
        public RegradeStatus RegradeStatus { get; set; }
        
        public string LecturerId { get; set; }
        
        public string LecturerFullName { get; set; }
    }
}
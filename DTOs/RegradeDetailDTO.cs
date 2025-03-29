using System;
using webphuckhao_api.Enums;

namespace webphuckhao_api.DTOs
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
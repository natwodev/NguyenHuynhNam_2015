using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using webphuckhao_api.Enums; // Import enum

namespace webphuckhao_api.Models
{
    public class RegradeRequest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegradeRequestId { get; set; }

        [Required]
        [ForeignKey("Semester")]
        public int SemesterId { get; set; }
        public Semester? Semester { get; set; }

        [Required]
        public DateTime RequestCreationDate { get; set; }

        [Required]
        [MaxLength(500)]
        public string Reason { get; set; }

        [Range(0, 10)]
        public double? DesiredScore { get; set; }

        // 🔹 Sử dụng enum thay vì string
        [Required]
        public RegradeStatus Status { get; set; } = RegradeStatus.Pending;

        public string? EmployeeNote { get; set; }

        [ForeignKey("Transcript")]
        public int TranscriptId { get; set; }
        public Transcript? Transcript { get; set; }

        [MaxLength(10)]
        [ForeignKey("Student")]
        public string? StudentId { get; set; }
        public Student? Student { get; set; }

        [MaxLength(10)]
        [ForeignKey("ApprovingEmployee")]
        public string? ApprovingEmployeeId { get; set; }
        public Employee? ApprovingEmployee { get; set; }
        
        public bool IsCancelled { get; set; } = false;
    }
}
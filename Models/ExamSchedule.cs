using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NguyenHuynhNam_2015.Models
{
    // Class representing an exam schedule
    public class ExamSchedule
    {
        // Primary key for the exam schedule, auto-incremented
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-generated
        public int ExamScheduleId { get; set; }
        
        // Foreign key for the subject, required and maximum 10 characters
        [Required]
        [MaxLength(10)]
        [ForeignKey("Subject")]
        public string SubjectId { get; set; }
        // Associated Subject object
        public Subject Subject { get; set; }
        
        // Foreign key for the semester, required
        [Required]
        [ForeignKey("Semester")]
        public int SemesterId { get; set; }
        // Associated Semester object
        public Semester Semester { get; set; }
        
        // Date and time of the exam, required
        [Required]
        public DateTime ExamDateTime { get; set; }
        
        // Exam room, required and limited to 50 characters
        [Required]
        [MaxLength(50)]
        public string Room { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace webphuckhao_api.Models
{
    // Class representing a subject or course
    public class Subject
    {
        // Primary key for the subject, maximum 10 characters
        [Key]
        [MaxLength(10)]
        public string SubjectId { get; set; }
        
        // Name of the subject, required and maximum 100 characters
        [Required]
        [MaxLength(100)]
        public string SubjectName { get; set; }
        
        // Number of credits for the subject, required
        [Required]
        public int Credits { get; set; }
        
        // Indicates whether the subject includes an exam
        // true: Has exam, false: No exam
        [Required]
        public bool HasExam { get; set; }
        
        // Foreign key for the department, required and maximum 10 characters
        [Required]
        [MaxLength(10)]
        [ForeignKey("Department")]
        public string? DepartmentId { get; set; }
        
        // Associated Department object
        public Department Department { get; set; }
        
        // Collection of transcripts associated with the subject
        public ICollection<Transcript> Transcripts { get; set; }
    }
}
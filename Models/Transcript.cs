using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webphuckhao_api.Models
{
    // Class representing a transcript or grade record
    public class Transcript
    {
        // Primary key for the transcript, auto-generated
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TranscriptId { get; set; }

        // Student identifier, optional (allows null)
        [MaxLength(10)]
        public string? StudentId { get; set; }

        // Navigation property for the associated student, optional
        [ForeignKey("StudentId")]
        public Student? Student { get; set; }

        // Subject identifier, optional (allows null)
        [MaxLength(10)]
        public string? SubjectId { get; set; }

        // Navigation property for the associated subject, optional
        [ForeignKey("SubjectId")]
        public Subject? Subject { get; set; }
        
        // Component score (e.g., assignments), optional
        public double? ComponentScore { get; set; }
        
        // Midterm score, optional
        public double? MidtermScore { get; set; }
        
        // Final exam score, optional
        public double? FinalScore { get; set; }
        
        // Total score, optional
        public double? TotalScore { get; set; }

        // Score after regrade, optional (may be null)
        public double? ScoreAfterRegrade { get; set; }

        // Semester identifier, optional (allows null)
        public int? SemesterId { get; set; }

        // Navigation property for the associated semester, optional
        [ForeignKey("SemesterId")]
        public Semester? Semester { get; set; }
        
        // Navigation property for the digital exam (if applicable), optional
        public DigitalExam? DigitalExam { get; set; }
    }
}
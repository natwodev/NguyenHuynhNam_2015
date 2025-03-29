using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webphuckhao_api.Models
{
    // Class representing a digital exam file (e.g., exam script and answer key)
    public class DigitalExam
    {
        // Primary key for the digital exam, auto-generated
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DigitalExamId { get; set; }

        // Foreign key linking to the transcript, optional (allows the transcript to not exist)
        public int? TranscriptId { get; set; }
    
        // Navigation property for the associated transcript, optional
        [ForeignKey("TranscriptId")]
        public Transcript? Transcript { get; set; }

        // File path for the exam script, optional and maximum 255 characters
        [MaxLength(255)]
        public string? ExamFilePath { get; set; }

        // Date when the exam file was uploaded, optional
        public DateTime? ExamFileUploadDate { get; set; }

        // File path for the answer key, optional and maximum 255 characters
        [MaxLength(255)]
        public string? AnswerFilePath { get; set; }

        // Date when the answer file was uploaded, optional
        public DateTime? AnswerFileUploadDate { get; set; }

        // Date of the last update, optional
        public DateTime? LastUpdated { get; set; }
    }
}
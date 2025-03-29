using System;

namespace NguyenHuynhNam_2015.DTOs
{
    // DTO for Digital Exam data
    public class DigitalExamDTO
    {
        public int? DigitalExamId { get; set; }

        public int? TranscriptId { get; set; }

        // File path for the exam script image
        public string? ExamFilePath { get; set; }

        // Upload time for the exam script file
        public DateTime? ExamFileUploadDate { get; set; }

        // File path for the answer key
        public string? AnswerFilePath { get; set; }

        // Upload time for the answer file
        public DateTime? AnswerFileUploadDate { get; set; }

        // Last update time
        public DateTime? LastUpdated { get; set; }
    }
}
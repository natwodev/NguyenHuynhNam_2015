namespace NguyenHuynhNam_2015.DTOs
{
    public class TranscriptDTO
    {
        public int TranscriptId { get; set; }
        
        public string? StudentId { get; set; }
        
        public string? SubjectId { get; set; }
        
        public string? SubjectName { get; set; } // Tên môn học
        
        public double? ComponentScore { get; set; }
        
        public double? MidtermScore { get; set; }
        
        public double? FinalScore { get; set; }
        
        public double? TotalScore { get; set; }
        
        public double? ScoreAfterRegrade { get; set; }
        
        public int? SemesterId { get; set; }
        
        public string? SemesterName { get; set; } // Tên học kỳ
    }
}
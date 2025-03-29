using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Repositories
{
    public class TranscriptRepository : ITranscriptRepository
    {
        private readonly ApplicationDbContext _context;

        public TranscriptRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TranscriptDTO>> GetAllAsync()
        {
            return await _context.Transcripts
                .Include(t => t.Subject)
                .Include(t => t.Semester)
                .Select(t => new TranscriptDTO
                {
                    TranscriptId = t.TranscriptId,
                    StudentId = t.StudentId,
                    SubjectId = t.SubjectId,
                    SubjectName = t.Subject.SubjectName, // Lấy tên môn học
                    ComponentScore = t.ComponentScore,
                    MidtermScore = t.MidtermScore,
                    FinalScore = t.FinalScore,
                    TotalScore = t.TotalScore,
                    ScoreAfterRegrade = t.ScoreAfterRegrade,
                    SemesterId = t.SemesterId,
                    SemesterName = t.Semester.SemesterName // Lấy tên học kỳ
                }).ToListAsync();
        }

        public async Task<TranscriptDTO?> GetByIdAsync(int id)
        {
            var transcript = await _context.Transcripts
                .Include(t => t.Subject)
                .Include(t => t.Semester)
                .FirstOrDefaultAsync(t => t.TranscriptId == id);

            if (transcript == null) return null;

            return new TranscriptDTO
            {
                TranscriptId = transcript.TranscriptId,
                StudentId = transcript.StudentId,
                SubjectId = transcript.SubjectId,
                SubjectName = transcript.Subject?.SubjectName, // Lấy tên môn học
                ComponentScore = transcript.ComponentScore,
                MidtermScore = transcript.MidtermScore,
                FinalScore = transcript.FinalScore,
                TotalScore = transcript.TotalScore,
                ScoreAfterRegrade = transcript.ScoreAfterRegrade,
                SemesterId = transcript.SemesterId,
                SemesterName = transcript.Semester?.SemesterName // Lấy tên học kỳ
            };
        }
        
        
        public async Task<IEnumerable<TranscriptDTO>> GetByStudentIdAsync(string studentId)
        {
            return await _context.Transcripts
                .Where(t => t.StudentId == studentId)
                .Include(t => t.Subject)
                .Include(t => t.Semester)
                .Select(t => new TranscriptDTO
                {
                    TranscriptId = t.TranscriptId,
                    StudentId = t.StudentId,
                    SubjectId = t.SubjectId,
                    SubjectName = t.Subject.SubjectName,
                    ComponentScore = t.ComponentScore,
                    MidtermScore = t.MidtermScore,
                    FinalScore = t.FinalScore,
                    TotalScore = t.TotalScore,
                    ScoreAfterRegrade = t.ScoreAfterRegrade,
                    SemesterId = t.SemesterId,
                    SemesterName = t.Semester.SemesterName
                }).ToListAsync();
        }
    }
}

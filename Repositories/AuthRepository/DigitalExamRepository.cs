using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenHuynhNam_2015.Repositories
{
    // Repository for Digital Exam data
    public class DigitalExamRepository : IDigitalExamRepository
    {
        private readonly ApplicationDbContext _context;

        public DigitalExamRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Retrieve all digital exam records
        public async Task<IEnumerable<DigitalExamDTO>> GetAllDigitalExamsAsync()
        {
            return await _context.DigitalExams
                .Select(de => new DigitalExamDTO
                {
                    DigitalExamId = de.DigitalExamId,
                    TranscriptId = de.TranscriptId,
                    ExamFilePath = de.ExamFilePath,
                    ExamFileUploadDate = de.ExamFileUploadDate,
                    AnswerFilePath = de.AnswerFilePath,
                    AnswerFileUploadDate = de.AnswerFileUploadDate,
                    LastUpdated = de.LastUpdated
                })
                .ToListAsync();
        }

        // Retrieve a specific digital exam record by its Id
        public async Task<DigitalExamDTO?> GetDigitalExamByIdAsync(int id)
        {
            return await _context.DigitalExams
                .Where(de => de.DigitalExamId == id)
                .Select(de => new DigitalExamDTO
                {
                    DigitalExamId = de.DigitalExamId,
                    TranscriptId = de.TranscriptId,
                    ExamFilePath = de.ExamFilePath,
                    ExamFileUploadDate = de.ExamFileUploadDate,
                    AnswerFilePath = de.AnswerFilePath,
                    AnswerFileUploadDate = de.AnswerFileUploadDate,
                    LastUpdated = de.LastUpdated
                })
                .FirstOrDefaultAsync();
        }
    }
}
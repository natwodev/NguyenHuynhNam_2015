using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services
{
    public interface ITranscriptService
    {
        Task<IEnumerable<TranscriptDTO>> GetAllAsync();
        Task<TranscriptDTO?> GetByIdAsync(int id);
        Task<IEnumerable<TranscriptDTO>> GetByStudentIdAsync(string studentId); // Thêm phương thức mới

    }
    
}
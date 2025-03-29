using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Repositories
{
    public interface ITranscriptRepository
    {
        Task<IEnumerable<TranscriptDTO>> GetAllAsync();
        Task<TranscriptDTO?> GetByIdAsync(int id);
        Task<IEnumerable<TranscriptDTO>> GetByStudentIdAsync(string studentId); // Thêm phương thức mới

    }
}

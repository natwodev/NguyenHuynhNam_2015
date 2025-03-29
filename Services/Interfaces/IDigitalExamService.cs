using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Services
{
    // Interface for Digital Exam Service operations
    public interface IDigitalExamService
    {
        Task<IEnumerable<DigitalExamDTO>> GetAllAsync();
        Task<DigitalExamDTO?> GetByIdAsync(int id);
    }
}
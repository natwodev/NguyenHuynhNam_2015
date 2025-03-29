using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Repositories
{
    // Interface for Digital Exam Repository
    public interface IDigitalExamRepository
    {
        Task<IEnumerable<DigitalExamDTO>> GetAllDigitalExamsAsync();
        Task<DigitalExamDTO?> GetDigitalExamByIdAsync(int id);
    }
}
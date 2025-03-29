using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Services
{
    // Interface for Student Service operations
    public interface IStudentService
    {
        Task<IEnumerable<StudentDTO>> GetAllAsync();
        Task<StudentDTO?> GetByIdAsync(string id);
        
        // Retrieve students filtered by their birth year
        Task<IEnumerable<StudentDTO>> GetStudentsByYearAsync(int year);
    }
}
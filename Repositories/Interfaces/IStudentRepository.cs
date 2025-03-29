using NguyenHuynhNam_2015.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NguyenHuynhNam_2015.Repositories
{
    // Interface for Student Repository
    public interface IStudentRepository
    {
        Task<IEnumerable<StudentDTO>> GetAllStudentsAsync();
        Task<StudentDTO?> GetStudentByIdAsync(string id);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Repositories
{
    public interface ILecturerRepository
    {
        Task<IEnumerable<LecturerDTO>> GetAllLecturersAsync();
        Task<LecturerDTO?> GetLecturerByIdAsync(string id);

        Task<IEnumerable<LecturerDTO>> GetLecturersByDepartmentIdAsync(string departmentId);
        /*
        Task AddLecturerAsync(Lecturer lecturer);
        Task UpdateLecturerAsync(Lecturer lecturer);
        Task DeleteLecturerAsync(string lecturerId);
        */
    }
}
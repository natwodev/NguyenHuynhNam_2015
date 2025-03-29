using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Services
{
    public interface ILecturerService
    {
        Task<IEnumerable<LecturerDTO>> GetAllAsync();
        Task<LecturerDTO?> GetByIdAsync(string id);
        Task<IEnumerable<LecturerDTO>> GetByDepartmentIdAsync(string departmentId);

    }
}
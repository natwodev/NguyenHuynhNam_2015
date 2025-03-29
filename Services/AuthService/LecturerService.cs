using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly ILecturerRepository _lecturerRepository;

        public LecturerService(ILecturerRepository lecturerRepository)
        {
            _lecturerRepository = lecturerRepository;
        }

        public async Task<IEnumerable<LecturerDTO>> GetAllAsync()
        {
            return await _lecturerRepository.GetAllLecturersAsync();
        }

        public async Task<LecturerDTO?> GetByIdAsync(string id)
        {
            return await _lecturerRepository.GetLecturerByIdAsync(id);
        }
        public async Task<IEnumerable<LecturerDTO>> GetByDepartmentIdAsync(string departmentId)
        {
            return await _lecturerRepository.GetLecturersByDepartmentIdAsync(departmentId);
        }

    }
}
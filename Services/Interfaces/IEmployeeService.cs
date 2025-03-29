using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Services
{
    // Interface for Employee Service operations
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDTO>> GetAllAsync();
        Task<EmployeeDTO> GetByIdAsync(string id);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Repositories
{
    // Interface for Employee Repository
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync();
        Task<EmployeeDTO> GetEmployeeByIdAsync(string id);
    }
}
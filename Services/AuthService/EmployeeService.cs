using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services
{
    // Service for handling employee-related operations
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        // Retrieve all employees
        public async Task<IEnumerable<EmployeeDTO>> GetAllAsync()
        {
            return await _employeeRepository.GetAllEmployeesAsync();
        }

        // Retrieve an employee by their Id
        public async Task<EmployeeDTO> GetByIdAsync(string id)
        {
            return await _employeeRepository.GetEmployeeByIdAsync(id);
        }
    }
}
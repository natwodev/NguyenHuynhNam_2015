using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;
using NguyenHuynhNam_2015.Data;

namespace NguyenHuynhNam_2015.Repositories
{
    // Repository for Employee data
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all employees with their associated position data
        public async Task<IEnumerable<EmployeeDTO>> GetAllEmployeesAsync()
        {
            return await _context.Employees
                .Include(emp => emp.Position)
                .Select(emp => new EmployeeDTO
                {
                    EmployeeId = emp.EmployeeId,
                    FullName = emp.FullName,
                    DateOfBirth = emp.DateOfBirth,
                    Email = emp.Email,
                    PhoneNumber = emp.PhoneNumber,
                    Gender = emp.Gender,
                    Address = emp.Address,
                    CitizenId = emp.CitizenId,
                    Image = emp.Image,
                    PositionId = emp.PositionId,
                    PositionName = emp.Position.PositionName
                })
                .ToListAsync();
        }

        // Get an employee by id with their associated position data
        public async Task<EmployeeDTO> GetEmployeeByIdAsync(string id)
        {
            return await _context.Employees
                .Include(emp => emp.Position)
                .Where(emp => emp.EmployeeId == id)
                .Select(emp => new EmployeeDTO
                {
                    EmployeeId = emp.EmployeeId,
                    FullName = emp.FullName,
                    DateOfBirth = emp.DateOfBirth,
                    Email = emp.Email,
                    PhoneNumber = emp.PhoneNumber,
                    Gender = emp.Gender,
                    Address = emp.Address,
                    CitizenId = emp.CitizenId,
                    Image = emp.Image,
                    PositionId = emp.PositionId,
                    PositionName = emp.Position.PositionName
                })
                .FirstOrDefaultAsync();
        }
    }
}

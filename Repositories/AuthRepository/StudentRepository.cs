using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenHuynhNam_2015.Repositories
{
    // Repository for Student data
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all students with their associated Class, Department, and Major data
        public async Task<IEnumerable<StudentDTO>> GetAllStudentsAsync()
        {
            return await _context.Students
                .Include(s => s.Class)             // Join with the Class table
                    .ThenInclude(c => c.Department) // Join with the Department table
                .Include(s => s.Major)              // Join with the Major table (optional)
                .Select(s => new StudentDTO
                {
                    StudentId = s.StudentId,
                    FullName = s.FullName,
                    DateOfBirth = s.DateOfBirth,
                    CitizenId = s.CitizenId,
                    Email = s.Email,
                    PhoneNumber = s.PhoneNumber,
                    Gender = s.Gender,
                    Address = s.Address,
                    Image = s.Image,

                    ClassId = s.ClassId,
                    ClassName = s.Class.ClassName,

                    DepartmentId = s.Class.DepartmentId,
                    DepartmentName = s.Class.Department.DepartmentName,

                    MajorId = s.Major != null ? s.Major.MajorId : null,
                    MajorName = s.Major != null ? s.Major.MajorName : null
                })
                .ToListAsync();
        }

        // Get a specific student by id with their associated Class, Department, and Major data
        public async Task<StudentDTO?> GetStudentByIdAsync(string id)
        {
            return await _context.Students
                .Include(s => s.Class)             // Join with the Class table
                    .ThenInclude(c => c.Department) // Join with the Department table
                .Include(s => s.Major)              // Join with the Major table (optional)
                .Where(s => s.StudentId == id)
                .Select(s => new StudentDTO
                {
                    StudentId = s.StudentId,
                    FullName = s.FullName,
                    DateOfBirth = s.DateOfBirth,
                    CitizenId = s.CitizenId,
                    Email = s.Email,
                    PhoneNumber = s.PhoneNumber,
                    Gender = s.Gender,
                    Address = s.Address,
                    Image = s.Image,

                    ClassId = s.ClassId,
                    ClassName = s.Class.ClassName,

                    DepartmentId = s.Class.DepartmentId,
                    DepartmentName = s.Class.Department.DepartmentName,

                    MajorId = s.Major != null ? s.Major.MajorId : null,
                    MajorName = s.Major != null ? s.Major.MajorName : null
                })
                .FirstOrDefaultAsync();
        }
    }
}

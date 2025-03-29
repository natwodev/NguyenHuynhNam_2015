using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenHuynhNam_2015.Repositories
{
    public class LecturerRepository : ILecturerRepository
    {
        private readonly ApplicationDbContext _context;

        public LecturerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<LecturerDTO>> GetAllLecturersAsync()
        {
            return await _context.Lecturers
                .Include(l => l.Department)
                .Select(l => new LecturerDTO
                {
                    LecturerId = l.LecturerId,
                    FullName = l.FullName,
                    DateOfBirth = l.DateOfBirth,
                    CitizenId = l.CitizenId,
                    Email = l.Email,
                    PhoneNumber = l.PhoneNumber,
                    Gender = l.Gender,
                    Address = l.Address,
                    Image = l.Image,
                    DepartmentId = l.DepartmentId
                })
                .ToListAsync();
        }

        public async Task<LecturerDTO?> GetLecturerByIdAsync(string id)
        {
            return await _context.Lecturers
                .Include(l => l.Department)
                .Where(l => l.LecturerId == id)
                .Select(l => new LecturerDTO
                {
                    LecturerId = l.LecturerId,
                    FullName = l.FullName,
                    DateOfBirth = l.DateOfBirth,
                    CitizenId = l.CitizenId,
                    Email = l.Email,
                    PhoneNumber = l.PhoneNumber,
                    Gender = l.Gender,
                    Address = l.Address,
                    Image = l.Image,
                    DepartmentId = l.DepartmentId
                })
                .FirstOrDefaultAsync();
        }
        
        public async Task<IEnumerable<LecturerDTO>> GetLecturersByDepartmentIdAsync(string departmentId)
        {
            return await _context.Lecturers
                .Include(l => l.Department)
                .Where(l => l.DepartmentId == departmentId)
                .Select(l => new LecturerDTO
                {
                    LecturerId = l.LecturerId,
                    FullName = l.FullName,
                    DateOfBirth = l.DateOfBirth,
                    CitizenId = l.CitizenId,
                    Email = l.Email,
                    PhoneNumber = l.PhoneNumber,
                    Gender = l.Gender,
                    Address = l.Address,
                    Image = l.Image,
                    DepartmentId = l.DepartmentId,
                    DepartmentName = l.Department != null ? l.Department.DepartmentName : null  // 🔥 Kiểm tra null
                })
                .ToListAsync();
        }

/*các chức năng khác 
        public async Task AddLecturerAsync(Lecturer lecturer)
        {
            await _context.Lecturers.AddAsync(lecturer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLecturerAsync(Lecturer lecturer)
        {
            _context.Lecturers.Update(lecturer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLecturerAsync(string lecturerId)
        {
            var lecturer = await _context.Lecturers.FindAsync(lecturerId);
            if (lecturer != null)
            {
                _context.Lecturers.Remove(lecturer);
                await _context.SaveChangesAsync();
            }
        }
        */
    }
}

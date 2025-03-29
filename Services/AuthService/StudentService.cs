using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services
{
    // Service for handling student-related operations
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // Retrieve all students
        public async Task<IEnumerable<StudentDTO>> GetAllAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }

        // Retrieve a student by their Id
        public async Task<StudentDTO?> GetByIdAsync(string id)
        {
            return await _studentRepository.GetStudentByIdAsync(id);
        }
        
        // Retrieve students filtered by their birth year
        public async Task<IEnumerable<StudentDTO>> GetStudentsByYearAsync(int year)
        {
            var students = await _studentRepository.GetAllStudentsAsync();

            return students
                .Where(s => s.DateOfBirth.Year == year) // Filter students by the year of birth
                .ToList();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services
{
    // Service for handling digital exam operations
    public class DigitalExamService : IDigitalExamService
    {
        private readonly IDigitalExamRepository _digitalExamRepository;

        public DigitalExamService(IDigitalExamRepository digitalExamRepository)
        {
            _digitalExamRepository = digitalExamRepository;
        }

        // Retrieve all digital exam records
        public async Task<IEnumerable<DigitalExamDTO>> GetAllAsync()
        {
            return await _digitalExamRepository.GetAllDigitalExamsAsync();
        }

        // Retrieve a specific digital exam record by its Id
        public async Task<DigitalExamDTO?> GetByIdAsync(int id)
        {
            return await _digitalExamRepository.GetDigitalExamByIdAsync(id);
        }
    }
}
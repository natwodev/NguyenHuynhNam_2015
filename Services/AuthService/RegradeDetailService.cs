using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services
{
    // Service for handling regrade detail operations
    public class RegradeDetailService : IRegradeDetailService
    {
        private readonly IRegradeDetailRepository _regradeDetailRepository;

        public RegradeDetailService(IRegradeDetailRepository regradeDetailRepository)
        {
            _regradeDetailRepository = regradeDetailRepository;
        }

        // Retrieve all regrade details
        public async Task<IEnumerable<RegradeDetailDTO>> GetAllAsync()
        {
            return await _regradeDetailRepository.GetAllRegradeDetailsAsync();
        }

        // Retrieve a specific regrade detail by its Id
        public async Task<RegradeDetailDTO?> GetByIdAsync(int id)
        {
            return await _regradeDetailRepository.GetRegradeDetailByIdAsync(id);
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Services
{
    // Interface for Regrade Detail Service operations
    public interface IRegradeDetailService
    {
        Task<IEnumerable<RegradeDetailDTO>> GetAllAsync();
        Task<RegradeDetailDTO?> GetByIdAsync(int id);
    }
}
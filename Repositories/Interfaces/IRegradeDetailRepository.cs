using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;

namespace NguyenHuynhNam_2015.Repositories
{
    // Interface for Regrade Detail Repository
    public interface IRegradeDetailRepository
    {
        Task<IEnumerable<RegradeDetailDTO>> GetAllRegradeDetailsAsync();
        Task<RegradeDetailDTO?> GetRegradeDetailByIdAsync(int id);
    }
}
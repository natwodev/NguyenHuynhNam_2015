using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Enums;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Services
{
    // Interface for Regrade Request Service operations
    public interface IRegradeRequestService
    {
        Task<IEnumerable<RegradeRequestDTO>> GetAllAsync();
        Task<RegradeRequestDTO?> GetByIdAsync(int id);
        Task<RegradeRequest> CreateAsync(RegradeRequest request);
        Task<bool> CancelAsync(int id);
        Task<bool> UpdateStatusAsync(int id, RegradeStatus newStatus,string approvingEmployeeId); 

    }
}
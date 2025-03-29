using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Enums;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Repositories
{
    // Interface for Regrade Request Repository
    public interface IRegradeRequestRepository
    {
        Task<IEnumerable<RegradeRequestDTO>> GetAllRegradeRequestsAsync();
        Task<RegradeRequestDTO?> GetRegradeRequestByIdAsync(int id);
        Task<RegradeRequest> CreateRegradeRequestAsync(RegradeRequest request);
        Task<bool> CancelRegradeRequestAsync(int id);
        Task<bool> IsTranscriptAlreadyRequestedAsync(int transcriptId);

        Task<bool> UpdateStatusAsync(int id, RegradeStatus newStatus, string approvingEmployeeId);

    }
}
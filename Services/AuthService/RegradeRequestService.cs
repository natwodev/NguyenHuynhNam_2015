using System.Collections.Generic;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Enums;
using NguyenHuynhNam_2015.Repositories;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Services
{
    // Service for handling regrade request operations
    public class RegradeRequestService : IRegradeRequestService
    {
        private readonly IRegradeRequestRepository _regradeRequestRepository;

        public RegradeRequestService(IRegradeRequestRepository regradeRequestRepository)
        {
            _regradeRequestRepository = regradeRequestRepository;
        }

        // Retrieve all regrade requests
        public async Task<IEnumerable<RegradeRequestDTO>> GetAllAsync()
        {
            return await _regradeRequestRepository.GetAllRegradeRequestsAsync();
        }

        // Retrieve a specific regrade request by its Id
        public async Task<RegradeRequestDTO?> GetByIdAsync(int id)
        {
            return await _regradeRequestRepository.GetRegradeRequestByIdAsync(id);
        }

        // Create a new regrade request
        public async Task<RegradeRequest?> CreateAsync(RegradeRequest request)
        {
            // Kiểm tra nếu đã có đơn phúc khảo cho Transcript này
            bool exists = await _regradeRequestRepository.IsTranscriptAlreadyRequestedAsync(request.TranscriptId);
            if (exists)
            {
                return null; // Hoặc throw exception
            }

            return await _regradeRequestRepository.CreateRegradeRequestAsync(request);
        }


        // Cancel a regrade request
        public async Task<bool> CancelAsync(int id)
        {
            return await _regradeRequestRepository.CancelRegradeRequestAsync(id);
        }
        
        // Cập nhật trạng thái của đơn phúc khảo
        public async Task<bool> UpdateStatusAsync(int id, RegradeStatus newStatus,string approvingEmployeeId)
        {
            return await _regradeRequestRepository.UpdateStatusAsync(id, newStatus,approvingEmployeeId);
        }
        
    }
}
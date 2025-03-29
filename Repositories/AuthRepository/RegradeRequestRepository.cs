using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NguyenHuynhNam_2015.Enums;
using NguyenHuynhNam_2015.Models;

namespace NguyenHuynhNam_2015.Repositories
{
    // Repository for Regrade Request data
    public class RegradeRequestRepository : IRegradeRequestRepository
    {
        private readonly ApplicationDbContext _context;

        public RegradeRequestRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all regrade requests along with related Student, Approving Employee, Semester, and Transcript data
        public async Task<IEnumerable<RegradeRequestDTO>> GetAllRegradeRequestsAsync()
        {
            return await _context.RegradeRequests
                .Include(r => r.Student)
                .Include(r => r.ApprovingEmployee)
                .Include(r => r.Semester)
                .Include(r => r.Transcript)
                .Select(r => new RegradeRequestDTO
                {
                    RegradeRequestId = r.RegradeRequestId,
                    SemesterId = r.SemesterId,
                    SemesterName = r.Semester != null ? r.Semester.SemesterName : null,
                    RequestCreationDate = r.RequestCreationDate,
                    Reason = r.Reason,
                    DesiredScore = r.DesiredScore,
                    Status = r.Status,
                    EmployeeNote = r.EmployeeNote,
                    TranscriptId = r.TranscriptId,
                    FinalScore = r.Transcript != null ? r.Transcript.FinalScore : null,
                    StudentId = r.StudentId,
                    StudentFullName = r.Student != null ? r.Student.FullName : null,
                    ApprovingEmployeeId = r.ApprovingEmployeeId,
                    ApprovingEmployeeFullName = r.ApprovingEmployee != null ? r.ApprovingEmployee.FullName : null,
                    IsCancelled = r.IsCancelled
                })
                .ToListAsync();
        }

        // Get a specific regrade request by its Id along with related data
        public async Task<RegradeRequestDTO?> GetRegradeRequestByIdAsync(int id)
        {
            return await _context.RegradeRequests
                .Include(r => r.Student)
                .Include(r => r.ApprovingEmployee)
                .Include(r => r.Semester)
                .Include(r => r.Transcript)
                .Where(r => r.RegradeRequestId == id)
                .Select(r => new RegradeRequestDTO
                {
                    RegradeRequestId = r.RegradeRequestId,
                    SemesterId = r.SemesterId,
                    SemesterName = r.Semester != null ? r.Semester.SemesterName : null,
                    RequestCreationDate = r.RequestCreationDate,
                    Reason = r.Reason,
                    DesiredScore = r.DesiredScore,
                    Status = r.Status,
                    EmployeeNote = r.EmployeeNote,
                    TranscriptId = r.TranscriptId,
                    FinalScore = r.Transcript != null ? r.Transcript.FinalScore : null,
                    StudentId = r.StudentId,
                    StudentFullName = r.Student != null ? r.Student.FullName : null,
                    ApprovingEmployeeId = r.ApprovingEmployeeId,
                    ApprovingEmployeeFullName = r.ApprovingEmployee != null ? r.ApprovingEmployee.FullName : null,
                    IsCancelled = r.IsCancelled
                })
                .FirstOrDefaultAsync();
        }
        // Create a new regrade request
        public async Task<RegradeRequest> CreateRegradeRequestAsync(RegradeRequest request)
        {
            _context.RegradeRequests.Add(request);
            await _context.SaveChangesAsync();
            return request;
        }

        // Cancel a regrade request by setting IsCancelled to true
        public async Task<bool> CancelRegradeRequestAsync(int id)
        {
            var request = await _context.RegradeRequests.FindAsync(id);
            if (request == null)
            {
                return false;
            }
            request.IsCancelled = true;
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> IsTranscriptAlreadyRequestedAsync(int transcriptId)
        {
            return await _context.RegradeRequests.AnyAsync(r => r.TranscriptId == transcriptId);
        }

       // Cập nhật trạng thái của đơn phúc khảo
       public async Task<bool> UpdateStatusAsync(int id, RegradeStatus newStatus, string approvingEmployeeId)
       {
           var request = await _context.RegradeRequests.FindAsync(id);
           if (request == null || request.IsCancelled)
           {
               return false; // Không tìm thấy hoặc đơn đã bị hủy
           }

           request.Status = newStatus;
           request.ApprovingEmployeeId = approvingEmployeeId; // Lưu ID của người cập nhật
           await _context.SaveChangesAsync();
           return true;
       }

 

    }
}

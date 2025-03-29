using Microsoft.EntityFrameworkCore;
using NguyenHuynhNam_2015.Data;
using NguyenHuynhNam_2015.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NguyenHuynhNam_2015.Repositories
{
    // Repository for Regrade Detail data
    public class RegradeDetailRepository : IRegradeDetailRepository
    {
        private readonly ApplicationDbContext _context;

        public RegradeDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Get all regrade details along with related RegradeRequest and Lecturer data
        public async Task<IEnumerable<RegradeDetailDTO>> GetAllRegradeDetailsAsync()
        {
            return await _context.RegradeDetails
                .Include(rd => rd.RegradeRequest)
                .Include(rd => rd.Lecturer)
                .Select(rd => new RegradeDetailDTO
                {
                    RegradeDetailId = rd.RegradeDetailId,
                    RegradeRequestId = rd.RegradeRequestId,
                    RegradeResult = rd.RegradeResult,
                    Note = rd.Note,
                    RegradeDate = rd.RegradeDate,
                    RegradeStatus = rd.RegradeStatus,
                    LecturerId = rd.LecturerId,
                    LecturerFullName = rd.Lecturer != null ? rd.Lecturer.FullName : null
                })
                .ToListAsync();
        }

        // Get a specific regrade detail by its Id along with related data
        public async Task<RegradeDetailDTO?> GetRegradeDetailByIdAsync(int id)
        {
            return await _context.RegradeDetails
                .Include(rd => rd.RegradeRequest)
                .Include(rd => rd.Lecturer)
                .Where(rd => rd.RegradeDetailId == id)
                .Select(rd => new RegradeDetailDTO
                {
                    RegradeDetailId = rd.RegradeDetailId,
                    RegradeRequestId = rd.RegradeRequestId,
                    RegradeResult = rd.RegradeResult,
                    Note = rd.Note,
                    RegradeDate = rd.RegradeDate,
                    RegradeStatus = rd.RegradeStatus,
                    LecturerId = rd.LecturerId,
                    LecturerFullName = rd.Lecturer != null ? rd.Lecturer.FullName : null
                })
                .FirstOrDefaultAsync();
        }
    }
}
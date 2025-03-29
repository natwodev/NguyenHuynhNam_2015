using NguyenHuynhNam_2015.DTOs;
using NguyenHuynhNam_2015.Repositories;

namespace NguyenHuynhNam_2015.Services;


public class TranscriptService : ITranscriptService
{
    private readonly ITranscriptRepository _transcriptRepository;

    public TranscriptService(ITranscriptRepository transcriptRepository)
    {
        _transcriptRepository = transcriptRepository;
    }

    public async Task<IEnumerable<TranscriptDTO>> GetAllAsync()
    {
        return await _transcriptRepository.GetAllAsync();
    }

    public async Task<TranscriptDTO?> GetByIdAsync(int id)
    {
        return await _transcriptRepository.GetByIdAsync(id);
    }
    
    public async Task<IEnumerable<TranscriptDTO>> GetByStudentIdAsync(string studentId)
    {
        return await _transcriptRepository.GetByStudentIdAsync(studentId);
    }
}
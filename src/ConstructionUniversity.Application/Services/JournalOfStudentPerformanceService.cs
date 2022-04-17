using ConstructionUniversity.Domain.JournalOfStudentPerformance;

namespace ConstructionUniversity.Application.Services;

internal class JournalOfStudentPerformanceService : IJournalOfStudentPerformanceService
{
    private readonly IJournalOfStudentPerformanceRepository _journalOfStudentPerformanceRepository;

    public JournalOfStudentPerformanceService(IJournalOfStudentPerformanceRepository studentPerformanceLogRepository)
    {
        _journalOfStudentPerformanceRepository = studentPerformanceLogRepository;
    }

    public async Task<StudentPerformance> NewAsync(StudentPerformance model)
    {
        return await _journalOfStudentPerformanceRepository.NewAsync(model with { Id = Guid.NewGuid() });
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _journalOfStudentPerformanceRepository.DeleteAsync(id);
    }

    public async Task<StudentPerformance?> GetAsync(Guid id)
    {
        return await _journalOfStudentPerformanceRepository.GetAsync(id);
    }

    public async Task<IReadOnlyCollection<StudentPerformance>> GetAllAsync()
    {
        return (await _journalOfStudentPerformanceRepository.GetAllAsync()).ToArray();
    }

    public async Task<StudentPerformance> UpdateAsync(Guid id, StudentPerformance model)
    {
        return await _journalOfStudentPerformanceRepository.UpdateAsync(id, model);
    }
}
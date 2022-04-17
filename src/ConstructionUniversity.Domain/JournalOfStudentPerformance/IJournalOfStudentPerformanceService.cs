namespace ConstructionUniversity.Domain.JournalOfStudentPerformance;

public interface IJournalOfStudentPerformanceService
{
    Task<StudentPerformance> NewAsync(StudentPerformance model);
    Task<StudentPerformance?> GetAsync(Guid id);
    Task<IReadOnlyCollection<StudentPerformance>> GetAllAsync();
    Task<StudentPerformance> UpdateAsync(Guid id, StudentPerformance model);
    Task<bool> DeleteAsync(Guid id);
}
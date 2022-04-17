using ConstructionUniversity.Domain.Common;

namespace ConstructionUniversity.Domain.JournalOfStudentPerformance;

public interface IJournalOfStudentPerformanceRepository : IRepository<StudentPerformance>
{
    Task<IEnumerable<StudentPerformance>> GetAllOnStudentAsync(Guid studentId);
}
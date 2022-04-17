using ConstructionUniversity.Domain.JournalOfStudentPerformance;

namespace ConstructionUniversity.Domain.Students;

public interface IStudentService
{
    Task<Student> NewAsync(Student model);
    Task<Student?> GetAsync(Guid id);
    Task<IReadOnlyCollection<Student>> GetAllAsync();
    Task<Student> UpdateAsync(Guid id, Student model);
    Task<bool> DeleteAsync(Guid id);
    Task<IReadOnlyCollection<StudentPerformance>> GetStudentPerformanceAsync(Guid id);
}
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.Domain.Students;

namespace ConstructionUniversity.Application.Services;

internal class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;
    private readonly IJournalOfStudentPerformanceRepository _studentPerformanceLogRepository;

    public StudentService(IStudentRepository studentRepository, IJournalOfStudentPerformanceRepository studentPerformanceLogRepository)
    {
        _studentRepository = studentRepository;
        _studentPerformanceLogRepository = studentPerformanceLogRepository;
    }

    public async Task<Student> NewAsync(Student model)
    {
        return await _studentRepository.NewAsync(model with { Id = Guid.NewGuid() });
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _studentRepository.DeleteAsync(id);
    }

    public async Task<Student?> GetAsync(Guid id)
    {
        return await _studentRepository.GetAsync(id);
    }

    public async Task<IReadOnlyCollection<Student>> GetAllAsync()
    {
        return (await _studentRepository.GetAllAsync()).ToArray();
    }

    public async Task<Student> UpdateAsync(Guid id, Student model)
    {
        return await _studentRepository.UpdateAsync(id, model);
    }

    public async Task<IReadOnlyCollection<StudentPerformance>> GetStudentPerformanceAsync(Guid id)
    {
        return (await _studentPerformanceLogRepository.GetAllOnStudentAsync(id)).ToArray();
    }
}
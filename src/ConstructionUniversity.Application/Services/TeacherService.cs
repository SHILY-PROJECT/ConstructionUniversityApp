using ConstructionUniversity.Domain.Teachers;

namespace ConstructionUniversity.Application.Services;

internal class TeacherService : ITeacherService
{
    private readonly ITeacherRepository _teacherRepository;

    public TeacherService(ITeacherRepository teacherRepository)
    {
        _teacherRepository = teacherRepository;
    }

    public async Task<Teacher> NewAsync(Teacher model)
    {
        return await _teacherRepository.NewAsync(model with { Id = Guid.NewGuid() });
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _teacherRepository.DeleteAsync(id);
    }

    public async Task<Teacher?> GetAsync(Guid id)
    {
        return await _teacherRepository.GetAsync(id);
    }

    public async Task<IReadOnlyCollection<Teacher>> GetAllAsync()
    {
        return (await _teacherRepository.GetAllAsync()).ToArray();
    }

    public async Task<Teacher> UpdateAsync(Guid id, Teacher model)
    {
        return await _teacherRepository.UpdateAsync(id, model);
    }
}
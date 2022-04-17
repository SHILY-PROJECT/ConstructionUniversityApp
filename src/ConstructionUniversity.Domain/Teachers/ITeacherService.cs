namespace ConstructionUniversity.Domain.Teachers;

public interface ITeacherService
{
    Task<Teacher> NewAsync(Teacher model);
    Task<Teacher?> GetAsync(Guid id);
    Task<IReadOnlyCollection<Teacher>> GetAllAsync();
    Task<Teacher> UpdateAsync(Guid id, Teacher model);
    Task<bool> DeleteAsync(Guid id);
}
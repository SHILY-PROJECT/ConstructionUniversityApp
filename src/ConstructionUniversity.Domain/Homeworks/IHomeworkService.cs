namespace ConstructionUniversity.Domain.Homeworks;

public interface IHomeworkService
{
    Task<Homework> NewAsync(Homework model);
    Task<Homework?> GetAsync(Guid id);
    Task<IReadOnlyCollection<Homework>> GetAllAsync();
    Task<Homework> UpdateAsync(Guid id, Homework model);
    Task<bool> DeleteAsync(Guid id);
}
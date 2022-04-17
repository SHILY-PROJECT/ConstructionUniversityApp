namespace ConstructionUniversity.Domain.Lessons;

public interface ILessonService
{
    Task<Lesson> NewAsync(Lesson model);
    Task<Lesson?> GetAsync(Guid id);
    Task<IReadOnlyCollection<Lesson>> GetAllAsync();
    Task<Lesson> UpdateAsync(Guid id, Lesson model);
    Task<bool> DeleteAsync(Guid id);
}
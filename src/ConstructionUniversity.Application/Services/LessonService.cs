using ConstructionUniversity.Domain.Lessons;

namespace ConstructionUniversity.Application.Services;

internal class LessonService : ILessonService
{
    private readonly ILessonRepository _lessonRepository;

    public LessonService(ILessonRepository lessonRepository)
    {
        _lessonRepository = lessonRepository;
    }

    public async Task<Lesson> NewAsync(Lesson model)
    {
        return await _lessonRepository.NewAsync(model with { Id = Guid.NewGuid() });
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _lessonRepository.DeleteAsync(id);
    }

    public async Task<Lesson?> GetAsync(Guid id)
    {
        return await _lessonRepository.GetAsync(id);
    }

    public async Task<IReadOnlyCollection<Lesson>> GetAllAsync()
    {
        return (await _lessonRepository.GetAllAsync()).ToArray();
    }

    public async Task<Lesson> UpdateAsync(Guid id, Lesson model)
    {
        return await _lessonRepository.UpdateAsync(id, model);
    }
}
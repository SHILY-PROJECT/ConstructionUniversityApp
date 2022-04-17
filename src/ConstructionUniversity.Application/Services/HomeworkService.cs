using ConstructionUniversity.Domain.Homeworks;

namespace ConstructionUniversity.Application.Services;

internal class HomeworkService : IHomeworkService
{
    private readonly IHomeworkRepository _homeworkRepository;

    public HomeworkService(IHomeworkRepository homeworkRepository)
    {
        _homeworkRepository = homeworkRepository;
    }

    public async Task<Homework> NewAsync(Homework model)
    {
        return await _homeworkRepository.NewAsync(model with { Id = Guid.NewGuid() });
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        return await _homeworkRepository.DeleteAsync(id);
    }

    public async Task<Homework?> GetAsync(Guid id)
    {
        return await _homeworkRepository.GetAsync(id);
    }

    public async Task<IReadOnlyCollection<Homework>> GetAllAsync()
    {
        return (await _homeworkRepository.GetAllAsync()).ToArray();
    }

    public async Task<Homework> UpdateAsync(Guid id, Homework model)
    {
        return await _homeworkRepository.UpdateAsync(id, model);
    }
}
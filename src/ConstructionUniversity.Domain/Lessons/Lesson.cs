using ConstructionUniversity.Domain.Teachers;

namespace ConstructionUniversity.Domain.Lessons;

public record Lesson
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTime Date { get; init; }
    public Teacher? Teacher { get; init; }
}
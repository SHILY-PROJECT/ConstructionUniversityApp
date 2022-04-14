using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Students;

namespace ConstructionUniversity.Domain.JournalOfStudentPerformance;

public record StudentPerformance
{
    public Guid Id { get; init; }
    public bool IsWas { get; init; }
    public Student Student { get; init; } = null!;
    public Lesson Lesson { get; init; } = null!;
    public Homework? Homework { get; init; }
}
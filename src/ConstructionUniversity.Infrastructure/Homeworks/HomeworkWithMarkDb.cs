using ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.Homeworks;

internal record HomeworkWithMarkDb
{
    public Guid Id { get; init; }
    public int Mark { get; init; }

    public Guid HomeworkId { get; init; }
    public HomeworkDb Homework { get; init; } = null!;

    public StudentPerformanceDb StudentPerformance { get; init; }
}
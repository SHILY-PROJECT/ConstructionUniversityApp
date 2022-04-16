using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Infrastructure.Homeworks;
using ConstructionUniversity.Infrastructure.Lessons;
using ConstructionUniversity.Infrastructure.Students;

namespace ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;

internal record StudentPerformanceDb : IGuidProperty
{
    public Guid Id { get; init; }
    public bool IsWas { get; init; }
    public int Mark { get; init; }

    public Guid StudentId { get; init; }
    public StudentDb Student { get; init; }

    public Guid HomeworkId { get; init; }
    public HomeworkDb Homework { get; init; }

    public Guid LessonId { get; init; }
    public LessonDb Lesson { get; init; }
}
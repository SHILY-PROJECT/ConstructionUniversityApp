using ConstructionUniversity.Infrastructure.Sql.Common;
using ConstructionUniversity.Infrastructure.Sql.Homeworks;
using ConstructionUniversity.Infrastructure.Sql.Lessons;
using ConstructionUniversity.Infrastructure.Sql.Students;

namespace ConstructionUniversity.Infrastructure.Sql.JournalOfStudentPerformance;

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
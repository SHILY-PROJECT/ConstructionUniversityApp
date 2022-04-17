using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Infrastructure.Teachers;

namespace ConstructionUniversity.Infrastructure.Lessons;

internal record LessonDb : IGuidProperty
{
    public Guid Id { get; init; }
    public DateTime Date { get; init; }
    public string Name { get; init; } = string.Empty;

    public Guid TeacherId { get; init; }
    public TeacherDb Teacher { get; init; }
}
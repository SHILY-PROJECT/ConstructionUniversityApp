using ConstructionUniversity.Infrastructure.Sql.Common;
using ConstructionUniversity.Infrastructure.Sql.Teachers;

namespace ConstructionUniversity.Infrastructure.Sql.Lessons;

internal record LessonDb : IGuidProperty
{
    public Guid Id { get; init; }
    public DateTime Date { get; init; }
    public string Name { get; init; } = string.Empty;

    public Guid TeacherId { get; init; }
    public TeacherDb Teacher { get; init; }
}
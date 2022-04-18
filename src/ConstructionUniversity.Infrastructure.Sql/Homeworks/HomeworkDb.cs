using ConstructionUniversity.Infrastructure.Sql.Common;
using ConstructionUniversity.Infrastructure.Sql.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.Sql.Homeworks;

internal record HomeworkDb : IGuidProperty
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Discription { get; init; }
}
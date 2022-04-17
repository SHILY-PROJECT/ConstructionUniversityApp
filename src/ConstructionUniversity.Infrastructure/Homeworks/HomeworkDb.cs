using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.Homeworks;

internal record HomeworkDb : IGuidProperty
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Discription { get; init; }
}
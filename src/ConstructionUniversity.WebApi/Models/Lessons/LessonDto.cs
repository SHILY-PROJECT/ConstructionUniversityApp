using ConstructionUniversity.WebApi.Models.Teachers;
using System;

namespace ConstructionUniversity.WebApi.Models.Lessons;

public record LessonDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTime Date { get; init; }
    public TeacherDto Teacher { get; init; }
}
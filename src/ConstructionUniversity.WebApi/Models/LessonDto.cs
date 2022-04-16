using System;

namespace ConstructionUniversity.WebApi.Models;

public record LessonDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public DateTime Date { get; init; }
    public TeacherDto Teacher { get; init; }
}
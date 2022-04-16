using System;

namespace ConstructionUniversity.WebApi.Models;

public record StudentPerformanceDto
{
    public Guid Id { get; init; }
    public bool IsWas { get; init; }
    public StudentDto Student { get; init; }
    public LessonDto Lesson { get; init; }
    public HomeworkDto Homework { get; init; }
    public int Mark { get; init; }
}
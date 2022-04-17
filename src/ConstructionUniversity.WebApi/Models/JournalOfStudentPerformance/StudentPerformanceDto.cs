using ConstructionUniversity.WebApi.Models.Homeworks;
using ConstructionUniversity.WebApi.Models.Lessons;
using ConstructionUniversity.WebApi.Models.Students;
using System;

namespace ConstructionUniversity.WebApi.Models.JournalOfStudentPerformance;

public record StudentPerformanceDto
{
    public Guid Id { get; init; }
    public bool IsWas { get; init; }
    public StudentDto Student { get; init; }
    public LessonDto Lesson { get; init; }
    public HomeworkDto Homework { get; init; }
    public int Mark { get; init; }
}
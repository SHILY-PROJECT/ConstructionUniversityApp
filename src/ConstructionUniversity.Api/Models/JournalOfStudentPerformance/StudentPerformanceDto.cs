using ConstructionUniversity.Api.Models.Homeworks;
using ConstructionUniversity.Api.Models.Lessons;
using ConstructionUniversity.Api.Models.Students;
using System;

namespace ConstructionUniversity.Api.Models.JournalOfStudentPerformance;

public record StudentPerformanceDto
{
    public Guid Id { get; init; }
    public bool IsWas { get; init; }
    public StudentDto Student { get; init; }
    public LessonDto Lesson { get; init; }
    public HomeworkDto Homework { get; init; }
    public int Mark { get; init; }
}
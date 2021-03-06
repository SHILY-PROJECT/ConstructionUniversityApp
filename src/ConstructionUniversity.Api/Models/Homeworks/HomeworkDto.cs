using System;

namespace ConstructionUniversity.Api.Models.Homeworks;

public record HomeworkDto
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Discription { get; init; } = string.Empty;
}
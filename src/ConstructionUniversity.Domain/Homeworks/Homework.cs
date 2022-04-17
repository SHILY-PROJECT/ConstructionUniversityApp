namespace ConstructionUniversity.Domain.Homeworks;

public record Homework
{
    public Guid Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string Discription { get; init; } = string.Empty;
}
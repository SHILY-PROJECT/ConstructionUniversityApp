namespace ConstructionUniversity.Infrastructure.Common;

public class DatabaseCreationSettings
{
    public bool ReCreateDatabaseAtFirstStartup { get; set; }
    public bool CreateDatabaseWithTestData { get; set; }
}
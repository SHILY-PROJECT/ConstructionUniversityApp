namespace ConstructionUniversity.Infrastructure.Sql.Common;

public class DatabaseCreationSettings
{
    public bool ReCreateDatabaseAtFirstStartup { get; set; }
    public bool CreateDatabaseWithTestData { get; set; }
}
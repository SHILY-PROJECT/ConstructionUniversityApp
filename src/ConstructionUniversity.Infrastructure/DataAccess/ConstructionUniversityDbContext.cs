using Microsoft.EntityFrameworkCore;
using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Infrastructure.Students;
using ConstructionUniversity.Infrastructure.Teachers;
using ConstructionUniversity.Infrastructure.Lessons;
using ConstructionUniversity.Infrastructure.Homeworks;
using ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;
using ConstructionUniversity.Infrastructure.DataAccess.Configuration;

namespace ConstructionUniversity.Infrastructure.DataAccess;

internal class ConstructionUniversityDbContext : DbContext
{
    private static bool _isDeletedDatabaseAtFirstStartup;
    private readonly DatabaseCreationSettings _databaseCreationSettings;

    public ConstructionUniversityDbContext(DbContextOptions<ConstructionUniversityDbContext> options, DatabaseCreationSettings databaseCreationSettings) : base(options)
    {
        _databaseCreationSettings = databaseCreationSettings;

        if (_databaseCreationSettings.ReCreateDatabaseAtFirstStartup && !_isDeletedDatabaseAtFirstStartup)
        {
            Database.EnsureDeleted();
            _isDeletedDatabaseAtFirstStartup = true;
        }

        Database.EnsureCreated();
    }

    public DbSet<TeacherDb> Teachers { get; set; } = null!;
    public DbSet<StudentDb> Students { get; set; } = null!;
    public DbSet<LessonDb> Lessons { get; set; } = null!;
    public DbSet<HomeworkDb> Homeworks { get; set; } = null!;
    public DbSet<StudentPerformanceDb> JournalOfStudentPerformance { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfiguration(new LessonConfiguration())
            .ApplyConfiguration(new StudentConfiguration())
            .ApplyConfiguration(new TeacherConfiguration())
            .ApplyConfiguration(new HomeworkConfiguration())
            .ApplyConfiguration(new JournalOfStudentPerformanceConfiguration());

        if (_databaseCreationSettings.CreateDatabaseWithTestData)
        {
            modelBuilder.ApplyTestData();
        }

        base.OnModelCreating(modelBuilder);
    }
}
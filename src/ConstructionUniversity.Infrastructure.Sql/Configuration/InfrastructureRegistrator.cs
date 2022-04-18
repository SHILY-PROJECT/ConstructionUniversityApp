using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Infrastructure.Sql.Common;
using ConstructionUniversity.Infrastructure.Sql.Students;
using ConstructionUniversity.Infrastructure.Sql.Teachers;
using ConstructionUniversity.Infrastructure.Sql.Lessons;
using ConstructionUniversity.Infrastructure.Sql.Homeworks;
using ConstructionUniversity.Infrastructure.Sql.DataAccess;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.Infrastructure.Sql.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.Sql.Configuration;

public static class InfrastructureRegistrator
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString, DatabaseCreationSettings? databaseCreationSettings = null)
    {
        services
            .AddScoped<ITeacherRepository, TeacherRepository>()
            .AddScoped<IStudentRepository, StudentRepository>()
            .AddScoped<ILessonRepository, LessonRepository>()
            .AddScoped<IHomeworkRepository, HomeworkRepository>()
            .AddScoped<IJournalOfStudentPerformanceRepository, JournalOfStudentPerformanceRepository>();

        services.AddScoped(x => databaseCreationSettings ?? new());

        services
            .AddAutoMapper(typeof(MapperProfile))
            .AddDbContext<ConstructionUniversityDbContext>(options => options.UseSqlServer(connectionString));

        return services;
    }
}
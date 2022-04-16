using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Infrastructure.Students;
using ConstructionUniversity.Infrastructure.Teachers;
using ConstructionUniversity.Infrastructure.Lessons;
using ConstructionUniversity.Infrastructure.Homeworks;
using ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;
using ConstructionUniversity.Infrastructure.DataAccess;

namespace ConstructionUniversity.Infrastructure.Configuration;

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
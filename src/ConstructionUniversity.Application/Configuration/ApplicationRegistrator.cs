using Microsoft.Extensions.DependencyInjection;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Application.Services;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;

namespace ConstructionUniversity.Application.Configuration;

public static class ApplicationRegistrator
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services
            .AddScoped<IHomeworkService, HomeworkService>()
            .AddScoped<ILessonService, LessonService>()
            .AddScoped<ITeacherService, TeacherService>()
            .AddScoped<IStudentService, StudentService>()
            .AddScoped<IJournalOfStudentPerformanceService, JournalOfStudentPerformanceService>();

        return services;
    }
}
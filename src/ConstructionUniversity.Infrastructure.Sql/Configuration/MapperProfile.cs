using AutoMapper;
using ConstructionUniversity.Infrastructure.Sql.Homeworks;
using ConstructionUniversity.Infrastructure.Sql.Lessons;
using ConstructionUniversity.Infrastructure.Sql.Students;
using ConstructionUniversity.Infrastructure.Sql.Teachers;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.Infrastructure.Sql.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.Sql.Configuration;

internal class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<TeacherDb, Teacher>().ReverseMap();
        CreateMap<StudentDb, Student>().ReverseMap();
        CreateMap<LessonDb, Lesson>().ReverseMap();
        CreateMap<HomeworkDb, Homework>().ReverseMap();
        CreateMap<StudentPerformanceDb, StudentPerformance>().ReverseMap();
    }
}
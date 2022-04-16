using AutoMapper;
using ConstructionUniversity.Infrastructure.Homeworks;
using ConstructionUniversity.Infrastructure.Lessons;
using ConstructionUniversity.Infrastructure.Students;
using ConstructionUniversity.Infrastructure.Teachers;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.Configuration;

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
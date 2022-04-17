using AutoMapper;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.WebApi.Models.Teachers;
using ConstructionUniversity.WebApi.Models.Homeworks;
using ConstructionUniversity.WebApi.Models.JournalOfStudentPerformance;
using ConstructionUniversity.WebApi.Models.Lessons;
using ConstructionUniversity.WebApi.Models.Students;

namespace ConstructionUniversity.WebApi.Configuration;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<HomeworkDto, Homework>().ReverseMap();
        CreateMap<LessonDto, Lesson>().ReverseMap();
        CreateMap<TeacherDto, Teacher>().ReverseMap();
        CreateMap<StudentDto, Student>().ReverseMap();
        CreateMap<StudentPerformanceDto, StudentPerformance>().ReverseMap();
    }
}
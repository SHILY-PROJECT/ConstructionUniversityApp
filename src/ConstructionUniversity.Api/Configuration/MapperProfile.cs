using AutoMapper;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.Api.Models.Teachers;
using ConstructionUniversity.Api.Models.Homeworks;
using ConstructionUniversity.Api.Models.JournalOfStudentPerformance;
using ConstructionUniversity.Api.Models.Lessons;
using ConstructionUniversity.Api.Models.Students;

namespace ConstructionUniversity.Api.Configuration;

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
using AutoMapper;
using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Infrastructure.DataAccess;

namespace ConstructionUniversity.Infrastructure.Students;

internal class StudentRepository : BaseRepository<Student, StudentDb>, IStudentRepository
{
    private readonly ConstructionUniversityDbContext _context;
    private readonly IMapper _mapper;

    public StudentRepository(ConstructionUniversityDbContext context, IMapper mapper) : base(context, mapper, context.Students)
    {
        _context = context;
        _mapper = mapper;
    }
}
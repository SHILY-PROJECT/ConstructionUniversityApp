using AutoMapper;
using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Infrastructure.DataAccess;

namespace ConstructionUniversity.Infrastructure.Teachers;

internal class TeacherRepository : BaseRepository<Teacher, TeacherDb>, ITeacherRepository
{
    private readonly ConstructionUniversityDbContext _context;
    private readonly IMapper _mapper;

    public TeacherRepository(ConstructionUniversityDbContext context, IMapper mapper) : base(context, mapper, context.Teachers)
    {
        _context = context;
        _mapper = mapper;
    }
}
using AutoMapper;
using ConstructionUniversity.Infrastructure.Sql.Common;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.Infrastructure.Sql.DataAccess;

namespace ConstructionUniversity.Infrastructure.Sql.Teachers;

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
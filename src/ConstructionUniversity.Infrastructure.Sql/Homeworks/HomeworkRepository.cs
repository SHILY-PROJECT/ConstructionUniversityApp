using AutoMapper;
using ConstructionUniversity.Infrastructure.Sql.Common;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Infrastructure.Sql.DataAccess;

namespace ConstructionUniversity.Infrastructure.Sql.Homeworks;

internal class HomeworkRepository : BaseRepository<Homework, HomeworkDb>, IHomeworkRepository
{
    private readonly ConstructionUniversityDbContext _context;
    private readonly IMapper _mapper;

    public HomeworkRepository(ConstructionUniversityDbContext context, IMapper mapper) : base(context, mapper, context.Homeworks)
    {
        _context = context;
        _mapper = mapper;
    }
}
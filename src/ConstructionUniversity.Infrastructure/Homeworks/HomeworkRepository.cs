using AutoMapper;
using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Infrastructure.DataAccess;

namespace ConstructionUniversity.Infrastructure.Homeworks;

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
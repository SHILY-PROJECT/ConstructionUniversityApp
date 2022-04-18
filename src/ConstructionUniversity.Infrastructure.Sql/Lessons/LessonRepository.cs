using Microsoft.EntityFrameworkCore;
using AutoMapper;
using ConstructionUniversity.Infrastructure.Sql.Common;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.Infrastructure.Sql.DataAccess;

namespace ConstructionUniversity.Infrastructure.Sql.Lessons;

internal class LessonRepository : BaseRepository<Lesson, LessonDb>, ILessonRepository
{
    private readonly ConstructionUniversityDbContext _context;
    private readonly IMapper _mapper;

    public LessonRepository(ConstructionUniversityDbContext context, IMapper mapper) : base(context, mapper, context.Lessons)
    {
        _context = context;
        _mapper = mapper;
    }

    protected virtual IQueryable<LessonDb> LessonsAsEagerIQueryable { get => _context.Lessons.Include(l => l.Teacher); }

    public override async Task<IEnumerable<Lesson>> GetAllAsync()
    {
        var entities = await LessonsAsEagerIQueryable.ToArrayAsync();
        return _mapper.Map<IReadOnlyCollection<Lesson>>(entities);
    }

    public override async Task<Lesson?> GetAsync(Guid id)
    {
        var entity = await LessonsAsEagerIQueryable.FirstOrDefaultAsync(l => l.Id == id);
        return _mapper.Map<Lesson>(entity);
    }
}
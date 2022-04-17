using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.Infrastructure.Common;
using ConstructionUniversity.Infrastructure.DataAccess;

namespace ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;

internal class JournalOfStudentPerformanceRepository : BaseRepository<StudentPerformance, StudentPerformanceDb>, IJournalOfStudentPerformanceRepository
{
    private readonly ConstructionUniversityDbContext _context;
    private readonly IMapper _mapper;

    public JournalOfStudentPerformanceRepository(ConstructionUniversityDbContext context, IMapper mapper) : base(context, mapper, context.JournalOfStudentPerformance)
    {
        _context = context;
        _mapper = mapper;
    }

    protected virtual IQueryable<StudentPerformanceDb> StudentPerformanceAsEagerIQueryable
    {
        get => _context.JournalOfStudentPerformance
            .Include(sp => sp.Student)
            .Include(sp => sp.Homework)
            .Include(sp => sp.Lesson)
            .Include(sp => sp.Lesson.Teacher);
    }

    public override async Task<IEnumerable<StudentPerformance>> GetAllAsync()
    {
        var entities = await StudentPerformanceAsEagerIQueryable.ToArrayAsync();
        return _mapper.Map<IEnumerable<StudentPerformance>>(entities);
    }

    public override async Task<StudentPerformance?> GetAsync(Guid id)
    {
        var entity = await StudentPerformanceAsEagerIQueryable.Where(sp => sp.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<StudentPerformance>(entity);
    }

    public virtual async Task<IEnumerable<StudentPerformance>> GetAllOnStudentAsync(Guid studentId)
    {
        var entities = await StudentPerformanceAsEagerIQueryable.Where(sp => sp.Student.Id == studentId).ToArrayAsync();
        return _mapper.Map<IEnumerable<StudentPerformance>>(entities);
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ConstructionUniversity.Domain.JournalOfStudentPerformance;
using ConstructionUniversity.WebApi.Models.JournalOfStudentPerformance;

namespace ConstructionUniversity.WebApi.Controllers;

[ApiController]
[Route("/api/journalOfStudentPerformance")]
public class JournalOfStudentPerformanceController : ControllerBase
{
    private readonly IJournalOfStudentPerformanceService _service;
    private readonly IMapper _mapper;

    public JournalOfStudentPerformanceController(IJournalOfStudentPerformanceService journalOfStudentPerformanceService, IMapper mapper)
    {
        _service = journalOfStudentPerformanceService;
        _mapper = mapper;
    }

    [HttpGet("{studentPerformanceId}")]
    public async Task<ActionResult<StudentPerformanceDto>> GetStudentPerformance([FromRoute] Guid studentPerformanceId)
    {
        return await _service.GetAsync(studentPerformanceId) switch
        {
            null                    => NotFound(),
            var studentPerformance  => _mapper.Map<StudentPerformanceDto>(studentPerformance)
        };
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<StudentPerformanceDto>>> GetStudentPerformanceLog()
    {
        var studentPerformanceLog = await _service.GetAllAsync();
        return _mapper.Map<StudentPerformanceDto[]>(studentPerformanceLog);
    }

    [HttpPost]
    public async Task<ActionResult<StudentPerformanceDto>> AddStudentPerformance([FromBody] StudentPerformanceDto studentPerformanceDto)
    {
        var studentPerformance = _mapper.Map<StudentPerformance>(studentPerformanceDto);
        var newStudentPerformance = await _service.NewAsync(studentPerformance);
        return _mapper.Map<StudentPerformanceDto>(newStudentPerformance);
    }

    [HttpPut]
    public async Task<ActionResult<StudentPerformanceDto>> UpdateStudentPerformance([FromBody] StudentPerformanceDto studentPerformanceDto)
    {
        var studentPerformance = _mapper.Map<StudentPerformance>(studentPerformanceDto);
        var updatedStudentPerformance = await _service.UpdateAsync(studentPerformance.Id, studentPerformance);
        return _mapper.Map<StudentPerformanceDto>(updatedStudentPerformance);
    }

    [HttpDelete("{studentPerformanceId}")]
    public async Task<ActionResult<bool>> DeleteStudent([FromRoute] Guid studentPerformanceId)
    {
        return await _service.DeleteAsync(studentPerformanceId);
    }
}
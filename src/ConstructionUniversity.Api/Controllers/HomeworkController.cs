using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ConstructionUniversity.Domain.Homeworks;
using ConstructionUniversity.Api.Models.Homeworks;

namespace ConstructionUniversity.Api.Controllers;

[ApiController]
[Route("/api/homeworks")]
public class HomeworkController : ControllerBase
{
    private readonly IHomeworkService _service;
    private readonly IMapper _mapper;

    public HomeworkController(IHomeworkService homeworkService, IMapper mapper)
    {
        _service = homeworkService;
        _mapper = mapper;
    }

    [HttpGet("{homeworkId}")]
    public async Task<ActionResult<HomeworkDto>> GetHomework([FromRoute] Guid homeworkId)
    {
        return await _service.GetAsync(homeworkId) switch
        {
            null            => NotFound(),
            var homework    => _mapper.Map<HomeworkDto>(homework)
        };
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<HomeworkDto>>> GetHomeworks()
    {
        var homeworks = await _service.GetAllAsync();
        return _mapper.Map<HomeworkDto[]>(homeworks);
    }

    [HttpPost]
    public async Task<ActionResult<HomeworkDto>> AddHomework([FromBody] HomeworkDto homeworkDto)
    {
        var homework = _mapper.Map<Homework>(homeworkDto);
        var newHomework = await _service.NewAsync(homework);
        return _mapper.Map<HomeworkDto>(newHomework);
    }

    [HttpPut]
    public async Task<ActionResult<HomeworkDto>> UpdateHomework([FromBody] HomeworkDto homeworkDto)
    { 
        var homework = _mapper.Map<Homework>(homeworkDto);
        var updatedHomework = await _service.UpdateAsync(homework.Id, homework);
        return _mapper.Map<HomeworkDto>(updatedHomework);
    }

    [HttpDelete("{homeworkId}")]
    public async Task<ActionResult<bool>> DeleteHomework([FromRoute] Guid homeworkId)
    {
        return await _service.DeleteAsync(homeworkId);
    }
}
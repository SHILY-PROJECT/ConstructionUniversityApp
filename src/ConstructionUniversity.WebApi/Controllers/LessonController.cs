using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ConstructionUniversity.Domain.Lessons;
using ConstructionUniversity.WebApi.Models.Lessons;

namespace ConstructionUniversity.WebApi.Controllers;

[ApiController]
[Route("/api/lessons")]
public class LessonController : ControllerBase
{
    private readonly ILessonService _service;
    private readonly IMapper _mapper;

    public LessonController(ILessonService lessonService, IMapper mapper)
    {
        _service = lessonService;
        _mapper = mapper;
    }

    [HttpGet("{lessonId}")]
    public async Task<ActionResult<LessonDto>> GetLesson([FromRoute] Guid lessonId)
    {
        return await _service.GetAsync(lessonId) switch
        {
            null        => NotFound(),
            var lesson  => _mapper.Map<LessonDto>(lesson)
        };
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<LessonDto>>> GetLessons()
    {
        var lessons = await _service.GetAllAsync();
        return _mapper.Map<LessonDto[]>(lessons);
    }

    [HttpPost]
    public async Task<ActionResult<LessonDto>> AddLesson([FromBody] LessonDto lessonDto)
    {
        var lesson = _mapper.Map<Lesson>(lessonDto);
        var newLesson = await _service.NewAsync(lesson);
        return _mapper.Map<LessonDto>(newLesson);
    }

    [HttpPut]
    public async Task<ActionResult<LessonDto>> UpdateLesson([FromBody] LessonDto lessonDto)
    {
        var lesson = _mapper.Map<Lesson>(lessonDto);
        var updatedLesson = await _service.UpdateAsync(lesson.Id, lesson);
        return _mapper.Map<LessonDto>(updatedLesson);
    }

    [HttpDelete("{lessonId}")]
    public async Task<ActionResult<bool>> DeleteLesson([FromRoute] Guid lessonId)
    {
        return await _service.DeleteAsync(lessonId);
    }
}
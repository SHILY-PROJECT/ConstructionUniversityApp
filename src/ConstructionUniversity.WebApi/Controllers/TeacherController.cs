using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ConstructionUniversity.Domain.Teachers;
using ConstructionUniversity.WebApi.Models.Teachers;

namespace ConstructionUniversity.WebApi.Controllers;

[ApiController]
[Route("/api/teacher")]
public class TeacherController : ControllerBase
{
    private readonly ITeacherService _service;
    private readonly IMapper _mapper;

    public TeacherController(ITeacherService teacherService, IMapper mapper)
    {
        _service = teacherService;
        _mapper = mapper;
    }

    [HttpGet("{teacherId}")]
    public async Task<ActionResult<TeacherDto>> GetTeacher([FromRoute] Guid teacherId)
    {
        return await _service.GetAsync(teacherId) switch
        { 
            null        => NotFound(),
            var teacher => _mapper.Map<TeacherDto>(teacher)
        };
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<TeacherDto>>> GetTeachers()
    {
        var teachers = await _service.GetAllAsync();
        return _mapper.Map<TeacherDto[]>(teachers);
    }

    [HttpPost]
    public async Task<ActionResult<TeacherDto>> AddTeacher([FromBody] TeacherDto teacherDto)
    {
        var teacher = _mapper.Map<Teacher>(teacherDto);
        var newTeacher = await _service.NewAsync(teacher);
        return _mapper.Map<TeacherDto>(newTeacher);
    }

    [HttpPut]
    public async Task<ActionResult<TeacherDto>> UpdateTeacher([FromBody] TeacherDto teacherDto)
    {
        var teacher = _mapper.Map<Teacher>(teacherDto);
        var updatedTeacher = await _service.UpdateAsync(teacher.Id, teacher);
        return _mapper.Map<TeacherDto>(updatedTeacher);
    }

    [HttpDelete("{teacherId}")]
    public async Task<ActionResult<bool>> DeleteTeacher([FromRoute] Guid teacherId)
    {
        return await _service.DeleteAsync(teacherId);
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ConstructionUniversity.Domain.Students;
using ConstructionUniversity.Api.Models.JournalOfStudentPerformance;
using ConstructionUniversity.Api.Models.Students;

namespace ConstructionUniversity.Api.Controllers;

[ApiController]
[Route("/api/students")]
public class StudentController : ControllerBase
{
    private readonly IStudentService _service;
    private readonly IMapper _mapper;

    public StudentController(IStudentService studentService, IMapper mapper)
    {
        _service = studentService;
        _mapper = mapper;
    }

    [HttpGet("{studentId}")]
    public async Task<ActionResult<StudentDto>> GetStudent([FromRoute] Guid studentId)
    {
        return await _service.GetAsync(studentId) switch
        {
            null        => NotFound(),
            var student => _mapper.Map<StudentDto>(student)
        };
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyCollection<StudentDto>>> GetStudents()
    {
        var students = await _service.GetAllAsync();
        return _mapper.Map<StudentDto[]>(students);
    }

    [HttpGet("{studentId}/performance")]
    public async Task<ActionResult<IReadOnlyCollection<StudentPerformanceDto>>> GetStudentPerformance([FromRoute] Guid studentId)
    {
        var performanceLogByStudent = await _service.GetStudentPerformanceAsync(studentId);
        return _mapper.Map<StudentPerformanceDto[]>(performanceLogByStudent);
    }

    [HttpPost]
    public async Task<ActionResult<StudentDto>> AddStudent([FromBody] StudentDto studentDto)
    {
        var student = _mapper.Map<Student>(studentDto);
        var newStudent = await _service.NewAsync(student);
        return _mapper.Map<StudentDto>(newStudent);
    }

    [HttpPut]
    public async Task<ActionResult<StudentDto>> UpdateStudent([FromBody] StudentDto studentDto)
    {
        var student = _mapper.Map<Student>(studentDto);
        var updatedStudent = await _service.UpdateAsync(student.Id, student);
        return _mapper.Map<StudentDto>(updatedStudent);
    }

    [HttpDelete("{studentId}")]
    public async Task<ActionResult<bool>> DeleteStudent([FromRoute] Guid studentId)
    {
        return await _service.DeleteAsync(studentId);
    }
}
using EduCenterService.Application.Students.Commands;
using EduCenterService.Application.Students.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EduCenterService.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudentById(string id)
    {
        var student = await mediator.Send(new GetStudentByIdQuery(id));
        return Ok(student);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateStudent(CreateStudentCommand command)
    {
        var student = await mediator.Send(command);
        return Ok(student);
    }
}
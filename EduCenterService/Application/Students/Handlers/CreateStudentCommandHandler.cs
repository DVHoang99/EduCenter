using EduCenterService.Application.Students.Commands;
using EduCenterService.Application.Students.ViewModels;
using EduCenterService.Domain;
using EduCenterService.Persistence;
using MediatR;

namespace EduCenterService.Application.Students.Handlers;

public class CreateStudentCommandHandler(EduCenterDbContext context) : IRequestHandler<CreateStudentCommand, StudentViewModel>
{
    public async Task<StudentViewModel> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
    {
        var student = new Student
        {
            Name = command.Name,
            Email = command.Email,
            Phone = command.Phone,
        };
        
        context.Students.Add(student);
        await context.SaveChangesAsync(cancellationToken);

        return new StudentViewModel
        {
            Id = student.Id,
            Name = student.Name,
            Email = student.Email,
            Phone = student.Phone
        };
    }
}
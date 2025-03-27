using EduCenterService.Application.Students.Commands;
using EduCenterService.Application.Students.Interfaces;
using EduCenterService.Application.Students.ViewModels;
using EduCenterService.Persistence;
using MediatR;
using Student = EduCenterService.Domain.Student;

namespace EduCenterService.Application.Students.Handlers;

public class CreateStudentCommandHandler(EduCenterDbContext context, IStudents students) : IRequestHandler<CreateStudentCommand, StudentViewModel>
{
    public async Task<StudentViewModel> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
    {
        var student = students.CreateStudent(command.Name, command.Email, command.Phone);   
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
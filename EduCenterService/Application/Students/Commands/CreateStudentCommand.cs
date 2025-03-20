using EduCenterService.Application.Students.ViewModels;
using MediatR;

namespace EduCenterService.Application.Students.Commands;

public class CreateStudentCommand :  IRequest<StudentViewModel>
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}
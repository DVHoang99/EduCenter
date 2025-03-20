using EduCenterService.Application.Students.ViewModels;
using MediatR;

namespace EduCenterService.Application.Students.Queries;

public class GetStudentByIdQuery(string id) : IRequest<StudentViewModel>
{
    public string Id { get; } = id;
}
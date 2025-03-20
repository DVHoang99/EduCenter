using EduCenterService.Application.Students.Queries;
using EduCenterService.Application.Students.ViewModels;
using EduCenterService.Persistence;
using MediatR;

namespace EduCenterService.Application.Students.Handlers;

public class GetStudentByIdQueryHandler(EduCenterDbContext context) : IRequestHandler<GetStudentByIdQuery, StudentViewModel>
{
    public async Task<StudentViewModel> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        var student = await context.Students.FindAsync(request.Id, cancellationToken);
        
        if  (student == null) throw new Exception("Student not found");

        return StudentViewModel.FromResult(student);
    }
}
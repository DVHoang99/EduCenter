using EduCenterService.Domain;

namespace EduCenterService.Application.Students.ViewModels;

public class StudentViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public static StudentViewModel FromResult(Student student)
    {
        return new StudentViewModel
        {
            Id = student.Id,
            Name = student.Name,
            Email = student.Email,
            Phone = student.Phone,
        };
    }
}
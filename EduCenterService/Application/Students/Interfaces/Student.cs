namespace EduCenterService.Application.Students.Interfaces;

public class Student : IStudents
{
    public Domain.Student CreateStudent(string name, string email, string phone)
    {
        var student = new Domain.Student
        {
            Name = name,
            Email = email,
            Phone = phone,
        };

        return student;
    }
}
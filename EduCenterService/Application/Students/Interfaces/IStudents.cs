namespace EduCenterService.Application.Students.Interfaces;

public interface IStudents
{ 
    Domain.Student CreateStudent(string name, string email, string phone);
}
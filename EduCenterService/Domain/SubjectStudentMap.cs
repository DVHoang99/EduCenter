namespace EduCenterService.Domain;

public class SubjectStudentMap : Base
{
    public string SubjectMapId { get; set; }
    public List<Student> Students { get; set; }
}
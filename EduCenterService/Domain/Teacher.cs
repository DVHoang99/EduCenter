namespace EduCenterService.Domain;

public class Teacher : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public List<SubjectMap> SubjectMaps { get; set; }
}
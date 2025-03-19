namespace EduCenterService.Domain;

public class Subject : Base
{
    public string Name { get; set; }
    public List<SubjectMap> SubjectMaps { get; set; }
}
namespace EduCenterService.Domain;

public class Room : Base
{
    public int RoomNumber { get; set; }
    public List<SubjectMap> SubjectMaps { get; set; }
}
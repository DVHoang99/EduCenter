namespace EduCenterService.Domain;

public class SubjectMap : Base
{
    public string SubjectId { get; set; }
    public string TeacherId { get; set; }
    public string LevelId { get; set; }
    public string RoomId { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public DateTimeOffset EndTime { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
}

public enum DayOfWeek
{
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
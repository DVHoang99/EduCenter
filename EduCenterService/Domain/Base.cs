namespace EduCenterService.Domain;

public class Base
{
    public string Id { get; set; }
    public DateTimeOffset Created { get; set; }
    public DateTimeOffset? Updated { get; set; }
}
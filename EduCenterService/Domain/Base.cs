namespace EduCenterService.Domain;

public class Base
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTimeOffset Created { get; set; } = DateTimeOffset.UtcNow;
    public DateTimeOffset? Updated { get; set; }
}
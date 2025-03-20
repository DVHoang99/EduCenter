using EduCenterService.Domain;
using Microsoft.EntityFrameworkCore;

namespace EduCenterService.Persistence;

public class EduCenterDbContext(DbContextOptions<EduCenterDbContext> options) : DbContext(options)
{
    // dotnet ef migrations add Students_table --context EduCenterDbContext --output-dir Persistence/Migrations
    public DbSet<Student> Students { get; set; }
}
using EduCenterService.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EduCenterService.Persistence.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id)
            .HasColumnName("id")
            .HasMaxLength(50)
            .ValueGeneratedOnAdd();
        
        builder.Property(e => e.Name)
            .IsRequired()
            .HasColumnName("name")
            .HasMaxLength(50);

        builder.Property(e => e.Email)
            .HasColumnName("email");
        
        builder.Property(e => e.Phone)
            .HasColumnName("phone")
            .HasMaxLength(10);
        
        builder.Property(e => e.Created)
            .HasColumnName("created")
            .HasDefaultValueSql("getdate()");
    }
}
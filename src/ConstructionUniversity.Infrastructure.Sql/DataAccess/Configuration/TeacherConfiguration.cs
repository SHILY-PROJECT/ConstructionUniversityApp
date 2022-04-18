using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConstructionUniversity.Infrastructure.Sql.Teachers;

namespace ConstructionUniversity.Infrastructure.Sql.DataAccess.Configuration;

internal class TeacherConfiguration : IEntityTypeConfiguration<TeacherDb>
{
    public void Configure(EntityTypeBuilder<TeacherDb> builder)
    {
        builder.HasKey(t => t.Id);

        builder.Property(t => t.Id).ValueGeneratedOnAdd();
        builder.Property(t => t.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(t => t.LastName).HasMaxLength(50).IsRequired();
        builder.Property(t => t.MiddleName).HasMaxLength(50).IsRequired(false);
        builder.Property(t => t.Email).HasMaxLength(170).IsRequired();
    }
}
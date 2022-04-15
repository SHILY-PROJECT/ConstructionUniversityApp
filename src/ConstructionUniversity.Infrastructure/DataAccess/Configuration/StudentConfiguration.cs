using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConstructionUniversity.Infrastructure.Students;

namespace ConstructionUniversity.Infrastructure.DataAccess.Configuration;

internal class StudentConfiguration : IEntityTypeConfiguration<StudentDb>
{
    public void Configure(EntityTypeBuilder<StudentDb> builder)
    {
        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id).ValueGeneratedOnAdd();
        builder.Property(s => s.FirstName).HasMaxLength(50).IsRequired(true);
        builder.Property(s => s.LastName).HasMaxLength(50).IsRequired(true);
        builder.Property(s => s.MiddleName).HasMaxLength(50).IsRequired(false);
        builder.Property(s => s.Email).HasMaxLength(170).IsRequired(true);
    }
}
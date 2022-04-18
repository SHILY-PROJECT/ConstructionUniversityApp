using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConstructionUniversity.Infrastructure.Sql.Lessons;

namespace ConstructionUniversity.Infrastructure.Sql.DataAccess.Configuration;

internal class LessonConfiguration : IEntityTypeConfiguration<LessonDb>
{
    public void Configure(EntityTypeBuilder<LessonDb> builder)
    {
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Id).ValueGeneratedOnAdd();
        builder.Property(l => l.Date).IsRequired();
        builder.Property(l => l.Name).HasMaxLength(200).IsRequired();

        builder
            .HasOne(l => l.Teacher)
            .WithMany()
            .HasForeignKey(l => l.TeacherId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
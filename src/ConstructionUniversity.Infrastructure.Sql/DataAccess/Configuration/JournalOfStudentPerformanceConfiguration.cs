using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConstructionUniversity.Infrastructure.Sql.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.Sql.DataAccess.Configuration;

internal class JournalOfStudentPerformanceConfiguration : IEntityTypeConfiguration<StudentPerformanceDb>
{
    public void Configure(EntityTypeBuilder<StudentPerformanceDb> builder)
    {
        builder.HasKey(sp => sp.Id);

        builder.Property(sp => sp.Id).ValueGeneratedOnAdd();
        builder.Property(sp => sp.StudentId).IsRequired();
        builder.Property(sp => sp.LessonId).IsRequired();
        builder.Property(sp => sp.IsWas).IsRequired();

        builder
            .HasOne(sp => sp.Homework)
            .WithMany()
            .HasForeignKey(sp => sp.HomeworkId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(sp => sp.Lesson)
            .WithMany()
            .HasForeignKey(sp => sp.LessonId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(sp => sp.Student)
            .WithMany()
            .HasForeignKey(sp => sp.StudentId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
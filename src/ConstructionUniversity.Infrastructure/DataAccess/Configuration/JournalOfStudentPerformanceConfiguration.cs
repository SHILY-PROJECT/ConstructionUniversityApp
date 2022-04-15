using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConstructionUniversity.Infrastructure.JournalOfStudentPerformance;

namespace ConstructionUniversity.Infrastructure.DataAccess.Configuration;

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
            .HasOne(sp => sp.HomeworkWithMark)
            .WithOne(h => h.StudentPerformance)
            .HasForeignKey<StudentPerformanceDb>(sp => sp.HomeworkWithMarkId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(sp => sp.Lesson)
            .WithMany(nameof(StudentPerformanceDb))
            .HasForeignKey(sp => sp.LessonId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(sp => sp.Student)
            .WithMany(nameof(StudentPerformanceDb))
            .HasForeignKey(sp => sp.StudentId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
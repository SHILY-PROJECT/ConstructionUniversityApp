using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConstructionUniversity.Infrastructure.Homeworks;

namespace ConstructionUniversity.Infrastructure.DataAccess.Configuration;

internal class HomeworkWithMarkConfiguration : IEntityTypeConfiguration<HomeworkWithMarkDb>
{
    public void Configure(EntityTypeBuilder<HomeworkWithMarkDb> builder)
    {
        builder.HasKey(hm => hm.Id);

        builder.Property(hm => hm.Mark).IsRequired();
        builder.Property(hm => hm.HomeworkId).IsRequired();

        builder
            .HasOne(hm => hm.Homework)
            .WithMany()
            .HasForeignKey(hm => hm.HomeworkId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
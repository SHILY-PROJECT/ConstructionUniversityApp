using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ConstructionUniversity.Infrastructure.Homeworks;

namespace ConstructionUniversity.Infrastructure.DataAccess.Configuration;

internal class HomeworkConfiguration : IEntityTypeConfiguration<HomeworkDb>
{
    public void Configure(EntityTypeBuilder<HomeworkDb> builder)
    {
        builder.HasKey(h => h.Id);

        builder.Property(h => h.Id).ValueGeneratedOnAdd();
        builder.Property(h => h.Name).HasMaxLength(200).IsRequired(true);
        builder.Property(h => h.Discription).HasMaxLength(500).IsRequired(false);
    }
}
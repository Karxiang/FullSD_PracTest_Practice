using FullSDPrac.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FullSDPrac.Server.Entities
{
    public class TaskItemSeedConfiguration : IEntityTypeConfiguration<TaskItem>
    {
        public void Configure(EntityTypeBuilder<TaskItem> builder)
        {


            builder.HasData(
                new TaskItem
                {
                    Id = 1,
                    TaskName = "Shower",
                    IsCompleted = false,
                    DueDate = new DateTime(2024, 04, 18),
                    CreatedDate = new DateTime(2024, 01, 19),
                    CreatedBy = "James",
                }

                );
        }
    }
}

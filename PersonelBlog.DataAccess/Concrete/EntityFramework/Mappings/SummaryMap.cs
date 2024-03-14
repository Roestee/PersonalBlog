using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SummaryMap: IEntityTypeConfiguration<Summary>
    {
        public void Configure(EntityTypeBuilder<Summary> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(500)");
            builder.ToTable("Summary");
            builder.HasData(new Summary
            {
                Id = 1,
                CreatedBy = "InitialCreated",
                ModifiedBy = "InitialCreated",
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now,
                IsActive = false,
                IsDelete = false,
                Content = "Content"
            });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AboutMeMap: IEntityTypeConfiguration<AboutMe>
    {
        public void Configure(EntityTypeBuilder<AboutMe> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.FirstName).HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(30);
            builder.Property(x => x.BirthDate).IsRequired();
            builder.Property(x => x.Job).IsRequired();
            builder.Property(x => x.Job).HasMaxLength(30);
            builder.Property(x => x.JobFA).IsRequired();
            builder.Property(x => x.JobFA).HasMaxLength(150);
            builder.Property(x => x.ImageUrl).IsRequired();
            builder.Property(x => x.ImageUrl).HasMaxLength(250);
            builder.Property(x => x.CVUrl).IsRequired();
            builder.Property(x => x.CVUrl).HasMaxLength(250);
            builder.ToTable("AboutMe");
            builder.HasData(new AboutMe
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                FirstName = "İbrahim",
                LastName = "Çınğı",
                BirthDate = DateTime.Parse("05.04.1996"),
                Job = "Software Developer",
                JobFA = "<i class=\"fa-solid fa-laptop-code\"></i>",
                ImageUrl = "",
                CVUrl = ""
            });
        }
    }
}

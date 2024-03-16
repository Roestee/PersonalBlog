using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class EducationMap: IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.School).IsRequired();
            builder.Property(x => x.School).HasMaxLength(100);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(30);
            builder.Property(x => x.Avarage).IsRequired();
            builder.Property(x => x.Avarage).HasMaxLength(30);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("Education");
            builder.HasData(new Education
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Title = "Lisans",
                School = "Kocaeli Mekatronik Mühendisliği",
                Duration = "2014-2021",
                Avarage = "2.59",
                Description = "1 sene ingilizce hazırlık olmak üzere %30 ingilizce mekatronik mühendisliği eğitimimi tamamladım."
            });
        }
    }
}

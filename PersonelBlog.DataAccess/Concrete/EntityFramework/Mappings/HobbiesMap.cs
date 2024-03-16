using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class HobbiesMap: IEntityTypeConfiguration<Hobbies>
    {
        public void Configure(EntityTypeBuilder<Hobbies> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x=>x.Text).IsRequired();
            builder.Property(x=>x.Text).HasMaxLength(300);
            builder.ToTable("Hobbies");
            builder.HasData(new Hobbies
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Text = "Bilgisayar Donanımları, Bileşenleri ve Yazılımları",
            });
            builder.HasData(new Hobbies
            {
                Id = 2,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Text = "Vizyon filmleri takip etmek ve izlemek, Film incelemelerini okumak",
            });
        }
    }
}

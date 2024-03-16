using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class HomePageSlidersMap: IEntityTypeConfiguration<HomePageSliders>
    {
        public void Configure(EntityTypeBuilder<HomePageSliders> builder)
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
            builder.Property(x => x.Title).HasMaxLength(40);
            builder.Property(x => x.ShortContent).IsRequired();
            builder.Property(x => x.ShortContent).HasMaxLength(500);       
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.Content).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("HomePageSliders");
            builder.HasData(new HomePageSliders
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Title = "Unity Game Developer",
                ShortContent = "Unity Oyun Motoru Ile Oyun Geliştirilmesi",
                Content = "Unity ile sıfırdan oyun prototipleri\r\nhazırlama,\r\nc# diliyle yeniden kullanılabilir, temiz, SOLID\r\nprensiplerine uygun kodlarının hazırlanması.\r\nLevel ve UI Tasarımlarının yapılması."
            });
        }
    }
}

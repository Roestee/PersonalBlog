using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ExperiencesMap: IEntityTypeConfiguration<Experiences>
    {
        public void Configure(EntityTypeBuilder<Experiences> builder)
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
            builder.Property(x => x.CompanyName).IsRequired();
            builder.Property(x => x.CompanyName).HasMaxLength(200);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.Duration).HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("Experiences");
            builder.HasData(new Experiences
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Title = "STAJ - ENDİSTÜRİYEL MAKİNE TASARIMI",
                CompanyName = "Altesa Mühendislik",
                Description = "CREO ile Makine kaynak montaj fikstürlerinin 3D modellerin hazırlanması, imalat için 2D teknik resimlerinin, montaj resimlerinin hazırlanması",
                Duration = "06.2016/09.2016"
            });
            builder.HasData(new Experiences
            {
                Id = 2,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Title = "SANPARK - ENDİSTÜRİYEL MAKİNE TASARIMI",
                CompanyName = "SANPARK SMART PARKING SYSTEM",
                Description = "Solidwork ile akıllı katlı otopark sistemlerinin AR-GE’si. 3D modellerinin yapılması, 2D teknik çizimlerinin  Hazırlanması. Iso 9001 -2018 Kapsamında şirketin kalite kontrol sisteminin kurulması, makinelerin bakım ve kontrollerinin planlanması.",
                Duration = "07.2021/07.2022"
            });
            builder.HasData(new Experiences
            {
                Id = 3,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Title = "NiceTry Games Studio - OYUN YAZILIMCISI",
                CompanyName = "NiceTry Games Studio",
                Description = "Unity ile sıfırdan oyun prototipleri hazırlama, c# diliyle yeniden kullanılabilir, temiz, SOLID prensiplerine uygun kodlarının hazırlanması. Level ve UI Tasarımlarının yapılması.",
                Duration = "07.2022/03.2024"
            });
        }
    }
}

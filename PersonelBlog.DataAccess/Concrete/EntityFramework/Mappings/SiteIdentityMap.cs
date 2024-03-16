using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SiteIdentityMap: IEntityTypeConfiguration<SiteIdentity>
    {
        public void Configure(EntityTypeBuilder<SiteIdentity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x=>x.Title).IsRequired();
            builder.Property(x=>x.Title).HasMaxLength(50);
            builder.Property(x=>x.Keywords).IsRequired();
            builder.Property(x=>x.Keywords).HasMaxLength(150);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.LogoFA).IsRequired();
            builder.Property(x => x.LogoFA).HasMaxLength(150);
            builder.Property(x => x.LogoText).IsRequired();
            builder.Property(x => x.LogoText).HasMaxLength(20);
            builder.ToTable("SiteIdentity");
            builder.HasData(new SiteIdentity
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Title = "İbrahim Çınğı",
                Keywords = "C#, NET, WEB, SOFTWARE, .NET",
                Description = "Ibrahim Çınğı Developer",
                LogoFA = "<i class= \"fas fa-h-square\"></i>",
                LogoText = "İbrahim Çınğı"
            });

        }
    }
}

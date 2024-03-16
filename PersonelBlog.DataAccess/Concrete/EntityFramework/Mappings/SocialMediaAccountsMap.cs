using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class SocialMediaAccountsMap: IEntityTypeConfiguration<SocialMediaAccounts>
    {
        public void Configure(EntityTypeBuilder<SocialMediaAccounts> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x=>x.Account).IsRequired();
            builder.Property(x=>x.Account).HasMaxLength(30);
            builder.Property(x=>x.AccountFA).IsRequired();
            builder.Property(x=>x.AccountFA).HasMaxLength(150);  
            builder.Property(x=>x.AccountUrl).IsRequired();
            builder.Property(x=>x.AccountUrl).HasMaxLength(150);
            builder.ToTable("SocialMediaAccounts");
            builder.HasData(new SocialMediaAccounts
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Account = "Linkedin",
                AccountFA = "<i class=\"fa-brands fa-linkedin\"></i>",
                AccountUrl = "https://www.linkedin.com/in/ibrahim-cingi/"
            });
            builder.HasData(new SocialMediaAccounts
            {
                Id = 2,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Account = "Instagram",
                AccountFA = "<i class=\"fa-brands fa-instagram\"></i>",
                AccountUrl = "https://www.instagram.com/ibrahimcngi"
            });
            builder.HasData(new SocialMediaAccounts
            {
                Id = 3,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Account = "Github",
                AccountFA = "<i class=\"fa-brands fa-github\"></i>",
                AccountUrl = "https://www.github.com/Roestee"
            });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AdminMap: IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(250);
            builder.Property(x => x.SecurityQuestion).IsRequired();
            builder.Property(x => x.SecurityQuestion).HasMaxLength(200);
            builder.Property(x => x.SecurityQuestionAnswer).IsRequired();
            builder.Property(x => x.SecurityQuestionAnswer).HasMaxLength(250);
            builder.ToTable("Admin");
            builder.HasData(new Admin
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                Email = "ibrahmcingi@gmail.com",
                Password = "0a03d005fde3340906dc104434906a46",
                SecurityQuestion = "Anne Kızlık Soyadı",
                SecurityQuestionAnswer = "d10de61f3ecca60a812b7f13f820fe8d"
            });
        }
    }
}

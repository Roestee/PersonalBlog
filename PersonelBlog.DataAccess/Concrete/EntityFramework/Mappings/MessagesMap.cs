using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class MessagesMap: IEntityTypeConfiguration<Messages>
    {
        public void Configure(EntityTypeBuilder<Messages> builder)
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
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(100);
            builder.Property(x => x.Subject).IsRequired();
            builder.Property(x => x.Subject).HasMaxLength(100);  
            builder.Property(x => x.Text).IsRequired();
            builder.Property(x => x.Text).HasColumnType("NVARCHAR(MAX)");
            builder.ToTable("Messages");
            builder.HasData(new Messages
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                FirstName = "Hasan",
                LastName = "Erdal",
                Email = "test@gmail.com",
                Subject = "Test",
                Text = "Test"
            });
        }
    }
}

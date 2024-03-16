using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class ContactInfoMap: IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedBy).HasMaxLength(50);
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.ModifiedBy).HasMaxLength(50);
            builder.Property(x => x.ModifiedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDelete).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.ShortAdress).IsRequired();
            builder.Property(x => x.ShortAdress).HasMaxLength(35);
            builder.Property(x => x.LongAdress).IsRequired();
            builder.Property(x => x.LongAdress).HasMaxLength(150);
            builder.ToTable("ContactInfo");
            builder.HasData(new ContactInfo
            {
                Id = 1,
                CreatedTime = DateTime.Now,
                CreatedBy = "InitialCreated",
                ModifiedTime = DateTime.Now,
                ModifiedBy = "InitialCreated",
                IsActive = false,
                IsDelete = false,
                PhoneNumber = "+905319857784",
                Email = "ibrahmcingi@gmail.com",
                ShortAdress = "Yıldırım/BURSA",
                LongAdress = "Bağlaraltı Mah. Erikli Cad. A302. Sokak Erikli Evleri Kat:5 D:23"
            });

        }
    }
}

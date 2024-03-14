using Microsoft.EntityFrameworkCore;
using PersonalBlog.DataAccess.Concrete.EntityFramework.Mappings;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Concrete.Complex;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Contexts
{
    public class BlogContext: DbContext
    {
        public DbSet<Summary> Summary { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }
        public DbSet<SocialMediaAccounts> SocialMediaAccounts { get; set; }
        public DbSet<HomePageSliders> HomePageSliders { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Experiences> Experiences { get; set; }
        public DbSet<Messages> Messages { get; set; }
        public DbSet<SiteIdentity> SiteIdentity { get; set; }
        public DbSet<AboutMe> AboutMe { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<ContactInfo> ContactInfo { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Comment> Comment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @".;Database=PersonalBlog;Trusted_Connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SummaryMap());
        }
    }
}

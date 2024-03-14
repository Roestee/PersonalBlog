using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class AboutMe: EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Job { get; set; }
        public string JobFA { get; set; }
        public DateTime BirthDate { get; set; }
        public string CVUrl { get; set; }
    }
}

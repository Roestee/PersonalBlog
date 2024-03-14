using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class Experiences: EntityBase, IEntity
    {
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }
}

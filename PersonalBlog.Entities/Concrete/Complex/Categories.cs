using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete.Complex
{
    public class Categories: EntityBase, IEntity
    {
        public string Name { get; set; }
        public string CategoryFA { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}

using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class Summary: EntityBase, IEntity
    {
        public string Content { get; set; }
    }
}

using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class Hobbies: EntityBase, IEntity
    {
        public string Text { get; set; } 
    }
}

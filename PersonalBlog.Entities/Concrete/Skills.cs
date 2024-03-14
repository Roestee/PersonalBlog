using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class Skills: EntityBase, IEntity
    {
        public string Title { get; set; }
        public int PercentageValue { get; set; }
    }
}

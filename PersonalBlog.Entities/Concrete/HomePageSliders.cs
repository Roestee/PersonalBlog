using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class HomePageSliders : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
    }
}

using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete.Complex
{
    public class Article: EntityBase, IEntity
    {
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public int ViewCount { get; set; } = 0;
        public string SeoTags { get; set; }
        public string SeoDescription { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}

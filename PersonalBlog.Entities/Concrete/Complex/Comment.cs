using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete.Complex
{
    public class Comment: EntityBase, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Text { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}

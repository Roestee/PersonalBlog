using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class SocialMediaAccounts: EntityBase, IEntity
    {
        public string Account { get; set; }
        public string AccountFA { get; set; }
        public string AccountUrl { get; set; }
    }
}

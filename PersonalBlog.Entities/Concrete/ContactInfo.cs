using PersonalBlog.Core.Entities.Abstract;

namespace PersonalBlog.Entities.Concrete
{
    public class ContactInfo: EntityBase, IEntity
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ShortAdress { get; set;}
        public string LongAdress { get; set;}
    }
}

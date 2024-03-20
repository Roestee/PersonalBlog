using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.Entities.Dtos.MessagesDtos
{
    public class MessagesListDto
    {
        public IList<Messages> MessagesList { get; set; }
    }
}

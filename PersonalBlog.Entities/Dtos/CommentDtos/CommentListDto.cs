using PersonalBlog.Entities.Concrete.Complex;

namespace PersonalBlog.Entities.Dtos.CommentDtos
{
    public class CommentListDto
    {
        public IList<Comment> CommentList { get; set; }
    }
}

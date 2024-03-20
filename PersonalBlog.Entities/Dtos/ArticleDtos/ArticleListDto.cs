using PersonalBlog.Entities.Concrete.Complex;

namespace PersonalBlog.Entities.Dtos.ArticleDtos
{
    public class ArticleListDto
    {
        public IList<Article> ArticleList { get; set; }
    }
}

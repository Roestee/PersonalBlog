using PersonalBlog.Core.Data.Abstract;
using PersonalBlog.Entities.Concrete.Complex;

namespace PersonalBlog.DataAccess.Abstract
{
    public interface IArticleRepository: IEntityRepository<Article>
    {

    }
}

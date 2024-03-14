using PersonalBlog.Core.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.DataAccess.Abstract;
using PersonalBlog.Entities.Concrete.Complex;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository: EfEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }
    }
}

using PersonalBlog.Core.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.Entities.Concrete.Complex;
using PersonalBlog.DataAccess.Abstract.Repositories;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoriesRepository: EfEntityRepositoryBase<Categories>, ICategoriesRepository
    {
        public EfCategoriesRepository(DbContext context) : base(context)
        {
        }
    }
}

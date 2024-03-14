using Microsoft.EntityFrameworkCore;
using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.DataAccess.Abstract;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfSummaryRepository: EfEntityRepositoryBase<Summary>, ISummaryRepository
    {
        public EfSummaryRepository(DbContext context) : base(context)
        {

        }
    }
}

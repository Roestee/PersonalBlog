using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.DataAccess.Abstract.Repositories;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfEducationRepository: EfEntityRepositoryBase<Education>, IEducationRepository
    {
        public EfEducationRepository(DbContext context) : base(context)
        {
        }
    }
}

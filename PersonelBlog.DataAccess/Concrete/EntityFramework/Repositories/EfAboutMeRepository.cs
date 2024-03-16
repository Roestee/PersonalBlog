using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.DataAccess.Abstract.Repositories;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfAboutMeRepository: EfEntityRepositoryBase<AboutMe>, IAboutMeRepository
    {
        public EfAboutMeRepository(DbContext context) : base(context)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.DataAccess.Abstract;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfHobbiesRepository: EfEntityRepositoryBase<Hobbies>, IHobbiesRepository
    {
        public EfHobbiesRepository(DbContext context) : base(context)
        {
        }
    }
}

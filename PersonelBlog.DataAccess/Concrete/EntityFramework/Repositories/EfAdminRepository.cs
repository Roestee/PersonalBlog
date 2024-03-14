using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.DataAccess.Abstract;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfAdminRepository: EfEntityRepositoryBase<Admin>, IAdminRepository
    {
        public EfAdminRepository(DbContext context) : base(context)
        {
        }
    }
}

using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.DataAccess.Abstract.Repositories;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfSiteIdentityRepository: EfEntityRepositoryBase<SiteIdentity>, ISiteIdentityRepository
    {
        public EfSiteIdentityRepository(DbContext context) : base(context)
        {
        }
    }
}

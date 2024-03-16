using Microsoft.EntityFrameworkCore;
using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.DataAccess.Abstract.Repositories;
using PersonalBlog.Entities.Concrete;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfSocialMediaAccountsRepository: EfEntityRepositoryBase<SocialMediaAccounts>, ISocialMediaAccountRepository
    {
        public EfSocialMediaAccountsRepository(DbContext context) : base(context)
        {
        }
    }
}

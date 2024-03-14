using PersonalBlog.Core.Data.Concrete.EntityFramework;
using PersonalBlog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using PersonalBlog.DataAccess.Abstract;

namespace PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfMessagesRepository: EfEntityRepositoryBase<Messages>, IMessagesRepository
    {
        public EfMessagesRepository(DbContext context) : base(context)
        {
        }
    }
}

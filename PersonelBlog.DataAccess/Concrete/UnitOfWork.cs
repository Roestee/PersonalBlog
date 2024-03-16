using PersonalBlog.DataAccess.Abstract;
using PersonalBlog.DataAccess.Abstract.Repositories;
using PersonalBlog.DataAccess.Concrete.EntityFramework.Contexts;
using PersonalBlog.DataAccess.Concrete.EntityFramework.Repositories;

namespace PersonalBlog.DataAccess.Concrete
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly BlogContext _context;
        private EfSummaryRepository _efSummaryRepository;
        private EfHobbiesRepository _efHobbiesRepository;
        private EfSocialMediaAccountsRepository _efSocialMediaAccountsRepository;
        private EfHomePageSlidersRepository _efHomePageSlidersRepository;
        private EfSkillsRepository _efSkillsRepository;
        private EfExperiencesRepository _efExperiencesRepository;
        private EfMessagesRepository _efMessagesRepository;
        private EfSiteIdentityRepository _efSiteIdentityRepository;
        private EfAboutMeRepository _efAboutMeRepository;
        private EfAdminRepository _efAdminRepository;
        private EfEducationRepository _efEducationRepository;
        private EfContactInfoRepository _efContactInfoRepository;
        private EfArticleRepository _efArticleRepository;
        private EfCategoriesRepository _efCategoriesRepository;
        private EfCommentRepository _efCommentRepository;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }

        public ISummaryRepository SummaryRepository => _efSummaryRepository?? new EfSummaryRepository(_context);
        public IHobbiesRepository HobbiesRepository => _efHobbiesRepository ?? new EfHobbiesRepository(_context);
        public ISocialMediaAccountRepository SocialMediaAccountRepository => _efSocialMediaAccountsRepository ?? new EfSocialMediaAccountsRepository(_context);
        public IHomePageSliderRepository HomePageSliderRepository => _efHomePageSlidersRepository ?? new EfHomePageSlidersRepository(_context);
        public ISkillsRepository SkillRepository => _efSkillsRepository ?? new EfSkillsRepository(_context);
        public IExperiencesRepository ExperiencesRepository => _efExperiencesRepository ?? new EfExperiencesRepository(_context);
        public IMessagesRepository MessagesRepository => _efMessagesRepository ?? new EfMessagesRepository(_context);
        public ISiteIdentityRepository SiteIdentityRepository => _efSiteIdentityRepository ?? new EfSiteIdentityRepository(_context);
        public IAboutMeRepository AboutMeRepository => _efAboutMeRepository ?? new EfAboutMeRepository(_context);
        public IAdminRepository AdminRepository => _efAdminRepository ?? new EfAdminRepository(_context);
        public IEducationRepository EducationRepository => _efEducationRepository ?? new EfEducationRepository(_context);
        public IContactInfoRepository ContactInfoRepository => _efContactInfoRepository ?? new EfContactInfoRepository(_context);
        public IArticleRepository ArticleRepository => _efArticleRepository ?? new EfArticleRepository(_context);
        public ICategoriesRepository CategoriesRepository => _efCategoriesRepository ?? new EfCategoriesRepository(_context);
        public ICommentRepository CommentRepository => _efCommentRepository ?? new EfCommentRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

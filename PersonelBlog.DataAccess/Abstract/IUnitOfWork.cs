using PersonalBlog.DataAccess.Abstract.Repositories;

namespace PersonalBlog.DataAccess.Abstract
{
    public interface IUnitOfWork: IAsyncDisposable
    {
        ISummaryRepository SummaryRepository { get; }
        IHobbiesRepository HobbiesRepository { get; }
        ISocialMediaAccountRepository SocialMediaAccountRepository { get; }
        IHomePageSliderRepository HomePageSliderRepository { get; }
        ISkillsRepository SkillRepository { get; }
        IExperiencesRepository ExperiencesRepository { get; }
        IMessagesRepository MessagesRepository { get; }
        ISiteIdentityRepository SiteIdentityRepository { get; }
        IAboutMeRepository AboutMeRepository { get; }
        IAdminRepository AdminRepository { get; }
        IEducationRepository EducationRepository { get; }
        IContactInfoRepository ContactInfoRepository { get; }
        IArticleRepository ArticleRepository { get; }
        ICategoriesRepository CategoriesRepository { get; }
        ICommentRepository CommentRepository { get; }

        Task<int> SaveAsync();
    }
}

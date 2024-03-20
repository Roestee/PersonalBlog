using Microsoft.Extensions.DependencyInjection;
using PersonalBlog.Business.Abstract;
using PersonalBlog.Business.Concrete;
using PersonalBlog.DataAccess.Abstract;
using PersonalBlog.DataAccess.Concrete;
using PersonalBlog.DataAccess.Concrete.EntityFramework.Contexts;

namespace PersonalBlog.Business.Extensions
{
    public static class CustomServiceCollection
    {
        public static IServiceCollection MyCustomService(this IServiceCollection services)
        {
            services.AddDbContext<BlogContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ISummaryService, SummaryService>();
            return services;
        }
    }
}

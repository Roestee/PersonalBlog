using AutoMapper;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.SummaryDtos;

namespace PersonalBlog.Business.AutoMapper
{
    public class EntityProfile: Profile
    {
        public EntityProfile()
        {
            CreateMap<Summary, SummaryUpdateDto>().ReverseMap();
        }
    }
}

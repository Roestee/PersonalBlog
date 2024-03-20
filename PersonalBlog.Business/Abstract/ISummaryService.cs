using PersonalBlog.Core.Utilities.Abstract;
using PersonalBlog.Entities.Dtos.SummaryDtos;

namespace PersonalBlog.Business.Abstract
{
    public interface ISummaryService
    {
        Task<IDataResult<SummaryDto>> GetAsync(int id);
        Task<IDataResult<SummaryDto>> UpdateAsync(SummaryUpdateDto summaryUpdateDto);
    }
}

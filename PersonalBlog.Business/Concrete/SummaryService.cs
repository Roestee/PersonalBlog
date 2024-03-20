using AutoMapper;
using PersonalBlog.Business.Abstract;
using PersonalBlog.Core.Utilities.Abstract;
using PersonalBlog.Core.Utilities.ComplexTypes;
using PersonalBlog.Core.Utilities.Concrete;
using PersonalBlog.DataAccess.Abstract;
using PersonalBlog.Entities.Concrete;
using PersonalBlog.Entities.Dtos.SummaryDtos;

namespace PersonalBlog.Business.Concrete
{
    public class SummaryService: ISummaryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SummaryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IDataResult<SummaryDto>> GetAsync(int id)
        {
            var summary = await _unitOfWork.SummaryRepository.GetAsync(x => x.Id == id);
            return summary == null ? 
                new DataResult<SummaryDto>(ResultStatus.Error, "Kayıt Bulunamadı!", null) : 
                new DataResult<SummaryDto>(ResultStatus.Success, new SummaryDto { Summary = summary });
        }

        public async Task<IDataResult<SummaryDto>> UpdateAsync(SummaryUpdateDto summaryUpdateDto)
        {
            if (summaryUpdateDto == null)
                return new DataResult<SummaryDto>(ResultStatus.Error, "Girdiğiniz bilgileri kontrol ediniz!", null);

            var summary = _mapper.Map<Summary>(summaryUpdateDto);
            await _unitOfWork.SummaryRepository.UpdateAsync(summary);
            await _unitOfWork.SaveAsync();
            return new DataResult<SummaryDto>(ResultStatus.Success, new SummaryDto { Summary = summary });
        }
    }
}

using PersonalBlog.Core.Utilities.Abstract;
using PersonalBlog.Core.Utilities.ComplexTypes;

namespace PersonalBlog.Core.Utilities.Concrete
{
    public class Result: IResult
    {
        public Result(ResultStatus resultStatus)
        {
            ResultStatus = resultStatus;
        }

        public Result(ResultStatus resultStatus, string info)
        {
            ResultStatus = resultStatus;
            Info = info;
        }

        public Result(ResultStatus resultStatus, string info, Exception exception)
        {
            ResultStatus = resultStatus;
            Info = info;
            Exception = exception;
        }

        public ResultStatus ResultStatus { get; }
        public string Info { get; }
        public Exception Exception { get; }
    }
}

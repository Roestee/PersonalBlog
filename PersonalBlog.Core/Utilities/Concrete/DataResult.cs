using PersonalBlog.Core.Utilities.Abstract;
using PersonalBlog.Core.Utilities.ComplexTypes;

namespace PersonalBlog.Core.Utilities.Concrete
{
    public class DataResult<T>: IDataResult<T>
    {
        public DataResult(ResultStatus resultStatus, T data)
        {
            ResultStatus = resultStatus;
            Data = data;
        }
        public DataResult(ResultStatus resultStatus, string info, T data)
        {
            ResultStatus = resultStatus;
            Info = info;
            Data = data;
        }

        public DataResult(ResultStatus resultStatus, string info, Exception exception, T data)
        {
            ResultStatus = resultStatus;
            Info = info;
            Exception = exception;
            Data = data;
        }

        public ResultStatus ResultStatus { get; }
        public string Info { get; }
        public Exception Exception { get; }
        public T Data { get; }
    }
}
